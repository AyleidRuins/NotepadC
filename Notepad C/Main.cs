using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Notepad_C
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        public Main(string[] args)
        {
            InitializeComponent();

            if (args.Length>1 && args[1] != "")
            {
                OpenFileFromExtension(args[1]);
            }
        }

        private void OpenFileFromExtension(string filePath)
        {
            string ext = Path.GetExtension(filePath);
            char ch = '.';
            int freq = ext.Where(x => (x == ch)).Count();
            if (freq > 1)
            {
                MessageBox.Show("This file has a double extension and can't be opened in this editor.");
                Close();
                return;
            }

            ext = ext.Replace(".", "");

            switch (ext)
            {
                case "txt":
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    Common.currentFileType = "txt";
                    break;
                case "rtf":
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    Common.currentFileType = "rtf";
                    break;
                case "md":
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.UnicodePlainText);
                    Common.currentFileType = "md";
                    break;
                default:
                    MessageBox.Show("Unsupported filetype. Closing the editor");
                    this.Close();
                    break;
            }

            Common.currentFileName = Path.GetFileName(filePath);
            Common.currentFolder = Path.GetDirectoryName(filePath);
            //Common.changeMade = false; // not sure if this is needed
            Text = $"{Common.currentFileName} - Notepad C"; // indicate user has changed the text and that a Save is needed.
            toolStripStatusLabel1.Text = Common.currentFileType;
        }

        #region File menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.fileSaved = true;
            richTextBox1.Clear();
            richTextBox1.SelectionTabs = new int[] { 400, 800, 1200, 1600 };
            //txtRichTextBox1RTFcode.Text = string.Empty;

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common.fileSaved == false) // Has the file been saved (do we have a filename that the user has chosen?)
            {
                SaveAs();
            }
            else // Yes, so just overwrite previous version.
            {
                Save();
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }


        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Print Preview (with option to print)
            printPreviewDialog1.Document = printDocument1;
            DialogResult printPreviewResult = printPreviewDialog1.ShowDialog();
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Full print dialog
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Header
            e.Graphics.DrawString(richTextBox1.Text, fontDialog1.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(e.MarginBounds.Left, e.MarginBounds.Top), new Point(e.MarginBounds.Right, e.MarginBounds.Top));

            // Main text
            e.Graphics.DrawString(richTextBox1.Text, fontDialog1.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to quit?", "Notepad C", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion


        #region Edit menu
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (richTextBox1.SelectionLength > 0) richTextBox1.Undo();

            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo(); // only 1 level of undo (like Notepad? No thanks! Comment this line out if so).
            }

        }


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0) richTextBox1.Cut();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0) richTextBox1.Copy();
        }


        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (richTextBox1.SelectionLength > 0) richTextBox1.Paste(); // This only pastes from within the Richtextbox itself, not from external sources!

            //Debug.Print("");
            richTextBox1.Paste(); // Paste regardless or the source
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0) richTextBox1.DeselectAll(); // Delete selected text.
        }



        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find findForm = new Find(richTextBox1);
            findForm.Show();
            //richTextBox1.Refresh();
        }


        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace replaceForm = new Replace(richTextBox1);
            replaceForm.Show();
            //richTextBox1.Refresh();

        }


        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll(); // Ctrl A keyboard shortcut is processed here, not in KeyDown event. This is because the shortcut key is defined in the menu.
        }


        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instead of going in the KeyDown event F5 is here, and does not appear in KeyDown event code.
            // This is because the shortcut key for F5 is assigned to this menu 'timedate' menu method.
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }


        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.ShowDialog();
            richTextBox1.BackColor = Common.BackgroundColour;
            richTextBox1.ForeColor = Common.ForegroundColour;
            richTextBox1.Refresh();
        }
        #endregion

        private void SaveAs()
        {
            saveFileDialog1.FileName = Common.currentFileName;
            Debug.Print($"{Common.currentFileType}");

            if (Common.currentFileType == "rtf")
            {
                saveFileDialog1.FilterIndex = 2;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1: // *.txt
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            break;
                        case 2: // *.rtf
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                            break;
                        case 3: // *.md
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                            break;
                        case 4: // *.*
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            break;

                        default:
                            break;
                    }
                    Common.currentFileName = saveFileDialog1.FileName;
                    Text = $"{Common.currentFileName} - Notepad C"; // Update window title to reflect new filename and remove asterisk as user has only just saved the file.
                    //txtRichTextBox1RTFcode.Text = richTextBox1.Rtf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was a problem attempting to save the file.\nError was:{ex.Message}", "Notepad C - Error");
                }

                Common.fileSaved = true;
            }
        }

        private void Save()
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName);
            //Common.changeMade = false;

        }

        private void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (openFileDialog1.FilterIndex)
                    {
                        case 1: // *.txt
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            Common.currentFileType = "txt";
                            break;
                        case 2: // *.rtf
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                            Common.currentFileType = "rtf";
                            break;
                        case 3: // *.md
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                            Common.currentFileType = "md";
                            break;
                        case 4: // *.*
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            Common.currentFileType = "all";
                            break;

                        default:
                            break;
                    }
                    Common.currentFileName = Path.GetFileName(openFileDialog1.FileName);
                    Common.currentFolder = Path.GetDirectoryName(openFileDialog1.FileName);
                    Common.changeMade = false; // not sure if this is needed
                    Text = $"{Common.currentFileName} - Notepad C"; // indicate user has changed the text and that a Save is needed.
                    toolStripStatusLabel1.Text = Common.currentFileType;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was a problem attempting to open the file.\nError was:{ex.Message}", "Notepad C - Error");
                }
            }
        }


        #region Format menu
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
        }


        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }
        #endregion

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.Print($"{e.KeyCode}");

            if (e.KeyCode == Keys.Add && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                ZoomRichTextBoxView(0.1f, 5.0f); // zoom in by 10% and clamp limit at 500%
            }

            if (e.KeyCode == Keys.Subtract && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                ZoomRichTextBoxView(-0.1f, 0.1f);  // zoom out by 10% and clamp limit at 10%
            }

            //if (e.KeyCode == Keys.F1)
            //{
            //    Debug.Print("F1 pressed");
            //}
            //else if (e.KeyCode == Keys.F2)
            //{
            //    Debug.Print("F2 pressed");
            //}
            //else if (e.KeyCode == Keys.F3)
            //{
            //    Debug.Print("F3 pressed");
            //}
            //else if (e.KeyCode == Keys.F4)
            //{
            //    Debug.Print("F4 pressed");
            //}
            //else if (e.KeyCode == Keys.F5)
            //{
            //    Debug.Print("F5 pressed");
            //}
            //else if (e.KeyCode == Keys.F6)
            //{
            //    Debug.Print("F6 pressed");
            //}
            //else if (e.KeyCode == Keys.F7)
            //{
            //    Debug.Print("F7 pressed");
            //}
            //else if (e.KeyCode == Keys.F8)
            //{
            //    Debug.Print("F8 pressed");
            //}
            //else if (e.KeyCode == Keys.F9)
            //{
            //    Debug.Print("F9 pressed");
            //}
            //else if (e.KeyCode == Keys.F10)
            //{
            //    Debug.Print("F10 pressed");
            //}
            //else if (e.KeyCode == Keys.F11)
            //{
            //    Debug.Print("F11 pressed");
            //}
            //else if (e.KeyCode == Keys.F12)
            //{
            //    Debug.Print("F12 pressed");
            //}

            //if (e.KeyCode == Keys.F5)
            //{
            //    richTextBox1.SelectionLength = 0;
            //    richTextBox1.SelectedText = DateTime.Now.ToString();
            //}

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Common.changeMade = true;
            Text = $"* {Common.currentFileName} - Notepad C"; // indicate user has changed the text and that a Save is needed.
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($@"http://www.bing.com/search?q={richTextBox1.SelectedText}");
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            // First you need to get selectionstart. If there isn't any selected text, the value returned is the position of the caret (with offset in characters from the start of the text),
            // then you call getlinefromcharindex and pass that value, place it in the selectionchanged event and even with arrow keys moving the caret position it will update.
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            toolStripStatusLabel2.Text = $"Ln {line}, Row {index}";
        }

        private void aboutNotepadCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Common.StatusBarVisible = !Common.StatusBarVisible;
            if (statusBarToolStripMenuItem.Checked == true)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }

        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomRichTextBoxView(0.1f, 5.0f); // zoom in by 10% and clamp limit at 500%
        }

        private void zoomOutNumpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomRichTextBoxView(-0.1f, 0.1f);  // zoom out by 10% and clamp limit at 10%
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.RichTextBoxZoom = 1.0f; // restore zoom to 100%
            richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
            toolStripStatusLabel3.Text = $"{Common.RichTextBoxZoom * 100}%";
        }

        //private void zoomInToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Common.zoomInSelectedOnViewMenu = true;
        //    //Common.RichTextBoxZoom = Common.RichTextBoxZoom + 0.1f; // zoom in by 10%
        //    //richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
        //    //toolStripStatusLabel3.Text = $"{Common.RichTextBoxZoom * 100}%";

        //    // refactor into method! (used in Keydownevent as well!
        //    Common.RichTextBoxZoom = Common.RichTextBoxZoom + 0.1f; // zoom in by 10%
        //    if (Common.RichTextBoxZoom > 5.0f) Common.RichTextBoxZoom = 5.0f; // Clamp lower zoom limit at 500%
        //    richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
        //    toolStripStatusLabel3.Text = $"{Convert.ToInt16(Common.RichTextBoxZoom * 100)}%";
        //}

        //private void zoomOutToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Common.zoomOutSelectedOnViewMenu = true;
        //    Common.RichTextBoxZoom = Common.RichTextBoxZoom - 0.1f; // zoom out by 10%
        //    richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
        //    toolStripStatusLabel3.Text = $"{Common.RichTextBoxZoom * 100}%";
        //}

        //private void restoreDefaultZoomToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Common.RichTextBoxZoom = 1.0f; // restore zoom to 100%
        //    richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
        //    toolStripStatusLabel3.Text = $"{Common.RichTextBoxZoom * 100}%";
        //}

        private void ZoomRichTextBoxView(float percentChange, float PercentLimit)
        {
            Common.RichTextBoxZoom = Common.RichTextBoxZoom + percentChange; // -0.1f = zoom out by 10%,  0.1f = zoom in by 10%
            if (Common.RichTextBoxZoom > PercentLimit) Common.RichTextBoxZoom = PercentLimit; // 0.1f = Clamp zoom limit at 10%,  5.0f = Clamp zoom limit at 500%
            richTextBox1.ZoomFactor = Common.RichTextBoxZoom;
            toolStripStatusLabel3.Text = $"{Convert.ToInt16(Common.RichTextBoxZoom * 100)}%"; // Update Statubbar label
        }

        //private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        //{
        //    // First you need to get selectionstart. If there isn't any selected text, the value returned is the position of the caret (with offset in characters from the start of the text),
        //    // then you call getlinefromcharindex and pass that value, place it in the selectionchanged event and even with arrow keys moving the caret position it will update.
        //    int index = richTextBox1.SelectionStart;
        //    int line = richTextBox1.GetLineFromCharIndex(index);
        //    toolStripStatusLabel2.Text = $"Ln {line}, Row {index}";
        //}
    }
}