using Engine;
namespace RPG_Project;

using System.ComponentModel;
using System.IO;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading;


public partial class RPG_Project : Form
{
    private Dictionary<int, int> _monstersRemainingByLocation = new Dictionary<int, int>();
    private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

    private Player _player;
    private Monster _currentMonster;

    public RPG_Project()
    {
        InitializeComponent();
    }
    private void RPG_Project_Load(object sender, EventArgs e)
    {
        if (File.Exists(PLAYER_DATA_FILE_NAME))
        {
            _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
        }
        else
        {
            _player = Player.CreateDefaultPlayer();
        }
        lblHitPoints.DataBindings.Add("Text", _player, "CurrentHitPoints");
        lblGold.DataBindings.Add("Text", _player, "Gold");
        lblExperience.DataBindings.Add("Text", _player, "ExperiencePoints");
        lblLevel.DataBindings.Add("Text", _player, "Level");

        cboWeapons.DataSource = _player.Weapons;
        cboWeapons.DisplayMember = "Name";
        cboWeapons.ValueMember = "Id";
        if (_player.CurrentWeapon != null)
        {
            cboWeapons.SelectedItem = _player.CurrentWeapon;
        }
        cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;
        cboPotions.DataSource = _player.Potions;
        cboPotions.DisplayMember = "Name";
        cboPotions.ValueMember = "Id";
        _player.PropertyChanged += PlayerOnPropertyChanged;

        MoveTo(_player.CurrentLocation);

        dgvInventory.RowHeadersVisible = false;
        dgvInventory.AutoGenerateColumns = false;
        dgvInventory.DataSource = _player.Inventory;
        dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Name",
            Width = 197,
            DataPropertyName = "Description"
        });
        dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Quantity",
            DataPropertyName = "Quantity"
        });
        dgvQuests.RowHeadersVisible = false;
        dgvQuests.AutoGenerateColumns = false;
        dgvQuests.DataSource = _player.Quests;
        dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Name",
            Width = 197,
            DataPropertyName = "Name"
        });
        dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Done?",
            DataPropertyName = "IsCompleted"
        });
    }

    private async void btnNorth_Click(object sender, EventArgs e)
    {
        MoveTo(_player.CurrentLocation.LocationToNorth);
        await PlaySteps();
    }

    private async void btnEast_Click(object sender, EventArgs e)
    {
        MoveTo(_player.CurrentLocation.LocationToEast);
        await PlaySteps();
    }

    private async void btnSouth_Click(object sender, EventArgs e)
    {
        MoveTo(_player.CurrentLocation.LocationToSouth);
        await PlaySteps();
    }

    private async void btnWest_Click(object sender, EventArgs e)
    {
        MoveTo(_player.CurrentLocation.LocationToWest);
        await PlaySteps();
    }
    private async Task PlaySteps()
    {
        var sound1 = new SoundPlayer("Sounds/st2-footstep.wav");
        sound1.Play();
        await Task.Delay(600);

        var sound2 = new SoundPlayer("Sounds/st3-footstep.wav");
        sound2.Play();
    }

    private void MoveTo(Location newLocation)
    {
        //Does the location have any required items
        if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
        {
            rtbMessages.AppendText("You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine);
            return;
        }

        // Update the player's current location
        _player.CurrentLocation = newLocation;


        // Show/hide available movement buttons
        btnNorth.Visible = (newLocation.LocationToNorth != null);
        btnEast.Visible = (newLocation.LocationToEast != null);
        btnSouth.Visible = (newLocation.LocationToSouth != null);
        btnWest.Visible = (newLocation.LocationToWest != null);

        // Display current location name and description
        rtbLocation.Text = newLocation.Name + Environment.NewLine;
        rtbLocation.Text += newLocation.Description + Environment.NewLine;

        // Completely heal the player
        _player.CurrentHitPoints = _player.MaximumHitPoints;

        // Update Hit Points in UI
        lblHitPoints.Text = _player.CurrentHitPoints.ToString();

        // Does the location have a quest?
        if (newLocation.QuestAvailableHere != null)
        {
            // See if the player already has the quest, and if they've completed it
            bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
            bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

            // See if the player already has the quest
            if (playerAlreadyHasQuest)
            {
                // If the player has not completed the quest yet
                if (!playerAlreadyCompletedQuest)
                {
                    // See if the player has all the items needed to complete the quest
                    bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                    // The player has all items required to complete the quest
                    if (playerHasAllItemsToCompleteQuest)
                    {
                        // Display message
                        rtbMessages.AppendText(Environment.NewLine);
                        rtbMessages.AppendText("You complete the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine);

                        // Remove quest items from inventory
                        _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);

                        // Give quest rewards
                        rtbMessages.SelectionColor = Color.Gold;
                        rtbMessages.AppendText("You receive: " + Environment.NewLine);
                        rtbMessages.SelectionColor = Color.LightGreen;
                        rtbMessages.AppendText(newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine);
                        rtbMessages.SelectionColor = Color.Gold;
                        rtbMessages.AppendText(newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine);
                        rtbMessages.SelectionColor = Color.Wheat;
                        rtbMessages.AppendText(newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine);
                        rtbMessages.AppendText(Environment.NewLine);

                        _player.AddExperiencePoints(newLocation.QuestAvailableHere.RewardExperiencePoints);
                        _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                        // Add the reward item to the player's inventory
                        _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);

                        // Mark the quest as completed
                        _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        UpdateQuestLog();
                    }
                }
            }
            else
            {
                // The player does not already have the quest

                // Display the messages
                // Display the messages
                rtbMessages.AppendText("You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine);
                rtbMessages.AppendText(newLocation.QuestAvailableHere.Description + Environment.NewLine);
                rtbMessages.AppendText("To complete it, return with:" + Environment.NewLine);
                foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                {
                    if (qci.Quantity == 1)
                    {
                        rtbMessages.AppendText(qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine);
                    }
                    else
                    {
                        rtbMessages.AppendText(qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine);
                    }
                }
                rtbMessages.AppendText(Environment.NewLine);

                // Add the quest to the player's quest list
                _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                UpdateQuestLog();
            }
        }

        // Does the location have a monster?
        if (newLocation.MonsterLivingHere != null)
        {
            int locationId = newLocation.ID;

            // Initialize or reset rats count at this location
            if (!_monstersRemainingByLocation.ContainsKey(locationId))
            {
                _monstersRemainingByLocation[locationId] = 10;
            }

            if (_monstersRemainingByLocation[locationId] > 0)
            {
                int defeated = 10 - _monstersRemainingByLocation[locationId];
                lblMonstersRemaining.Text = $"{_monstersRemainingByLocation[locationId]} of 10 {newLocation.MonsterLivingHere.Name}s remaining";

                rtbMessages.AppendText($"You see a {newLocation.MonsterLivingHere.Name}" + Environment.NewLine);
                //PlaySound("monster-growl");

                // Create a new monster instance
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);
                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage,
                    standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);
                UpdateMonsterImage(_currentMonster);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = _player.Weapons.Any();
                cboPotions.Visible = _player.Potions.Any();
                btnUseWeapon.Visible = _player.Weapons.Any();
                btnUsePotion.Visible = _player.Potions.Any();
            }
            else
            {
                string defeatedMonsterName = newLocation.MonsterLivingHere.Name;

                _currentMonster = null;
                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;

                rtbMessages.AppendText("All " + defeatedMonsterName + "s are defeated." + Environment.NewLine);
                PlaySound("collapse");

            }
        }
        else
        {
            _currentMonster = null;
            cboWeapons.Visible = false;
            cboPotions.Visible = false;
            btnUseWeapon.Visible = false;
            btnUsePotion.Visible = false;
        }

        // Refresh player's stats
        UpdatePlayerStats();

        // Refresh player's inventory list

        // Refresh player's quest list

        // Refresh player's weapons combobox
        UpdateWeaponListInUI();

        // Refresh player's potions combobox
        UpdatePotionListInUI();

        ScrollToBottomOfMessages();
    }

    private void UpdatePlayerStats()
    {
        // Refresh player information and inventory controls
        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        lblGold.Text = _player.Gold.ToString();
        lblExperience.Text = _player.ExperiencePoints.ToString();
        lblLevel.Text = _player.Level.ToString();
    }


    private void UpdateWeaponListInUI()
    {
        List<Weapon> weapons = new List<Weapon>();

        foreach (InventoryItem inventoryItem in _player.Inventory)
        {
            if (inventoryItem.Details is Weapon)
            {
                if (inventoryItem.Quantity > 0)
                {
                    weapons.Add((Weapon)inventoryItem.Details);
                }
            }
        }

        if (weapons.Count == 0)
        {
            // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
            cboWeapons.Visible = false;
            btnUseWeapon.Visible = false;
        }
        else
        {
            cboWeapons.SelectedIndexChanged -= cboWeapons_SelectedIndexChanged;
            cboWeapons.DataSource = weapons;
            cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "ID";

            if (_player.CurrentWeapon != null)
            {
                cboWeapons.SelectedItem = _player.CurrentWeapon;
            }
            else
            {
                cboWeapons.SelectedIndex = 0;
            }
        }
    }

    private void UpdatePotionListInUI()
    {
        List<HealingPotion> healingPotions = new List<HealingPotion>();

        foreach (InventoryItem inventoryItem in _player.Inventory)
        {
            if (inventoryItem.Details is HealingPotion)
            {
                if (inventoryItem.Quantity > 0)
                {
                    healingPotions.Add((HealingPotion)inventoryItem.Details);
                }
            }
        }

        if (healingPotions.Count == 0)
        {
            // The player doesn't have any potions, so hide the potion combobox and "Use" button
            cboPotions.Visible = false;
            btnUsePotion.Visible = false;
        }
        else
        {
            cboPotions.DataSource = healingPotions;
            cboPotions.DisplayMember = "Name";
            cboPotions.ValueMember = "ID";

            cboPotions.SelectedIndex = 0;
        }
    }

    private async void btnUseWeapon_Click(object sender, EventArgs e)
    {
        // Get the currently selected weapon from the cboWeapons ComboBox
        Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

        // Determine the amount of damage to do to the monster
        int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

        // Apply the damage to the monster's CurrentHitPoints
        _currentMonster.CurrentHitPoints -= damageToMonster;

        string weaponName = currentWeapon.Name.ToLower();

        if (damageToMonster > 0)
        {
            rtbMessages.SelectionColor = Color.LightGreen;
            rtbMessages.AppendText("You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine);
            //PlaySound("sword-slash-02");
            PlaySound($"{weaponName}-hit");

            UpdateMonsterHPBar();
        }
        else
        {
            rtbMessages.SelectionColor = Color.LightGreen;
            rtbMessages.AppendText("You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine);
            PlaySound($"{weaponName}-miss");
            UpdateMonsterHPBar();
        }


        // Check if the monster is dead
        if (_currentMonster.CurrentHitPoints <= 0)
        {
            // Track monster kills by name
            if (_player.MonstersKilled.ContainsKey(_currentMonster.Name))
            {
                _player.MonstersKilled[_currentMonster.Name]++;
            }
            else
            {
                _player.MonstersKilled[_currentMonster.Name] = 1;
            }
            // Monster is dead
            rtbMessages.AppendText(Environment.NewLine);
            rtbMessages.SelectionColor = Color.Yellow;
            rtbMessages.AppendText("You defeated the " + _currentMonster.Name + Environment.NewLine);
            PlaySound($"{weaponName}-defeat");
            pictureBoxMonster.Image = null;

            // Give player experience points for killing the monster
            rtbMessages.SelectionColor = Color.LightGreen;
            _player.AddExperiencePoints(_currentMonster.RewardExperiencePoints);
            rtbMessages.AppendText("You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine);

            // Give player gold for killing the monster 
            rtbMessages.SelectionColor = Color.Gold;
            _player.Gold += _currentMonster.RewardGold;
            rtbMessages.AppendText("You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine);

            // Accumulate stats
            _player.TotalFightsWon++;
            _player.TotalMonstersDefeated++;

            if (_player.TotalMonstersDefeated >= 300)
            {
                rtbMessages.AppendText("You defeated the all monsters!");
                MessageBox.Show("You have defeated all monsters and brought peace to the land. You win!");
                restartBtn.Visible = true;
            }

            int goldEarned = _currentMonster.RewardGold;
            _player.Gold += goldEarned;
            _player.TotalGoldEarned += goldEarned;

            // Get random loot items from the monster
            List<InventoryItem> lootedItems = new List<InventoryItem>();

            // Add items to the lootedItems list, comparing a random number to the drop percentage
            foreach (LootItem lootItem in _currentMonster.LootTable)
            {
                if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                {
                    lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                }
            }

            // If no items were randomly selected, then add the default loot item(s).
            if (lootedItems.Count == 0)
            {
                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (lootItem.IsDefaultItem)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }
            }

            // Add the looted items to the player's inventory
            foreach (InventoryItem inventoryItem in lootedItems)
            {
                _player.AddItemToInventory(inventoryItem.Details);

                if (inventoryItem.Quantity == 1)
                {
                    rtbMessages.SelectionColor = Color.Wheat;
                    rtbMessages.AppendText("You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine);
                }
                else
                {
                    rtbMessages.SelectionColor = Color.Wheat;
                    rtbMessages.AppendText("You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine);
                }
            }
            // Decrement monster counter
            int locationId = _player.CurrentLocation.ID;
            if (_monstersRemainingByLocation.ContainsKey(locationId))
            {
                _monstersRemainingByLocation[locationId]--;
            }

            UpdatePlayerStats();
            UpdateWeaponListInUI();
            UpdatePotionListInUI();

            rtbMessages.AppendText(Environment.NewLine);

            // Move player to current location (to heal player and create a new monster to fight)
            MoveTo(_player.CurrentLocation);
        }
        else
        {
            // Monster is still alive

            // Determine the amount of damage the monster does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

            // Display message
            rtbMessages.SelectionColor = Color.IndianRed;
            rtbMessages.AppendText("The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine);

            // Subtract damage from player
            _player.CurrentHitPoints -= damageToPlayer;

            // Refresh player data in UI
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

            if (_player.CurrentHitPoints <= 0)
            {
                // Display message
                rtbMessages.AppendText("The " + _currentMonster.Name + " killed you." + Environment.NewLine);
                PlaySound("collapse");

                // Move player to "Home"
                MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            }
        }

        ScrollToBottomOfMessages();
    }

    private void btnUsePotion_Click(object sender, EventArgs e)
    {
        PlaySound("potion");
        // Get the currently selected potion from the combobox
        HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

        // Add healing amount to the player's current hit points
        _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);

        // CurrentHitPoints cannot exceed player's MaximumHitPoints
        if (_player.CurrentHitPoints > _player.MaximumHitPoints)
        {
            _player.CurrentHitPoints = _player.MaximumHitPoints;
        }

        // Remove the potion from the player's inventory
        _player.RemoveItemFromInventory(potion, 1);

        // Display message
        rtbMessages.AppendText("You drink a " + potion.Name + Environment.NewLine);

        // Monster gets their turn to attack

        // Determine the amount of damage the monster does to the player
        int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

        // Display message
        rtbMessages.SelectionColor = Color.IndianRed;
        rtbMessages.AppendText("The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine);

        // Subtract damage from player
        _player.CurrentHitPoints -= damageToPlayer;

        if (_player.CurrentHitPoints <= 0)
        {
            // Display message
            rtbMessages.AppendText("The " + _currentMonster.Name + " killed you." + Environment.NewLine);

            // Move player to "Home"
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
        }

        // Refresh player data in UI
        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        UpdatePotionListInUI();

        ScrollToBottomOfMessages();
    }
    private void UpdateQuestLog()
    {
        lstQuestLog.Items.Clear();

        foreach (PlayerQuest playerQuest in _player.Quests)
        {
            string status = playerQuest.IsCompleted ? " (Completed)" : " (In Progress)";
            lstQuestLog.Items.Add($"{playerQuest.Details.Name}{status}");
        }
    }
    private void PlayerOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
    {
        if (propertyChangedEventArgs.PropertyName == "Weapons")
        {
            cboWeapons.DataSource = _player.Weapons;
            if (!_player.Weapons.Any())
            {
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
        }
        if (propertyChangedEventArgs.PropertyName == "Potions")
        {
            cboPotions.DataSource = _player.Potions;
            if (!_player.Potions.Any())
            {
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
        }
    }
    private void ScrollToBottomOfMessages()
    {
        rtbMessages.SelectionStart = rtbMessages.Text.Length;
        rtbMessages.ScrollToCaret();
    }

    private void RPG_Project_FormClosing(object sender, FormClosingEventArgs e)
    {
        File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
    }

    private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboWeapons.SelectedItem is Weapon selectedWeapon)
        {
            _player.CurrentWeapon = selectedWeapon;

            string weaponImagePath = $"Images/{selectedWeapon.Name.ToLower()}.png";
            //pictureBoxWeapon.Image = Image.FromFile(weaponImagePath);
            btnUseWeapon.Image = Image.FromFile(weaponImagePath);
        }

    }
    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void reset_btn_Click(object sender, EventArgs e)
    {
        const string filePath = "PlayerData.xml";

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        _player = Player.CreateDefaultPlayer();
        MoveTo(_player.CurrentLocation);
        UpdatePlayerStats();
        UpdateWeaponListInUI();
        UpdatePotionListInUI();
        rtbMessages.AppendText("Player data reset to default." + Environment.NewLine);
    }

    private void btnStats_Click(object sender, EventArgs e)
    {
        StringBuilder stats = new StringBuilder();

        int totalKills = 0;

        stats.AppendLine($"Fights Won: {_player.TotalFightsWon}\n" +
                     $"Monsters Defeated: {_player.TotalMonstersDefeated}\n" +
                     $"Total Gold Earned: {_player.TotalGoldEarned}");

        foreach (var entry in _player.MonstersKilled)
        {
            stats.AppendLine($"{entry.Value} {entry.Key.ToLower()}(s) defeated");
            totalKills += entry.Value;
        }

        stats.AppendLine($"\nTotal monsters defeated: {totalKills}");

        MessageBox.Show(stats.ToString(), "Player Stats");
    }

    private void lstQuestLog_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void restartBtn_Click(object sender, EventArgs e)
    {
        RestartGame();
    }
    private void RestartGame()
    {
        const string filePath = "PlayerData.xml";

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        _player = Player.CreateDefaultPlayer();
        _player.TotalMonstersDefeated = 0;
        _player.TotalFightsWon = 0;
        _player.TotalGoldEarned = 0;
        _player.MonstersKilled.Clear();
        MoveTo(_player.CurrentLocation);
        UpdatePlayerStats();
        UpdateWeaponListInUI();
        UpdatePotionListInUI();

        rtbMessages.Clear();
        restartBtn.Visible = false;


        _monstersRemainingByLocation.Clear();

        UpdateQuestLog();


    }
    private void UpdateMonsterImage(Monster monster)
    {
        string imagePath = $"Images/{monster.Name.ToLower()}.png";
        pictureBoxMonster.Image = Image.FromFile(imagePath);
    }
    private void UpdateMonsterHPBar()
    {
        hpProgressBar.Maximum = _currentMonster.MaximumHitPoints;

        // Clamp value so it never goes below 0
        int clampedHP = Math.Max(0, _currentMonster.CurrentHitPoints);

        hpProgressBar.Value = clampedHP;
        labelMonsterHP.Text = $"HP: {clampedHP}/{_currentMonster.MaximumHitPoints}";
    }
    //PlaySound("sword");
    private void PlaySound(string filename)
    {
        var sound = new SoundPlayer($"Sounds/{filename}.wav");
        sound.Play();
    }
}

