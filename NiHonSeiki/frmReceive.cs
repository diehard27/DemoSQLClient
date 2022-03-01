using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NiHonSeiki
{
    public partial class frmReceive : Form
    {
        public frmReceive()
        {
            InitializeComponent();
        }

        CurrencyManager cmBarcodeScan;
        DataTable BarcodeScan;
        DataSet ds = new DataSet();
        SqlDataAdapter daBarcodeScan;
        SqlConnection connDB;

        public void setFormText(string text){
            this.Text = text;
        }
        private void frmReceive_Load(object sender, EventArgs e)
        {
            dgList.DataBindings.Clear();

            string strConnection = String.Format("Data Source= {0};Initial Catalog={1};User ID={2};Password={3};", MobileConfiguration.Settings["ServerName"], MobileConfiguration.Settings["DatabaseName"], MobileConfiguration.Settings["UserName"], MobileConfiguration.Settings["Password"]);
           
            try
            {
                
                 MessageBox.Show("Now Connecting to "+MobileConfiguration.Settings["ServerName"]);

                string strCommand = "Select * from BarcodeScans";
                //  A connection, a command, and a readeran
                connDB = new SqlConnection(strConnection);
                connDB.Open();
                daBarcodeScan = new SqlDataAdapter(strCommand, connDB);

                daBarcodeScan.Fill(ds, "BarcodeScans");

                BarcodeScan = ds.Tables["BarcodeScans"];
                dgList.DataSource = BarcodeScan;

                cmBarcodeScan = (CurrencyManager)this.BindingContext[BarcodeScan];
                PrepareList();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
             
            }
            catch (PlatformNotSupportedException ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }

          
        }

        private void PrepareList()
        {
            


            try
            {
               
                dgList.TableStyles.Clear();
             
                DataGridTableStyle ts = new DataGridTableStyle(); 
                ts.MappingName = "BarcodeScan";

              

                dgList.TableStyles.Add(ts); 
                //dgList.TableStyles[0].GridColumnStyles["ID"].Width = -1;
                dgList.TableStyles[0].GridColumnStyles["ScanDateTime"].Width = 70;
               // dgList.TableStyles[0].GridColumnStyles["ScanDate"].Width = -1;
                dgList.TableStyles[0].GridColumnStyles["VendorTag"].Width = 50;
                dgList.TableStyles[0].GridColumnStyles["ASICOTag"].Width = 35;
                dgList.TableStyles[0].GridColumnStyles["isMatch"].Width = 25;
                //dgList.TableStyles[0].GridColumnStyles["PartCode"].Width = 50;
                //dgList.TableStyles[0].GridColumnStyles["User"].Width = -1;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in PrepareList\n" + ex.Message);
            }
        }
        private void PrepareView()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                   ((TextBox)control).Text = "";
                }
            }
        }

        void txtLotNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) txtProcess.Focus();

        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {

        }
        void txtProcess_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) txtGood.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cmBarcodeScan.AddNew();
            DataRow currentRow = ((DataRowView)cmBarcodeScan.Current).Row;

                 
            currentRow["Lotno"] = txtLotNo .Text;
            currentRow["Process"] = txtProcess .Text;
            currentRow["ScanDate"] = System.DateTime.Now;
            currentRow["Good"] = txtGood.Text;
            currentRow["NG"] = txtNG.Text;
            currentRow["PartCode"] = "FTN699";
           
          
            try
            {
                cmBarcodeScan.EndCurrentEdit();
                SqlCommandBuilder cb;
                cb = new SqlCommandBuilder(daBarcodeScan);
                Console.WriteLine(cb.GetInsertCommand().CommandText.ToString());
                daBarcodeScan.ContinueUpdateOnError = false;
                daBarcodeScan.AcceptChangesDuringUpdate = true;

                Console.WriteLine(string.Format("update return {0}", daBarcodeScan.Update(BarcodeScan)));
                BarcodeScan.AcceptChanges();

                ds.AcceptChanges();

                

            }

            catch (Exception ex)
            {
               // MessageBox.Show("Error while save data\n" + ex.Message);
                Console.WriteLine("Error while save data\n" + ex.Message);
            }
            finally { PrepareView(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
      


      

      
       
       
    }
}