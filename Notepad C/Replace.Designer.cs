
namespace Notepad_C
{
    partial class Replace
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
            this.labFindWhat = new System.Windows.Forms.Label();
            this.labReplaceWith = new System.Windows.Forms.Label();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWrapAround = new System.Windows.Forms.CheckBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFindWhat
            // 
            this.labFindWhat.AutoSize = true;
            this.labFindWhat.Location = new System.Drawing.Point(6, 15);
            this.labFindWhat.Name = "labFindWhat";
            this.labFindWhat.Size = new System.Drawing.Size(56, 13);
            this.labFindWhat.TabIndex = 0;
            this.labFindWhat.Text = "Fi&nd what:";
            // 
            // labReplaceWith
            // 
            this.labReplaceWith.AutoSize = true;
            this.labReplaceWith.Location = new System.Drawing.Point(6, 42);
            this.labReplaceWith.Name = "labReplaceWith";
            this.labReplaceWith.Size = new System.Drawing.Size(72, 13);
            this.labReplaceWith.TabIndex = 1;
            this.labReplaceWith.Text = "Re&place with:";
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(6, 101);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chkMatchCase.TabIndex = 2;
            this.chkMatchCase.Text = "Match &case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWrapAround
            // 
            this.chkWrapAround.AutoSize = true;
            this.chkWrapAround.Location = new System.Drawing.Point(6, 127);
            this.chkWrapAround.Name = "chkWrapAround";
            this.chkWrapAround.Size = new System.Drawing.Size(88, 17);
            this.chkWrapAround.TabIndex = 3;
            this.chkWrapAround.Text = "W&rap around";
            this.chkWrapAround.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(81, 11);
            this.txtFind.MaxLength = 256;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(171, 20);
            this.txtFind.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(81, 39);
            this.txtReplace.MaxLength = 256;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(171, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(261, 7);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(261, 34);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(261, 62);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "Replace &All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Replace
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 153);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.chkWrapAround);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.labReplaceWith);
            this.Controls.Add(this.labFindWhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Replace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFindWhat;
        private System.Windows.Forms.Label labReplaceWith;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWrapAround;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
    }
}