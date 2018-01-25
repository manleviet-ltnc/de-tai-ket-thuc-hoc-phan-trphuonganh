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
        int dice2;
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

            Random random = new Random();
            dice2 = random.Next(2, 24);
            switch (dice2)
            {
                case 4:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\4.png";
                    break;

                case 5:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\5.png";
                    break;

                case 6:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\6.png";
                    break;

                case 7:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\7.png";
                    break;

                case 8:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\8.png";
                    break;

                case 9:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\9.png";
                    break;

                case 10:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\10.png";
                    break;

                case 11:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\11.png";
                    break;

                case 12:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\12.png";
                    break;

                case 13:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\13.png";
                    break;

                case 14:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\14.png";
                    break;

                case 15:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\15.png";
                    break;

                case 16:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\16.png";
                    break;

                case 17:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\17.png";
                    break;

                case 18:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\18.png";
                    break;

                case 19:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\19.png";
                    break;

                case 20:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\20.png";
                    break;

                case 21:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\21.png";
                    break;

                case 22:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\22.png";
                    break;

                case 23:
                    pbxBoss.ImageLocation = "C:\\Users\\toshiba\\Desktop\\Tap Titans\\23.png";
                    break;
            }
           

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
