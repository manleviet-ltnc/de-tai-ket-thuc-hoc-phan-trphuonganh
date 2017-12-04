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
        int dice1;
        int damge = 10;
        private void pbxBoss_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dice1 = random.Next(1, 4);

            switch (dice1)
            {
                case 1:
                    pbxPhai.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\1.png";

                    break;
                case 2:
                    pbxPhai.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\2.png";

                    break;
                case 3:
                    pbxPhai.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\3.png";

                    break;
            }
            if (progressBar1.Value > 0)

                progressBar1.Value -= damge;
            else
                MessageBox.Show("Bạn đã thắng");

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }
    }
}
