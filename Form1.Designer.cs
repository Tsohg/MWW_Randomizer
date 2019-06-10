namespace MWW_Randomizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.randomizeButton = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.TextBox();
            this.randomSelector = new System.Windows.Forms.CheckedListBox();
            this.nullCheckBox = new System.Windows.Forms.CheckBox();
            this.restoreBinds = new System.Windows.Forms.Button();
            this.allEquipSelect = new System.Windows.Forms.CheckBox();
            this.allSelect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.restoreBackupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(12, 211);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(120, 54);
            this.randomizeButton.TabIndex = 0;
            this.randomizeButton.Text = "Randomize!";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.SystemColors.ControlText;
            this.logs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logs.Location = new System.Drawing.Point(149, 12);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(370, 193);
            this.logs.TabIndex = 3;
            this.logs.Text = " Placeholder";
            // 
            // randomSelector
            // 
            this.randomSelector.CheckOnClick = true;
            this.randomSelector.FormattingEnabled = true;
            this.randomSelector.Items.AddRange(new object[] {
            "Robe",
            "Staff",
            "Weapon",
            "Ring",
            "Trinket",
            "Magicks",
            "Imp",
            "Element Keybinds"});
            this.randomSelector.Location = new System.Drawing.Point(12, 81);
            this.randomSelector.Name = "randomSelector";
            this.randomSelector.Size = new System.Drawing.Size(120, 124);
            this.randomSelector.TabIndex = 1;
            // 
            // nullCheckBox
            // 
            this.nullCheckBox.AutoSize = true;
            this.nullCheckBox.Location = new System.Drawing.Point(7, 58);
            this.nullCheckBox.Name = "nullCheckBox";
            this.nullCheckBox.Size = new System.Drawing.Size(108, 17);
            this.nullCheckBox.TabIndex = 4;
            this.nullCheckBox.Text = "Apply Null Amulet";
            this.nullCheckBox.UseVisualStyleBackColor = true;
            // 
            // restoreBinds
            // 
            this.restoreBinds.Location = new System.Drawing.Point(149, 211);
            this.restoreBinds.Name = "restoreBinds";
            this.restoreBinds.Size = new System.Drawing.Size(120, 54);
            this.restoreBinds.TabIndex = 5;
            this.restoreBinds.Text = "Restore Keybinds";
            this.restoreBinds.UseVisualStyleBackColor = true;
            this.restoreBinds.Click += new System.EventHandler(this.restoreBinds_Click);
            // 
            // allEquipSelect
            // 
            this.allEquipSelect.AutoSize = true;
            this.allEquipSelect.Location = new System.Drawing.Point(7, 12);
            this.allEquipSelect.Name = "allEquipSelect";
            this.allEquipSelect.Size = new System.Drawing.Size(133, 17);
            this.allEquipSelect.TabIndex = 6;
            this.allEquipSelect.Text = "Select Only Equipment";
            this.allEquipSelect.UseVisualStyleBackColor = true;
            this.allEquipSelect.CheckedChanged += new System.EventHandler(this.allEquipSelect_CheckedChanged);
            // 
            // allSelect
            // 
            this.allSelect.AutoSize = true;
            this.allSelect.Location = new System.Drawing.Point(7, 35);
            this.allSelect.Name = "allSelect";
            this.allSelect.Size = new System.Drawing.Size(70, 17);
            this.allSelect.TabIndex = 7;
            this.allSelect.Text = "Select All";
            this.allSelect.UseVisualStyleBackColor = true;
            this.allSelect.CheckedChanged += new System.EventHandler(this.allSelect_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "By Alias with special thanks to Neon\r\n";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 54);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear Console";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // restoreBackupButton
            // 
            this.restoreBackupButton.Location = new System.Drawing.Point(275, 211);
            this.restoreBackupButton.Name = "restoreBackupButton";
            this.restoreBackupButton.Size = new System.Drawing.Size(120, 54);
            this.restoreBackupButton.TabIndex = 10;
            this.restoreBackupButton.Text = "Restore Backup";
            this.restoreBackupButton.UseVisualStyleBackColor = true;
            this.restoreBackupButton.Click += new System.EventHandler(this.restoreBackupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(531, 288);
            this.Controls.Add(this.restoreBackupButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allSelect);
            this.Controls.Add(this.allEquipSelect);
            this.Controls.Add(this.restoreBinds);
            this.Controls.Add(this.nullCheckBox);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.randomSelector);
            this.Controls.Add(this.randomizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magicka: Wizard Wars Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.CheckedListBox randomSelector;
        private System.Windows.Forms.CheckBox nullCheckBox;
        private System.Windows.Forms.Button restoreBinds;
        private System.Windows.Forms.CheckBox allEquipSelect;
        private System.Windows.Forms.CheckBox allSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button restoreBackupButton;
    }
}

