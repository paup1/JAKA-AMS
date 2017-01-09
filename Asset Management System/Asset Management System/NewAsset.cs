using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Asset_Management_System
{
    public partial class NewAsset : Form
    {
        public NewAsset()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int intId;
          
            try
            {

                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                string Query = "select * from assetmanagement.assets where AssetId='" + this.txtAssetId.Text + "' and Barcode ='" + this.txtBarcode.Text + "' ;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                string Code = string.Empty;
                while (myReader.Read())
                {
                    count = count + 1;
                    Code = myReader["Barcode"].ToString();
                }

                if (count == 1)
                {
                    MessageBox.Show("Record exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                }
                else if((!int.TryParse(txtAssetId.Text, out intId) &&(string.IsNullOrEmpty(txtAssetType.Text)&&(string.IsNullOrEmpty(txtAssetDesc.Text))))){
                    MessageBox.Show("Fill out the required fields!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string constring = "datasource=localhost;port=3306;username=root;password=root";
                    string QueryAdd = "insert into assetmanagement.assets (`AssetId`,`AssetType`,`AssetDescription`,`SerialNumber`,`Barcode`,`Quantity`,`Manufacturer`,`Model`,`Category`,`Condition`,`Location`,`Department`,`DateAcquired`,`InService`,`Supplier`,`Notes`,`AddedBy`,`DateAdded`) values ('" + this.txtAssetId.Text + "','" + this.txtAssetType.Text + "','" + this.txtAssetDesc.Text + "','" + this.txtSerial.Text + "','" + this.txtBarcode.Text + "','" + this.txtQuantity.Text + "','" + this.txtManufacturer.Text + "','" + this.txtModel.Text + "','" + this.txtCategory.Text + "','" + this.txtCondition.Text + "','" + this.txtLocation.Text + "','" + this.txtDepartment.Text + "','" + this.txtDateAcquired.Text + "','" + this.txtInService.Text + "','" + this.txtSupplier.Text + "','" + this.txtNotes.Text + "','" + this.txtAddedBy.Text + "','" + this.txtDateAdded.Text + "') ;";
                    MySqlConnection connDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(QueryAdd, connDataBase);

                    try
                    {
                        connDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved!", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                /*
                string constring = "datasource=localhost;port=3306;username=root;password=root";
                string QueryAdd = "insert into assetmanagement.assets (`AssetId`,`AssetType`,`AssetDescription`,`SerialNumber`,`Barcode`,`Quantity`,`Manufacturer`,`Model`,`Category`,`Condition`,`Location`,`Department`,`DateAcquired`,`InService`,`Supplier`,`Notes`,`AddedBy`,`DateAdded`) values ('" + this.txtAssetId.Text + "','" + this.txtAssetType.Text + "','" + this.txtAssetDesc.Text + "','" + this.txtSerial.Text + "','" + this.txtBarcode.Text + "','" + this.txtQuantity.Text + "','" + this.txtManufacturer.Text + "','" + this.txtModel.Text + "','" + this.txtCategory.Text + "','" + this.txtCondition.Text + "','" + this.txtLocation.Text + "','" + this.txtDepartment.Text + "','" + this.txtDateAcquired.Text + "','" + this.txtInService.Text + "','" + this.txtSupplier.Text + "','" + this.txtNotes.Text + "','" + this.txtAddedBy.Text + "','" + this.txtDateAdded.Text + "') ;";
                MySqlConnection connDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(QueryAdd, connDataBase);
                MySqlDataReader myReader;
                try
                {
                    connDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                    while (myReader.Read())
                    {

                    }

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
    }
}

