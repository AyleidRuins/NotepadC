using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_C
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void btnForegroundColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Common.ForegroundColour = colorDialog1.Color;
                btnForegroundColour.BackColor = Common.ForegroundColour;
            }
        }

        private void btnBackgroundColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Common.BackgroundColour = colorDialog1.Color;
                btnBackgroundColour.BackColor = Common.BackgroundColour;
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            btnBackgroundColour.BackColor = Common.BackgroundColour;
            btnForegroundColour.BackColor = Common.ForegroundColour;
        }

        private void rbLightMode_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?","Switch to Light mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Common.ForegroundColour = Color.FromArgb(0, 0, 0);
                Common.BackgroundColour = Color.FromArgb(255, 255, 255);
                btnBackgroundColour.BackColor = Common.BackgroundColour;
                btnForegroundColour.BackColor = Common.ForegroundColour;
                Close();
            }
        }

        private void rbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Switch to Dark mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Common.BackgroundColour = Color.FromArgb(80, 80, 80);
                Common.ForegroundColour = Color.FromArgb(255, 255, 255);
                btnBackgroundColour.BackColor = Common.BackgroundColour;
                btnForegroundColour.BackColor = Common.ForegroundColour;
                Close();
            }

        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            btnBackgroundColour.BackColor = Common.BackgroundColour;
            btnForegroundColour.BackColor = Common.ForegroundColour;
        }
    }
}