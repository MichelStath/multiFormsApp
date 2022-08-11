using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiFormsApp
{
    public partial class CustomerInfoForm : Form
    {       

        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "multiFormsDB.mdb");      
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation + "; Persist Security Info=True");
        
        public CustomerInfoForm()
        {          
           InitializeComponent();         
        }
  
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();                         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Customer c = new Customer();
            //c.CusID = cusIDTB.Texts.ToString();
            //c.CusFname = nameTB.Texts;
            //c.CusLname = sNameTB.Texts;
            //c.CusAddress = addressTB.Texts;
           
            AppointmentsForm appForm = new AppointmentsForm();           
            appForm.ShowDialog();
            //appForm.BringToFront();
            
        }

        //ΕΠΕΞΕΡΓΑΣΙΑ ΠΕΛΑΤΗ
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE cusInfo SET sName=@SNAME," +
                                                                    "fName=@FNAME," +
                                                                    "phone1=@PHONE1," +
                                                                    "phone2=@PHONE2," +
                                                                    "address=@ADDRESS," +
                                                                    "city=@CITY," +
                                                                    "category=@CATEGORY," +
                                                                    "jobName=@JOBNAME," +
                                                                    "job=@JOB," +
                                                                    "afm=@AFM," +
                                                                    "doy=@DOY," +
                                                                    "nextVisit=@NEXTVISIT," +
                                                                    "comments1=@COMMS1," +
                                                                    "comments2=@COMMS2" +
                                                                    " WHERE ID=@CUSID", con);
                cmd.Parameters.AddWithValue("@SNAME", sNameTB.Texts);
                cmd.Parameters.AddWithValue("@FNAME", nameTB.Texts);
                cmd.Parameters.AddWithValue("@PHONE1", phone1TB.Texts);
                cmd.Parameters.AddWithValue("@PHONE2", phone2TB.Texts);
                cmd.Parameters.AddWithValue("@ADDRESS", addressTB.Texts);
                cmd.Parameters.AddWithValue("@CITY", cityTB.Texts);
                cmd.Parameters.AddWithValue("@CATEGORY", categoryTB.Texts);
                cmd.Parameters.AddWithValue("@JOBNAME", jobNameTB.Texts);
                cmd.Parameters.AddWithValue("@JOB", jobTB.Texts);
                cmd.Parameters.AddWithValue("@AFM", afmTB.Texts);
                cmd.Parameters.AddWithValue("@DOY", doyTB.Texts);
                cmd.Parameters.AddWithValue("@NEXTVISIT", nextVisitTB.Texts);
                cmd.Parameters.AddWithValue("@COMMS1", comments1TB.Texts);
                cmd.Parameters.AddWithValue("@COMMS2", comments2TB.Texts);
                cmd.Parameters.AddWithValue("@CUSID", cusIDTB.Texts);
                cmd.ExecuteNonQuery();

                MessageBox.Show("επεξεργασια πελατη επιτυχης!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
            finally
            {
                this.Close();
            }            
        }

        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            cusIDTB.Texts = homeForm.customerClass.CusID;
            nameTB.Texts = homeForm.customerClass.CusFname;
            sNameTB.Texts = homeForm.customerClass.CusLname;
            phone1TB.Texts = homeForm.customerClass.CusPhone1;
            phone2TB.Texts = homeForm.customerClass.CusPhone2;
            addressTB.Texts = homeForm.customerClass.CusAddress;
            cityTB.Texts = homeForm.customerClass.CusCity;
            categoryTB.Texts = homeForm.customerClass.CusCategory;
            jobNameTB.Texts = homeForm.customerClass.CusJobName;
            jobTB.Texts = homeForm.customerClass.CusJob;
            afmTB.Texts = homeForm.customerClass.CusAfm;
            doyTB.Texts = homeForm.customerClass.CusDoy;
            nextVisitTB.Texts = homeForm.customerClass.CusNextVisit;
            comments1TB.Texts = homeForm.customerClass.CusComments1;
            comments2TB.Texts = homeForm.customerClass.CusComments2;
        }

        private void mapBTN_Click(object sender, EventArgs e)
        {
            MapForm mapform = new MapForm();
            mapform.ShowDialog();
        }
    }
}
