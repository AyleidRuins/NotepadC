
namespace Notepad_C
{
    partial class Find
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.chkWrapAround = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.labFindWhat = new System.Windows.Forms.Label();
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.grpDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 37);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(273, 8);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(71, 11);
            this.txtFind.MaxLength = 256;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(171, 20);
            this.txtFind.TabIndex = 0;
            // 
            // chkWrapAround
            // 
            this.chkWrapAround.AutoSize = true;
            this.chkWrapAround.Location = new System.Drawing.Point(6, 94);
            this.chkWrapAround.Name = "chkWrapAround";
            this.chkWrapAround.Size = new System.Drawing.Size(88, 17);
            this.chkWrapAround.TabIndex = 2;
            this.chkWrapAround.Text = "W&rap around";
            this.chkWrapAround.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(6, 68);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chkMatchCase.TabIndex = 1;
            this.chkMatchCase.Text = "Match &case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // labFindWhat
            // 
            this.labFindWhat.AutoSize = true;
            this.labFindWhat.Location = new System.Drawing.Point(6, 13);
            this.labFindWhat.Name = "labFindWhat";
            this.labFindWhat.Size = new System.Drawing.Size(56, 13);
            this.labFindWhat.TabIndex = 9;
            this.labFindWhat.Text = "Fi&nd what:";
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.rbDown);
            this.grpDirection.Controls.Add(this.rbUp);
            this.grpDirection.Location = new System.Drawing.Point(161, 42);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(102, 46);
            this.grpDirection.TabIndex = 3;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Direction";
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(7, 20);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(39, 17);
            this.rbUp.TabIndex = 0;
            this.rbUp.Text = "&Up";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Checked = true;
            this.rbDown.Location = new System.Drawing.Point(46, 20);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(53, 17);
            this.rbDown.TabIndex = 0;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "&Down";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 120);
            this.Controls.Add(this.grpDirection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.chkWrapAround);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.labFindWhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Find";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Find";
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox chkWrapAround;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Label labFindWhat;
        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
    }
}