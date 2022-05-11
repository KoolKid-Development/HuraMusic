using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuraMusic
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmExit exit = new FrmExit();
        private void label6_Click(object sender, EventArgs e)
        {
            exit.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            exit.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            sidemenu.Page = Settings;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Pages.Page = Player;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Pages.Page = Playlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidemenu.Page = Main;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
