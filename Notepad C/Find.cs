using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_C
{
    public partial class Find : Form
    {
        RichTextBox richTextBox;

        public Find(RichTextBox richTextBox1)
        {
            InitializeComponent();
            richTextBox = richTextBox1;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            Common.oldText = txtFind.Text;
            if (Common.oldText.Length > 0)
            {
                int startPosition = 0;

                int richTextBoxSearchOptions = 0;

                if (chkMatchCase.Checked == true)
                {
                    richTextBoxSearchOptions = richTextBoxSearchOptions + (int)RichTextBoxFinds.MatchCase;
                }
                
                if (rbUp.Checked == true)
                {
                    richTextBoxSearchOptions = richTextBoxSearchOptions + (int)RichTextBoxFinds.Reverse;
                }
                
                startPosition = richTextBox.Find(Common.oldText, (RichTextBoxFinds)richTextBoxSearchOptions);
                // startPosition = richTextBox.Find(Common.oldText);
                
                if (startPosition == -1)
                {
                    MessageBox.Show($"Cannot find \"{Common.oldText}\"", "Notepad C", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    richTextBox.Select(startPosition, Common.oldText.Length);
                    richTextBox.SelectionBackColor = Color.FromArgb(0,120,215);
                    richTextBox.SelectionColor = Color.FromArgb(255, 255, 255);
                }
                //Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
