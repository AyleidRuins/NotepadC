using System;
using System.Reflection;
using System.Windows.Forms;

namespace Notepad_C
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            labVersion.Text = $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }
    }
}
