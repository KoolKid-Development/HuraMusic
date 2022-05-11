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
    public partial class FrmExit : Form
    {
        public FrmExit()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
