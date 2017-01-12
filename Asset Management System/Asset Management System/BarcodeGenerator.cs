using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Configuration;

namespace Asset_Management_System
{
    public partial class BarcodeGenerator : Form
    {

        public BarcodeGenerator()
        {
            InitializeComponent();
            FillCategoryCombo();
            FillAssetTypeCombo();
        }

        void FillCategoryCombo()
        {
            string myConnection = ConfigurationManager.ConnectionStrings["AMSDatabase"].ConnectionString;
            string Query = "select distinct category from assetmanagement.categories";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    String sName = myReader.GetString("category");
                    cbCategory.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void FillAssetTypeCombo()
        {
            string myConnection = ConfigurationManager.ConnectionStrings["AMSDatabase"].ConnectionString;
            string Query = "select assettype, category from assetmanagement.categories where category ='" + cbCategory.Text + "' ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    String sName = myReader.GetString("assettype");
                    cbAssetType.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnGen_Click(object sender, EventArgs e)
        {
            string myConnection = ConfigurationManager.ConnectionStrings["AMSDatabase"].ConnectionString;
            string Query = "select assettype, category, prefix from assetmanagement.categories where assettype ='" + cbAssetType.Text + "' ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    try
                    {
                        String sName = myReader.GetString("prefix");

                        var chars = "0123456789";
                        var stringChars = new char[16];
                        var random = new Random();

                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }

                        var finalString = new String(stringChars);
                        string barcode2 = sName + "-" + finalString;

                        //BARCODE GEN
                        Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                        pictureBox1.Image = barcode.Draw(barcode2, 50);
                        txtBarcode.Text = barcode2;

                        btnPrintBC.Show();
                        txtBarcode.Show();
                        lblBarcode.Show();


                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAssetType.Items.Clear();
            FillAssetTypeCombo();


        }


        private void BarcodeGenerator_Load(object sender, EventArgs e)
        {
            btnPrintBC.Hide();
            txtBarcode.Hide();
            lblBarcode.Hide();

        }

        private void btnPrintBC_Click(object sender, EventArgs e)
        {
           
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                printDocument1.OriginAtMargins = true;
                printDocument1.DocumentName = "TEST IMAGE PRINTING";

                printDialog1.Document = printDocument1;
                printDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
            e.Graphics.DrawString(txtBarcode.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 0, 55);
        }
    }
}
