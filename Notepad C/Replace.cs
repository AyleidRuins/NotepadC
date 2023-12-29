using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_C
{
    public partial class Replace : Form
    {
        RichTextBox richTextBox;

        public Replace(RichTextBox richTextBox1)
        {
            InitializeComponent();
            richTextBox = richTextBox1;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            Common.oldText = txtFind.Text;
            if (Common.oldText.Length>0)
            {
                int startPosition = richTextBox.Find(Common.oldText);
                richTextBox.Select(startPosition, Common.oldText.Length);
                richTextBox.SelectionBackColor = Color.FromArgb(0, 120, 215);
                richTextBox.SelectionColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Common.oldText = txtFind.Text;
            Common.newText = txtReplace.Text;
            if (Common.oldText.Length > 0 && Common.newText.Length > 0)
            {
                ReplaceText(richTextBox, Common.oldText, Common.newText);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public void ReplaceText(RichTextBox rtb, string search, string replace)
        {
            int start = 0;
            int end = rtb.Text.LastIndexOf(search);
            rtb.Select(start, end);
            while (start < end)
            {
                rtb.Find(search, start, rtb.TextLength, RichTextBoxFinds.None);
                rtb.SelectedText = replace;
                start = rtb.SelectionStart + replace.Length;
            }
        }

    }
}