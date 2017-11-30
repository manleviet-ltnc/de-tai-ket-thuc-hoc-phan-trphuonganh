using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap_Titans
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetTitleBar();
        }
        private void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);
            Text = String.Format("Tap Titans {0:0}.{1:0}",
                                 ver.Major, ver.Minor);
        }

        private void pbxBoss_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
