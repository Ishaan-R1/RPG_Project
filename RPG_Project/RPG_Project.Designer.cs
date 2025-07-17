namespace RPG_Project
{
    partial class RPG_Project
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPG_Project));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHitPoints = new Label();
            lblGold = new Label();
            lblExperience = new Label();
            label5 = new Label();
            lblLevel = new Label();
            lblAction = new Label();
            cboWeapons = new ComboBox();
            cboPotions = new ComboBox();
            btnUseWeapon = new Button();
            btnUsePotion = new Button();
            btnNorth = new Button();
            btnEast = new Button();
            btnWest = new Button();
            rtbLocation = new RichTextBox();
            rtbMessages = new RichTextBox();
            dgvQuests = new DataGridView();
            reset_btn = new Button();
            btnStats = new Button();
            lstQuestLog = new ListBox();
            restartBtn = new Button();
            btnSouth = new Button();
            pictureBoxMonster = new PictureBox();
            dgvInventory = new DataGridView();
            labelMonsterHP = new Label();
            lblMonstersRemaining = new Label();
            panelPlayerControl = new Panel();
            pictureBoxQuest1Tick = new PictureBox();
            pictureBoxQuest2Tick = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuest1Tick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuest2Tick).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(247, 226, 143);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(247, 226, 143);
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(247, 226, 143);
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(247, 226, 143);
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblHitPoints.ForeColor = Color.FromArgb(254, 242, 205);
            lblHitPoints.Location = new Point(214, 19);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 23);
            lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblGold.ForeColor = Color.FromArgb(254, 242, 205);
            lblGold.Location = new Point(214, 46);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 23);
            lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblExperience.ForeColor = Color.FromArgb(254, 242, 205);
            lblExperience.Location = new Point(214, 74);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 23);
            lblExperience.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(254, 242, 205);
            label5.Location = new Point(214, 100);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 7;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblLevel.ForeColor = Color.FromArgb(254, 242, 205);
            lblLevel.Location = new Point(214, 100);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 23);
            lblLevel.TabIndex = 8;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.FlatStyle = FlatStyle.Popup;
            lblAction.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAction.ForeColor = Color.FromArgb(247, 226, 143);
            lblAction.Location = new Point(713, 444);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(65, 22);
            lblAction.TabIndex = 9;
            lblAction.Text = "Action";
            // 
            // cboWeapons
            // 
            cboWeapons.BackColor = Color.FromArgb(45, 34, 18);
            cboWeapons.FlatStyle = FlatStyle.Flat;
            cboWeapons.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboWeapons.ForeColor = Color.FromArgb(254, 242, 205);
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(713, 468);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(202, 31);
            cboWeapons.TabIndex = 10;
            // 
            // cboPotions
            // 
            cboPotions.BackColor = Color.FromArgb(45, 34, 18);
            cboPotions.FlatStyle = FlatStyle.Flat;
            cboPotions.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPotions.ForeColor = Color.FromArgb(247, 226, 143);
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(713, 580);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(102, 31);
            cboPotions.TabIndex = 11;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.BackColor = Color.DarkRed;
            btnUseWeapon.FlatStyle = FlatStyle.Flat;
            btnUseWeapon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUseWeapon.ForeColor = Color.FromArgb(247, 226, 143);
            btnUseWeapon.Image = (Image)resources.GetObject("btnUseWeapon.Image");
            btnUseWeapon.ImageAlign = ContentAlignment.MiddleLeft;
            btnUseWeapon.Location = new Point(713, 515);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(202, 58);
            btnUseWeapon.TabIndex = 12;
            btnUseWeapon.Text = "Attack";
            btnUseWeapon.UseVisualStyleBackColor = false;
            btnUseWeapon.Click += btnUseWeapon_Click;
            // 
            // btnUsePotion
            // 
            btnUsePotion.FlatStyle = FlatStyle.Flat;
            btnUsePotion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsePotion.ForeColor = Color.FromArgb(247, 226, 143);
            btnUsePotion.Image = (Image)resources.GetObject("btnUsePotion.Image");
            btnUsePotion.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsePotion.Location = new Point(821, 579);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(94, 29);
            btnUsePotion.TabIndex = 13;
            btnUsePotion.Text = "Heal";
            btnUsePotion.UseVisualStyleBackColor = true;
            btnUsePotion.Click += btnUsePotion_Click;
            // 
            // btnNorth
            // 
            btnNorth.BackColor = Color.Black;
            btnNorth.FlatStyle = FlatStyle.Flat;
            btnNorth.ForeColor = Color.FromArgb(207, 175, 94);
            btnNorth.Image = (Image)resources.GetObject("btnNorth.Image");
            btnNorth.Location = new Point(495, 450);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(64, 64);
            btnNorth.TabIndex = 14;
            btnNorth.UseVisualStyleBackColor = false;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnEast
            // 
            btnEast.BackColor = Color.Black;
            btnEast.FlatStyle = FlatStyle.Flat;
            btnEast.ForeColor = Color.FromArgb(207, 175, 94);
            btnEast.Image = (Image)resources.GetObject("btnEast.Image");
            btnEast.Location = new Point(565, 515);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 58);
            btnEast.TabIndex = 15;
            btnEast.TextAlign = ContentAlignment.MiddleRight;
            btnEast.UseVisualStyleBackColor = false;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.BackColor = Color.Black;
            btnWest.FlatStyle = FlatStyle.Flat;
            btnWest.ForeColor = Color.FromArgb(207, 175, 94);
            btnWest.Image = (Image)resources.GetObject("btnWest.Image");
            btnWest.Location = new Point(414, 515);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 58);
            btnWest.TabIndex = 16;
            btnWest.UseVisualStyleBackColor = false;
            btnWest.Click += btnWest_Click;
            // 
            // rtbLocation
            // 
            rtbLocation.BackColor = Color.FromArgb(26, 26, 26);
            rtbLocation.BorderStyle = BorderStyle.None;
            rtbLocation.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbLocation.ForeColor = Color.FromArgb(217, 201, 163);
            rtbLocation.Location = new Point(347, 19);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 18;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.BackColor = Color.FromArgb(26, 26, 26);
            rtbMessages.BorderStyle = BorderStyle.None;
            rtbMessages.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbMessages.ForeColor = Color.FromArgb(217, 201, 163);
            rtbMessages.Location = new Point(347, 130);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(360, 286);
            rtbMessages.TabIndex = 19;
            rtbMessages.Text = "";
            // 
            // dgvQuests
            // 
            dgvQuests.AllowUserToAddRows = false;
            dgvQuests.AllowUserToDeleteRows = false;
            dgvQuests.BackgroundColor = Color.FromArgb(26, 26, 26);
            dgvQuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(247, 226, 143);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(254, 242, 205);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.EnableHeadersVisualStyles = false;
            dgvQuests.GridColor = Color.DimGray;
            dgvQuests.Location = new Point(18, 430);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.RowHeadersWidth = 51;
            dgvQuests.ScrollBars = ScrollBars.Vertical;
            dgvQuests.Size = new Size(312, 107);
            dgvQuests.TabIndex = 21;
            // 
            // reset_btn
            // 
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.ForeColor = Color.FromArgb(247, 226, 143);
            reset_btn.Location = new Point(916, 664);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(94, 29);
            reset_btn.TabIndex = 22;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // btnStats
            // 
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.ForeColor = Color.FromArgb(247, 226, 143);
            btnStats.Location = new Point(414, 664);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(226, 29);
            btnStats.TabIndex = 23;
            btnStats.Text = "View Stats";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // lstQuestLog
            // 
            lstQuestLog.BackColor = Color.FromArgb(26, 26, 26);
            lstQuestLog.BorderStyle = BorderStyle.None;
            lstQuestLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstQuestLog.ForeColor = Color.FromArgb(254, 242, 205);
            lstQuestLog.FormattingEnabled = true;
            lstQuestLog.ItemHeight = 23;
            lstQuestLog.Location = new Point(713, 20);
            lstQuestLog.Name = "lstQuestLog";
            lstQuestLog.Size = new Size(300, 92);
            lstQuestLog.TabIndex = 24;
            // 
            // restartBtn
            // 
            restartBtn.FlatStyle = FlatStyle.Flat;
            restartBtn.ForeColor = Color.FromArgb(247, 226, 143);
            restartBtn.Location = new Point(806, 664);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(94, 29);
            restartBtn.TabIndex = 25;
            restartBtn.Text = "Restart";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += restartBtn_Click;
            // 
            // btnSouth
            // 
            btnSouth.BackColor = Color.Black;
            btnSouth.FlatStyle = FlatStyle.Flat;
            btnSouth.ForeColor = Color.FromArgb(207, 175, 94);
            btnSouth.Image = (Image)resources.GetObject("btnSouth.Image");
            btnSouth.Location = new Point(495, 581);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(64, 64);
            btnSouth.TabIndex = 17;
            btnSouth.UseVisualStyleBackColor = false;
            btnSouth.Click += btnSouth_Click;
            // 
            // pictureBoxMonster
            // 
            pictureBoxMonster.Image = (Image)resources.GetObject("pictureBoxMonster.Image");
            pictureBoxMonster.Location = new Point(713, 130);
            pictureBoxMonster.Name = "pictureBoxMonster";
            pictureBoxMonster.Size = new Size(300, 286);
            pictureBoxMonster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMonster.TabIndex = 26;
            pictureBoxMonster.TabStop = false;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = Color.FromArgb(26, 26, 26);
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(247, 226, 143);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Padding = new Padding(5, 2, 5, 2);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(254, 242, 205);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle4;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.DimGray;
            dgvInventory.Location = new Point(16, 130);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(254, 242, 205);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.ScrollBars = ScrollBars.Vertical;
            dgvInventory.Size = new Size(312, 286);
            dgvInventory.TabIndex = 20;
            // 
            // labelMonsterHP
            // 
            labelMonsterHP.AutoSize = true;
            labelMonsterHP.Location = new Point(953, 393);
            labelMonsterHP.Name = "labelMonsterHP";
            labelMonsterHP.Size = new Size(57, 20);
            labelMonsterHP.TabIndex = 28;
            labelMonsterHP.Text = "HP: 0/3";
            // 
            // lblMonstersRemaining
            // 
            lblMonstersRemaining.AutoSize = true;
            lblMonstersRemaining.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonstersRemaining.ForeColor = Color.FromArgb(254, 242, 205);
            lblMonstersRemaining.Location = new Point(765, 411);
            lblMonstersRemaining.Name = "lblMonstersRemaining";
            lblMonstersRemaining.Size = new Size(196, 25);
            lblMonstersRemaining.TabIndex = 29;
            lblMonstersRemaining.Text = "1 of 10 Rats Remaining";
            // 
            // panelPlayerControl
            // 
            panelPlayerControl.Location = new Point(702, 459);
            panelPlayerControl.Name = "panelPlayerControl";
            panelPlayerControl.Padding = new Padding(30);
            panelPlayerControl.Size = new Size(222, 165);
            panelPlayerControl.TabIndex = 30;
            panelPlayerControl.Paint += panelPlayerControl_Paint;
            // 
            // pictureBoxQuest1Tick
            // 
            pictureBoxQuest1Tick.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxQuest1Tick.Location = new Point(261, 454);
            pictureBoxQuest1Tick.Name = "pictureBoxQuest1Tick";
            pictureBoxQuest1Tick.Size = new Size(27, 28);
            pictureBoxQuest1Tick.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQuest1Tick.TabIndex = 31;
            pictureBoxQuest1Tick.TabStop = false;
            // 
            // pictureBoxQuest2Tick
            // 
            pictureBoxQuest2Tick.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxQuest2Tick.Location = new Point(261, 488);
            pictureBoxQuest2Tick.Name = "pictureBoxQuest2Tick";
            pictureBoxQuest2Tick.Size = new Size(27, 28);
            pictureBoxQuest2Tick.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQuest2Tick.TabIndex = 32;
            pictureBoxQuest2Tick.TabStop = false;
            // 
            // RPG_Project
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 37, 37);
            ClientSize = new Size(1025, 705);
            Controls.Add(pictureBoxQuest2Tick);
            Controls.Add(pictureBoxQuest1Tick);
            Controls.Add(lblMonstersRemaining);
            Controls.Add(labelMonsterHP);
            Controls.Add(dgvInventory);
            Controls.Add(pictureBoxMonster);
            Controls.Add(restartBtn);
            Controls.Add(lstQuestLog);
            Controls.Add(btnStats);
            Controls.Add(reset_btn);
            Controls.Add(dgvQuests);
            Controls.Add(rtbMessages);
            Controls.Add(rtbLocation);
            Controls.Add(btnSouth);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            Controls.Add(btnNorth);
            Controls.Add(btnUsePotion);
            Controls.Add(btnUseWeapon);
            Controls.Add(cboPotions);
            Controls.Add(cboWeapons);
            Controls.Add(lblAction);
            Controls.Add(lblLevel);
            Controls.Add(label5);
            Controls.Add(lblExperience);
            Controls.Add(lblGold);
            Controls.Add(lblHitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPlayerControl);
            ForeColor = SystemColors.ControlLight;
            Name = "RPG_Project";
            Text = "Game";
            FormClosing += RPG_Project_FormClosing;
            Load += RPG_Project_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuest1Tick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuest2Tick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHitPoints;
        private Label lblGold;
        private Label lblExperience;
        private Label label5;
        private Label lblLevel;
        private Label lblAction;
        private ComboBox cboWeapons;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button btnEast;
        private Button btnWest;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        private DataGridView dgvQuests;
        private Button reset_btn;
        private Button btnStats;
        private ListBox lstQuestLog;
        private Button restartBtn;
        private Button btnSouth;
        private PictureBox pictureBoxMonster;
        private DataGridView dgvInventory;
        private Label labelMonsterHP;
        private Label lblMonstersRemaining;
        private Panel panelPlayerControl;
        private PictureBox pictureBoxQuest1Tick;
        private PictureBox pictureBoxQuest2Tick;
    }
}
