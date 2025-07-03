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
            btnSouth = new Button();
            rtbLocation = new RichTextBox();
            rtbMessages = new RichTextBox();
            dgvInventory = new DataGridView();
            dgvQuests = new DataGridView();
            reset_btn = new Button();
            btnStats = new Button();
            lstQuestLog = new ListBox();
            restartBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Location = new Point(110, 19);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 20);
            lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(110, 46);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 20);
            lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(110, 74);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 20);
            lblExperience.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 100);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(110, 100);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 20);
            lblLevel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(617, 531);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 9;
            label6.Text = "Select action";
            // 
            // cboWeapons
            // 
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(369, 559);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(151, 28);
            cboWeapons.TabIndex = 10;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(369, 593);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(151, 28);
            cboPotions.TabIndex = 11;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.Location = new Point(620, 559);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(94, 29);
            btnUseWeapon.TabIndex = 12;
            btnUseWeapon.Text = "Use";
            btnUseWeapon.UseVisualStyleBackColor = true;
            btnUseWeapon.Click += btnUseWeapon_Click;
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(620, 594);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(94, 29);
            btnUsePotion.TabIndex = 13;
            btnUsePotion.Text = "Use";
            btnUsePotion.UseVisualStyleBackColor = true;
            btnUsePotion.Click += btnUsePotion_Click;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(493, 433);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(94, 29);
            btnNorth.TabIndex = 14;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(573, 457);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(94, 29);
            btnEast.TabIndex = 15;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(412, 457);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(94, 29);
            btnWest.TabIndex = 16;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(493, 487);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(94, 29);
            btnSouth.TabIndex = 17;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // rtbLocation
            // 
            rtbLocation.Location = new Point(347, 19);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 18;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(347, 130);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(360, 286);
            rtbMessages.TabIndex = 19;
            rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.Location = new Point(16, 130);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(312, 309);
            dgvInventory.TabIndex = 20;
            // 
            // dgvQuests
            // 
            dgvQuests.AllowUserToAddRows = false;
            dgvQuests.AllowUserToDeleteRows = false;
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.Location = new Point(16, 446);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.RowHeadersWidth = 51;
            dgvQuests.Size = new Size(312, 189);
            dgvQuests.TabIndex = 21;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(919, 592);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(94, 29);
            reset_btn.TabIndex = 22;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(234, 19);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(94, 29);
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
            restartBtn.Location = new Point(714, 173);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(94, 29);
            restartBtn.TabIndex = 25;
            restartBtn.Text = "Restart";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += restartBtn_Click;
            // 
            // RPG_Project
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 643);
            Controls.Add(restartBtn);
            Controls.Add(lstQuestLog);
            Controls.Add(btnStats);
            Controls.Add(reset_btn);
            Controls.Add(dgvQuests);
            Controls.Add(dgvInventory);
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
            Name = "RPG_Project";
            Text = "Game";
            FormClosing += RPG_Project_FormClosing;
            Load += RPG_Project_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
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
        private Button btnSouth;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        private DataGridView dgvInventory;
        private DataGridView dgvQuests;
        private Button reset_btn;
        private Button btnStats;
        private ListBox lstQuestLog;
        private Button restartBtn;
    }
}
