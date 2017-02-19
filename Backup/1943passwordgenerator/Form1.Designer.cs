namespace _943passwordgenerator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorForm));
            this.selectLevelComboBox = new System.Windows.Forms.ComboBox();
            this.passwordGeneratorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLevelLabel = new System.Windows.Forms.Label();
            this.selectDefenseComboBox = new System.Windows.Forms.ComboBox();
            this.selectOffenseComboBox = new System.Windows.Forms.ComboBox();
            this.selectDefenseLabel = new System.Windows.Forms.Label();
            this.selectOffenseLabel = new System.Windows.Forms.Label();
            this.selectPlaneEnergyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.selectSpecialWeaponStrengthComboBox = new System.Windows.Forms.ComboBox();
            this.selectSpecialWeaponTimeLimitComboBox = new System.Windows.Forms.ComboBox();
            this.selectPlaneEnergyLevelLabel = new System.Windows.Forms.Label();
            this.selectSpecialWeaponStrengthLabel = new System.Windows.Forms.Label();
            this.selectSpecialWeaponTimeLimitLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.generateCodeButton = new System.Windows.Forms.Button();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.levelGroupBox = new System.Windows.Forms.GroupBox();
            this.pointsLeftTextBox = new System.Windows.Forms.TextBox();
            this.pointsLeftLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordGeneratorMenuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.levelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectLevelComboBox
            // 
            this.selectLevelComboBox.FormattingEnabled = true;
            this.selectLevelComboBox.Location = new System.Drawing.Point(151, 19);
            this.selectLevelComboBox.Name = "selectLevelComboBox";
            this.selectLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectLevelComboBox.TabIndex = 0;
            // 
            // passwordGeneratorMenuStrip
            // 
            this.passwordGeneratorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.passwordGeneratorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.passwordGeneratorMenuStrip.Name = "passwordGeneratorMenuStrip";
            this.passwordGeneratorMenuStrip.Size = new System.Drawing.Size(440, 24);
            this.passwordGeneratorMenuStrip.TabIndex = 1;
            this.passwordGeneratorMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.generateToolStripMenuItem.Text = "&Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectLevelLabel
            // 
            this.selectLevelLabel.AutoSize = true;
            this.selectLevelLabel.Location = new System.Drawing.Point(6, 22);
            this.selectLevelLabel.Name = "selectLevelLabel";
            this.selectLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.selectLevelLabel.TabIndex = 2;
            this.selectLevelLabel.Text = "Level:";
            // 
            // selectDefenseComboBox
            // 
            this.selectDefenseComboBox.FormattingEnabled = true;
            this.selectDefenseComboBox.Location = new System.Drawing.Point(151, 23);
            this.selectDefenseComboBox.Name = "selectDefenseComboBox";
            this.selectDefenseComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectDefenseComboBox.TabIndex = 3;
            // 
            // selectOffenseComboBox
            // 
            this.selectOffenseComboBox.FormattingEnabled = true;
            this.selectOffenseComboBox.Location = new System.Drawing.Point(151, 50);
            this.selectOffenseComboBox.Name = "selectOffenseComboBox";
            this.selectOffenseComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectOffenseComboBox.TabIndex = 4;
            // 
            // selectDefenseLabel
            // 
            this.selectDefenseLabel.AutoSize = true;
            this.selectDefenseLabel.Location = new System.Drawing.Point(6, 26);
            this.selectDefenseLabel.Name = "selectDefenseLabel";
            this.selectDefenseLabel.Size = new System.Drawing.Size(50, 13);
            this.selectDefenseLabel.TabIndex = 5;
            this.selectDefenseLabel.Text = "Defense:";
            // 
            // selectOffenseLabel
            // 
            this.selectOffenseLabel.AutoSize = true;
            this.selectOffenseLabel.Location = new System.Drawing.Point(6, 53);
            this.selectOffenseLabel.Name = "selectOffenseLabel";
            this.selectOffenseLabel.Size = new System.Drawing.Size(47, 13);
            this.selectOffenseLabel.TabIndex = 6;
            this.selectOffenseLabel.Text = "Offense:";
            // 
            // selectPlaneEnergyLevelComboBox
            // 
            this.selectPlaneEnergyLevelComboBox.FormattingEnabled = true;
            this.selectPlaneEnergyLevelComboBox.Location = new System.Drawing.Point(151, 77);
            this.selectPlaneEnergyLevelComboBox.Name = "selectPlaneEnergyLevelComboBox";
            this.selectPlaneEnergyLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectPlaneEnergyLevelComboBox.TabIndex = 7;
            // 
            // selectSpecialWeaponStrengthComboBox
            // 
            this.selectSpecialWeaponStrengthComboBox.FormattingEnabled = true;
            this.selectSpecialWeaponStrengthComboBox.Location = new System.Drawing.Point(151, 104);
            this.selectSpecialWeaponStrengthComboBox.Name = "selectSpecialWeaponStrengthComboBox";
            this.selectSpecialWeaponStrengthComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectSpecialWeaponStrengthComboBox.TabIndex = 8;
            // 
            // selectSpecialWeaponTimeLimitComboBox
            // 
            this.selectSpecialWeaponTimeLimitComboBox.FormattingEnabled = true;
            this.selectSpecialWeaponTimeLimitComboBox.Location = new System.Drawing.Point(151, 131);
            this.selectSpecialWeaponTimeLimitComboBox.Name = "selectSpecialWeaponTimeLimitComboBox";
            this.selectSpecialWeaponTimeLimitComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectSpecialWeaponTimeLimitComboBox.TabIndex = 9;
            // 
            // selectPlaneEnergyLevelLabel
            // 
            this.selectPlaneEnergyLevelLabel.AutoSize = true;
            this.selectPlaneEnergyLevelLabel.Location = new System.Drawing.Point(6, 80);
            this.selectPlaneEnergyLevelLabel.Name = "selectPlaneEnergyLevelLabel";
            this.selectPlaneEnergyLevelLabel.Size = new System.Drawing.Size(102, 13);
            this.selectPlaneEnergyLevelLabel.TabIndex = 10;
            this.selectPlaneEnergyLevelLabel.Text = "Plane Energy Level:";
            // 
            // selectSpecialWeaponStrengthLabel
            // 
            this.selectSpecialWeaponStrengthLabel.AutoSize = true;
            this.selectSpecialWeaponStrengthLabel.Location = new System.Drawing.Point(6, 107);
            this.selectSpecialWeaponStrengthLabel.Name = "selectSpecialWeaponStrengthLabel";
            this.selectSpecialWeaponStrengthLabel.Size = new System.Drawing.Size(132, 13);
            this.selectSpecialWeaponStrengthLabel.TabIndex = 11;
            this.selectSpecialWeaponStrengthLabel.Text = "Special Weapon Strength:";
            // 
            // selectSpecialWeaponTimeLimitLabel
            // 
            this.selectSpecialWeaponTimeLimitLabel.AutoSize = true;
            this.selectSpecialWeaponTimeLimitLabel.Location = new System.Drawing.Point(6, 134);
            this.selectSpecialWeaponTimeLimitLabel.Name = "selectSpecialWeaponTimeLimitLabel";
            this.selectSpecialWeaponTimeLimitLabel.Size = new System.Drawing.Size(139, 13);
            this.selectSpecialWeaponTimeLimitLabel.TabIndex = 12;
            this.selectSpecialWeaponTimeLimitLabel.Text = "Special Weapon Time Limit:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Controls.Add(this.generateCodeButton);
            this.groupBox.Controls.Add(this.codeLabel);
            this.groupBox.Controls.Add(this.codeTextBox);
            this.groupBox.Controls.Add(this.selectSpecialWeaponTimeLimitLabel);
            this.groupBox.Controls.Add(this.selectSpecialWeaponStrengthLabel);
            this.groupBox.Controls.Add(this.selectDefenseComboBox);
            this.groupBox.Controls.Add(this.selectPlaneEnergyLevelLabel);
            this.groupBox.Controls.Add(this.selectOffenseComboBox);
            this.groupBox.Controls.Add(this.selectSpecialWeaponTimeLimitComboBox);
            this.groupBox.Controls.Add(this.selectDefenseLabel);
            this.groupBox.Controls.Add(this.selectSpecialWeaponStrengthComboBox);
            this.groupBox.Controls.Add(this.selectOffenseLabel);
            this.groupBox.Controls.Add(this.selectPlaneEnergyLevelComboBox);
            this.groupBox.Location = new System.Drawing.Point(12, 91);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(417, 197);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Distribute Points: (Min: 8 / Max: 29)";
            // 
            // generateCodeButton
            // 
            this.generateCodeButton.Location = new System.Drawing.Point(9, 158);
            this.generateCodeButton.Name = "generateCodeButton";
            this.generateCodeButton.Size = new System.Drawing.Size(75, 23);
            this.generateCodeButton.TabIndex = 15;
            this.generateCodeButton.Text = "&Generate";
            this.generateCodeButton.UseVisualStyleBackColor = true;
            this.generateCodeButton.Click += new System.EventHandler(this.generateCodeButton_Click);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(103, 164);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(35, 13);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(151, 161);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 13;
            // 
            // levelGroupBox
            // 
            this.levelGroupBox.Controls.Add(this.pointsLeftTextBox);
            this.levelGroupBox.Controls.Add(this.pointsLeftLabel);
            this.levelGroupBox.Controls.Add(this.selectLevelComboBox);
            this.levelGroupBox.Controls.Add(this.selectLevelLabel);
            this.levelGroupBox.Location = new System.Drawing.Point(12, 33);
            this.levelGroupBox.Name = "levelGroupBox";
            this.levelGroupBox.Size = new System.Drawing.Size(417, 52);
            this.levelGroupBox.TabIndex = 14;
            this.levelGroupBox.TabStop = false;
            // 
            // pointsLeftTextBox
            // 
            this.pointsLeftTextBox.Location = new System.Drawing.Point(367, 20);
            this.pointsLeftTextBox.Name = "pointsLeftTextBox";
            this.pointsLeftTextBox.Size = new System.Drawing.Size(44, 20);
            this.pointsLeftTextBox.TabIndex = 4;
            // 
            // pointsLeftLabel
            // 
            this.pointsLeftLabel.AutoSize = true;
            this.pointsLeftLabel.Location = new System.Drawing.Point(301, 22);
            this.pointsLeftLabel.Name = "pointsLeftLabel";
            this.pointsLeftLabel.Size = new System.Drawing.Size(60, 13);
            this.pointsLeftLabel.TabIndex = 3;
            this.pointsLeftLabel.Text = "Points Left:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordGeneratorForm
            // 
            this.AcceptButton = this.generateCodeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 299);
            this.Controls.Add(this.levelGroupBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.passwordGeneratorMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.passwordGeneratorMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordGeneratorForm";
            this.Text = "1943 Password Generator";
            this.Load += new System.EventHandler(this.PasswordGeneratorForm_Load);
            this.passwordGeneratorMenuStrip.ResumeLayout(false);
            this.passwordGeneratorMenuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.levelGroupBox.ResumeLayout(false);
            this.levelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectLevelComboBox;
        private System.Windows.Forms.MenuStrip passwordGeneratorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label selectLevelLabel;
        private System.Windows.Forms.ComboBox selectDefenseComboBox;
        private System.Windows.Forms.ComboBox selectOffenseComboBox;
        private System.Windows.Forms.Label selectDefenseLabel;
        private System.Windows.Forms.Label selectOffenseLabel;
        private System.Windows.Forms.ComboBox selectPlaneEnergyLevelComboBox;
        private System.Windows.Forms.ComboBox selectSpecialWeaponStrengthComboBox;
        private System.Windows.Forms.ComboBox selectSpecialWeaponTimeLimitComboBox;
        private System.Windows.Forms.Label selectPlaneEnergyLevelLabel;
        private System.Windows.Forms.Label selectSpecialWeaponStrengthLabel;
        private System.Windows.Forms.Label selectSpecialWeaponTimeLimitLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button generateCodeButton;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.GroupBox levelGroupBox;
        private System.Windows.Forms.TextBox pointsLeftTextBox;
        private System.Windows.Forms.Label pointsLeftLabel;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

