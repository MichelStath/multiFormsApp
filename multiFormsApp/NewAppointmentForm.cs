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
    public partial class NewAppointmentForm : Form
    {
        public NewAppointmentForm()
        {
            InitializeComponent();           
        }

        
        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "multiFormsDB.mdb");       
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation + "; Persist Security Info=True");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
        //ΑΠΟΘΗΚΕΥΣΗ ΝΕΑΣ ΕΦΡΑΡΜΟΓΗΣ 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String insertQuerry = "INSERT INTO cusAppointment(cusID," +
                                                        "entomoktonia," +
                                                        "myoktonia," +
                                                        "apolymansh," +
                                                        "visitDate," +
                                                        "price," +
                                                        "appComments1," +
                                                        "appComments2" +
                                              ")VALUES('" + homeForm.customerClass.CusID.ToString() +
                                                        "','" + entomoktoniaTB.Texts.ToString() +
                                                        "','" + myoktoniaTB.Texts.ToString() +
                                                        "','" + apolymanshTB.Texts.ToString() +
                                                        "','" + visitDateTB.Texts.ToString() +
                                                        "','" + visitPriceTB.Texts.ToString() +
                                                         "','" + visitComms1TB.Texts.ToString() +
                                                        "','" + visitComms2TB.Texts.ToString() + "') ";
                OleDbCommand cmd = new OleDbCommand(insertQuerry, con);
                cmd.ExecuteNonQuery();
                string msg = "ΤΟ ΡΑΝΤΕΒΟΥ ΚΑΤΑΧΩΡΗΘΗΚΕ ΜΕ ΕΠΙΤΥΧΙΑ\n" +
                             "ID ΠΕΛΑΤΗ :  " + customTB4.Texts + "\n" +
                             "ΗΜΕΡΟΜΗΝΙΑ :  " + visitDateTB.Texts + "\n" +
                             "ΕΝΤΟΜΟΚΤΟΝΙΑ :  " + entomoktoniaTB.Texts + "\n" +
                             "ΜΥΟΚΤΟΝΙΑ :  " + myoktoniaTB.Texts + "\n" +
                             "ΑΠΟΛΥΜΑΝΣΗ :  " + apolymanshTB.Texts + "\n" +
                             "ΤΙΜΗ :  " + visitPriceTB.Texts + "\n";
                MessageBox.Show(msg, "ΕΠΙΤΥΧΙΑ ΕΓΓΡΑΦΗΣ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
            finally
            {               
                con.Close();
                this.Close();
            }
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            customTB4.Texts = homeForm.customerClass.CusID;
        }
    }
}
