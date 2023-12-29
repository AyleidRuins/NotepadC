
namespace Notepad_C
{
    partial class Preferences
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForegroundColour = new System.Windows.Forms.Button();
            this.btnBackgroundColour = new System.Windows.Forms.Button();
            this.cboDefaultFileType = new System.Windows.Forms.ComboBox();
            this.labDefaultFileType = new System.Windows.Forms.Label();
            this.grpColourTheme = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbDarkMode = new System.Windows.Forms.RadioButton();
            this.rbLightMode = new System.Windows.Forms.RadioButton();
            this.grpColourTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foreground colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Background colour:";
            // 
            // btnForegroundColour
            // 
            this.btnForegroundColour.Location = new System.Drawing.Point(135, 86);
            this.btnForegroundColour.Name = "btnForegroundColour";
            this.btnForegroundColour.Size = new System.Drawing.Size(20, 23);
            this.btnForegroundColour.TabIndex = 2;
            this.btnForegroundColour.UseVisualStyleBackColor = true;
            this.btnForegroundColour.Click += new System.EventHandler(this.btnForegroundColour_Click);
            // 
            // btnBackgroundColour
            // 
            this.btnBackgroundColour.Location = new System.Drawing.Point(135, 115);
            this.btnBackgroundColour.Name = "btnBackgroundColour";
            this.btnBackgroundColour.Size = new System.Drawing.Size(21, 23);
            this.btnBackgroundColour.TabIndex = 3;
            this.btnBackgroundColour.UseVisualStyleBackColor = true;
            this.btnBackgroundColour.Click += new System.EventHandler(this.btnBackgroundColour_Click);
            // 
            // cboDefaultFileType
            // 
            this.cboDefaultFileType.FormattingEnabled = true;
            this.cboDefaultFileType.Items.AddRange(new object[] {
            "Text files (*.txt)",
            "RichText files (*.rtf)",
            "MD Markdown files (*.md)"});
            this.cboDefaultFileType.Location = new System.Drawing.Point(94, 10);
            this.cboDefaultFileType.Name = "cboDefaultFileType";
            this.cboDefaultFileType.Size = new System.Drawing.Size(121, 21);
            this.cboDefaultFileType.TabIndex = 4;
            this.cboDefaultFileType.Text = "Text files (*.txt)";
            // 
            // labDefaultFileType
            // 
            this.labDefaultFileType.AutoSize = true;
            this.labDefaultFileType.Location = new System.Drawing.Point(8, 13);
            this.labDefaultFileType.Name = "labDefaultFileType";
            this.labDefaultFileType.Size = new System.Drawing.Size(83, 13);
            this.labDefaultFileType.TabIndex = 5;
            this.labDefaultFileType.Text = "Default file type:";
            // 
            // grpColourTheme
            // 
            this.grpColourTheme.Controls.Add(this.rbCustom);
            this.grpColourTheme.Controls.Add(this.rbDarkMode);
            this.grpColourTheme.Controls.Add(this.rbLightMode);
            this.grpColourTheme.Controls.Add(this.btnBackgroundColour);
            this.grpColourTheme.Controls.Add(this.label1);
            this.grpColourTheme.Controls.Add(this.btnForegroundColour);
            this.grpColourTheme.Controls.Add(this.label2);
            this.grpColourTheme.Location = new System.Drawing.Point(12, 65);
            this.grpColourTheme.Name = "grpColourTheme";
            this.grpColourTheme.Size = new System.Drawing.Size(166, 149);
            this.grpColourTheme.TabIndex = 6;
            this.grpColourTheme.TabStop = false;
            this.grpColourTheme.Text = "Colour theme";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(3, 62);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(100, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = "Custom colours:";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbDarkMode
            // 
            this.rbDarkMode.AutoSize = true;
            this.rbDarkMode.Location = new System.Drawing.Point(3, 39);
            this.rbDarkMode.Name = "rbDarkMode";
            this.rbDarkMode.Size = new System.Drawing.Size(77, 17);
            this.rbDarkMode.TabIndex = 1;
            this.rbDarkMode.Text = "Dark mode";
            this.rbDarkMode.UseVisualStyleBackColor = true;
            this.rbDarkMode.CheckedChanged += new System.EventHandler(this.rbDarkMode_CheckedChanged);
            // 
            // rbLightMode
            // 
            this.rbLightMode.AutoSize = true;
            this.rbLightMode.Location = new System.Drawing.Point(3, 16);
            this.rbLightMode.Name = "rbLightMode";
            this.rbLightMode.Size = new System.Drawing.Size(77, 17);
            this.rbLightMode.TabIndex = 0;
            this.rbLightMode.Text = "Light mode";
            this.rbLightMode.UseVisualStyleBackColor = true;
            this.rbLightMode.CheckedChanged += new System.EventHandler(this.rbLightMode_CheckedChanged);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.grpColourTheme);
            this.Controls.Add(this.labDefaultFileType);
            this.Controls.Add(this.cboDefaultFileType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.grpColourTheme.ResumeLayout(false);
            this.grpColourTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForegroundColour;
        private System.Windows.Forms.Button btnBackgroundColour;
        private System.Windows.Forms.ComboBox cboDefaultFileType;
        private System.Windows.Forms.Label labDefaultFileType;
        private System.Windows.Forms.GroupBox grpColourTheme;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbDarkMode;
        private System.Windows.Forms.RadioButton rbLightMode;
    }
}