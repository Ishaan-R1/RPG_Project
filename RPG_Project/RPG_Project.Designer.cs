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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHitPoints = new Label();
            lblGold = new Label();
            lblExperience = new Label();
            label5 = new Label();
            lblLevel = new Label();
            label6 = new Label();
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
            hpProgressBar = new ProgressBar();
            dgvInventory = new DataGridView();
            labelMonsterHP = new Label();
            lblMonstersRemaining = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
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
            label2.ForeColor = Color.WhiteSmoke;
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
            label3.ForeColor = Color.WhiteSmoke;
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
            label4.ForeColor = Color.WhiteSmoke;
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
            lblHitPoints.ForeColor = Color.WhiteSmoke;
            lblHitPoints.Location = new Point(110, 19);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 23);
            lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblGold.ForeColor = Color.WhiteSmoke;
            lblGold.Location = new Point(110, 46);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 23);
            lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblExperience.ForeColor = Color.WhiteSmoke;
            lblExperience.Location = new Point(110, 74);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 23);
            lblExperience.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(110, 100);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 7;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblLevel.ForeColor = Color.WhiteSmoke;
            lblLevel.Location = new Point(110, 100);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 23);
            lblLevel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(598, 442);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 9;
            label6.Text = "Select action";
            // 
            // cboWeapons
            // 
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(643, 507);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(202, 28);
            cboWeapons.TabIndex = 10;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(643, 619);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(102, 28);
            cboPotions.TabIndex = 11;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.BackColor = Color.DarkRed;
            btnUseWeapon.FlatStyle = FlatStyle.Flat;
            btnUseWeapon.ForeColor = Color.White;
            btnUseWeapon.Location = new Point(643, 554);
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
            btnUsePotion.ForeColor = Color.White;
            btnUsePotion.Location = new Point(751, 618);
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
            btnNorth.FlatStyle = FlatStyle.Popup;
            btnNorth.Image = (Image)resources.GetObject("btnNorth.Image");
            btnNorth.Location = new Point(457, 488);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(64, 64);
            btnNorth.TabIndex = 14;
            btnNorth.UseVisualStyleBackColor = false;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnEast
            // 
            btnEast.BackColor = Color.Black;
            btnEast.FlatStyle = FlatStyle.Popup;
            btnEast.Image = (Image)resources.GetObject("btnEast.Image");
            btnEast.Location = new Point(527, 554);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 64);
            btnEast.TabIndex = 15;
            btnEast.TextAlign = ContentAlignment.MiddleRight;
            btnEast.UseVisualStyleBackColor = false;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.BackColor = Color.Black;
            btnWest.FlatStyle = FlatStyle.Popup;
            btnWest.Image = (Image)resources.GetObject("btnWest.Image");
            btnWest.Location = new Point(376, 554);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 64);
            btnWest.TabIndex = 16;
            btnWest.UseVisualStyleBackColor = false;
            btnWest.Click += btnWest_Click;
            // 
            // rtbLocation
            // 
            rtbLocation.BackColor = Color.FromArgb(220, 200, 162);
            rtbLocation.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbLocation.Location = new Point(347, 19);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 18;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.BackColor = Color.FromArgb(18, 18, 18);
            rtbMessages.BorderStyle = BorderStyle.None;
            rtbMessages.ForeColor = Color.White;
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
            dgvQuests.BackgroundColor = Color.FromArgb(50, 50, 70);
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.GridColor = Color.DimGray;
            dgvQuests.Location = new Point(16, 457);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.RowHeadersWidth = 51;
            dgvQuests.Size = new Size(312, 261);
            dgvQuests.TabIndex = 21;
            // 
            // reset_btn
            // 
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Location = new Point(916, 689);
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
            btnStats.ForeColor = Color.White;
            btnStats.Location = new Point(376, 689);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(226, 29);
            btnStats.TabIndex = 23;
            btnStats.Text = "View Stats";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // lstQuestLog
            // 
            lstQuestLog.FormattingEnabled = true;
            lstQuestLog.Location = new Point(713, 19);
            lstQuestLog.Name = "lstQuestLog";
            lstQuestLog.Size = new Size(300, 104);
            lstQuestLog.TabIndex = 24;
            // 
            // restartBtn
            // 
            restartBtn.FlatStyle = FlatStyle.Flat;
            restartBtn.ForeColor = Color.White;
            restartBtn.Location = new Point(806, 689);
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
            btnSouth.FlatStyle = FlatStyle.Popup;
            btnSouth.Image = (Image)resources.GetObject("btnSouth.Image");
            btnSouth.Location = new Point(457, 619);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(64, 64);
            btnSouth.TabIndex = 17;
            btnSouth.UseVisualStyleBackColor = false;
            btnSouth.Click += btnSouth_Click;
            // 
            // pictureBoxMonster
            // 
            pictureBoxMonster.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMonster.Image = (Image)resources.GetObject("pictureBoxMonster.Image");
            pictureBoxMonster.Location = new Point(713, 130);
            pictureBoxMonster.Name = "pictureBoxMonster";
            pictureBoxMonster.Size = new Size(300, 286);
            pictureBoxMonster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMonster.TabIndex = 26;
            pictureBoxMonster.TabStop = false;
            // 
            // hpProgressBar
            // 
            hpProgressBar.ForeColor = Color.Red;
            hpProgressBar.Location = new Point(753, 442);
            hpProgressBar.Name = "hpProgressBar";
            hpProgressBar.Size = new Size(147, 29);
            hpProgressBar.TabIndex = 27;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = Color.FromArgb(50, 50, 70);
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 47, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.GridColor = Color.DimGray;
            dgvInventory.Location = new Point(16, 130);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(312, 309);
            dgvInventory.TabIndex = 20;
            // 
            // labelMonsterHP
            // 
            labelMonsterHP.AutoSize = true;
            labelMonsterHP.Location = new Point(906, 444);
            labelMonsterHP.Name = "labelMonsterHP";
            labelMonsterHP.Size = new Size(57, 20);
            labelMonsterHP.TabIndex = 28;
            labelMonsterHP.Text = "HP: 0/3";
            // 
            // lblMonstersRemaining
            // 
            lblMonstersRemaining.AutoSize = true;
            lblMonstersRemaining.Location = new Point(788, 419);
            lblMonstersRemaining.Name = "lblMonstersRemaining";
            lblMonstersRemaining.Size = new Size(162, 20);
            lblMonstersRemaining.TabIndex = 29;
            lblMonstersRemaining.Text = "1 of 10 Rats Remaining";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkRed;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(645, 563);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // RPG_Project
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 32, 52);
            ClientSize = new Size(1025, 743);
            Controls.Add(pictureBox1);
            Controls.Add(lblMonstersRemaining);
            Controls.Add(labelMonsterHP);
            Controls.Add(dgvInventory);
            Controls.Add(hpProgressBar);
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
            Controls.Add(label6);
            Controls.Add(lblLevel);
            Controls.Add(label5);
            Controls.Add(lblExperience);
            Controls.Add(lblGold);
            Controls.Add(lblHitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "RPG_Project";
            Text = "Game";
            FormClosing += RPG_Project_FormClosing;
            Load += RPG_Project_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label6;
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
        private ProgressBar hpProgressBar;
        private DataGridView dgvInventory;
        private Label labelMonsterHP;
        private Label lblMonstersRemaining;
        private PictureBox pictureBox1;
    }
}
