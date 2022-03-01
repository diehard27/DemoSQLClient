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
    public partial class frmReceiveVender : Form
    {
        public frmReceiveVender()
        {
            InitializeComponent();
        }
       
        private void frmReceive_Load(object sender, EventArgs e)
        {
            dgList.DataBindings.Clear();

            string strConnection = String.Format("Data Source= {0};Initial Catalog={1};User ID={2};Password={3};", MobileConfiguration.Settings["ServerName"], MobileConfiguration.Settings["DatabaseName"], MobileConfiguration.Settings["UserName"], MobileConfiguration.Settings["Password"]);
           
            try
            {
                
                // MessageBox.Show("Now Connecting to "+MobileConfiguration.Settings["ServerName"]);

                string strCommand = "Select * from LotTravel";
                //  A connection, a command, and a reader
                SqlConnection connDB = new SqlConnection(strConnection);
                connDB.Open();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, connDB);
                DataSet ds = new DataSet();
                da.Fill(ds, "LotTravel");

                dgList.DataSource = ds.Tables["LotTravel"];
                PrepareList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
             
            }

          
        }

        protected void PrepareList()
        {
            


            try
            {
               
                dgList.TableStyles.Clear();
             
                DataGridTableStyle ts = new DataGridTableStyle(); 
                ts.MappingName = "LotTravel";

              

                dgList.TableStyles.Add(ts); 
                dgList.TableStyles[0].GridColumnStyles["ID"].Width = -1;
                dgList.TableStyles[0].GridColumnStyles["Lotno"].Width = 70;
                dgList.TableStyles[0].GridColumnStyles["ScanDate"].Width = -1;
                dgList.TableStyles[0].GridColumnStyles["Process"].Width = 50;
                dgList.TableStyles[0].GridColumnStyles["Good"].Width = 35;
                dgList.TableStyles[0].GridColumnStyles["NG"].Width = 25;
                dgList.TableStyles[0].GridColumnStyles["User"].HeaderText  = "PartCode";
                dgList.TableStyles[0].GridColumnStyles["User"].Width = 50;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in PrepareList\n" + ex.Message);
            }
        }

    

      
      

      
       
       
    }
}