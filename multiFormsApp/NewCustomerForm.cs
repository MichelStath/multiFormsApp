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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();           
        }

        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../multiFormsDB.mdb");
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation + "; Persist Security Info=True");
        private void clearTB()
        {

            fNameTB.Texts = "";
            sNameTB.Texts = "";
            phone1TB.Texts = "";
            phone2TB.Texts = "";
            addressTB.Texts = "";
            cityTB.Texts = "";
            jobNameTB.Texts = "";
            jobTB.Texts = "";
            afmTB.Texts = "";
            doyTB.Texts = "";
            nextVisitTB.Texts = "";
            comments1TB.Texts = "";
            categoryTB.Texts = "";
            comments2TB.Texts = "";
            //throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SAVE NEW CUSTOMER BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String insertQuerry = "INSERT INTO cusInfo(fName," +
                                                        "sName," +
                                                        "phone1," +
                                                        "phone2," +
                                                        "address," +
                                                        "city," +
                                                        "jobName," +
                                                        "job," +
                                                        "afm," +
                                                        "doy," +
                                                        "nextVisit," +
                                                        "comments1," +
                                                        "category," +
                                                        "comments2) " +
                                                "VALUES('" + fNameTB.Texts +
                                                        "','" + sNameTB.Texts +
                                                        "','" + phone1TB.Texts +
                                                        "','" + phone2TB.Texts +
                                                        "','" + addressTB.Texts +
                                                        "','" + cityTB.Texts +
                                                        "','" + jobNameTB.Texts +
                                                        "','" + jobTB.Texts +
                                                        "','" + afmTB.Texts +
                                                        "','" + doyTB.Texts +
                                                        "','" + nextVisitTB.Texts +
                                                        "','" + comments1TB.Texts.ToString() +
                                                        "','" + categoryTB.Texts.ToString() +
                                                        "','" + comments2TB.Texts + "') ";
                OleDbCommand cmd = new OleDbCommand(insertQuerry, con);
                cmd.ExecuteNonQuery();

                string msg = "Ο ΝΕΟΣ ΠΕΛΑΤΗΣ ΚΑΤΑΧΩΡΗΘΗΚΕ ΜΕ ΕΠΙΤΥΧΙΑ\n" +
                             "ΕΠΩΝΥΜΟ : " + sNameTB.Texts + "\n" +
                             "ΟΝΟΜΑ : " + fNameTB.Texts + "\n" +
                             "ΔΙΕΥΘΥΝΣΗ : " + addressTB.Texts + "\n" +
                             "ΠΟΛΗ : " + cityTB.Texts + "\n" +
                             "ΤΗΛΕΦΩΝΟ : " + phone1TB.Texts + "\n";
                MessageBox.Show(msg, "ΕΠΙΤΥΧΙΑ ΕΓΓΡΑΦΗΣ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
            finally
            {
                con.Close();
                //clearInfoTB();               
                this.Close();
            }            
            
        }

        //CLEAR ALL TEXTBOX BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
