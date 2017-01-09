using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Management_System
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void btnBarcodeWin_Click(object sender, EventArgs e)
        {
            BarcodeGenerator bc = new Asset_Management_System.BarcodeGenerator();
            bc.Show();
        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(dlg == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                
                System.Environment.Exit(1);
             
            }
            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dlg == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
  
                System.Environment.Exit(1);
            }
        }

        private void barcodeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodeGenerator bc = new Asset_Management_System.BarcodeGenerator();
            bc.Show();
        }

        private void newAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAsset na = new Asset_Management_System.NewAsset();
            na.Show();
        }
    }
}
