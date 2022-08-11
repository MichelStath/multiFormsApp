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
    public partial class AppointmentInfoForm : Form
    {
        public AppointmentInfoForm()
        {
            InitializeComponent();
        }
        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../multiFormsDB.mdb");
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation + "; Persist Security Info=True");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentInfoForm_Load(object sender, EventArgs e)
        {
            entomoktoniaTB.Texts = AppointmentsForm.appo.Entomoktonia;
            myoktoniaTB.Texts = AppointmentsForm.appo.Myoktonia;
            apolymanshTB.Texts = AppointmentsForm.appo.Apolymansh;
            visitPriceTB.Texts = AppointmentsForm.appo.Price;
            visitDateTB.Texts = AppointmentsForm.appo.VisitDate;
            visitComms1TB.Texts = AppointmentsForm.appo.AppComments1;
            visitComms2TB.Texts = AppointmentsForm.appo.AppComments2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE cusAppointment SET entomoktonia=@ENTOMOKTONIA," +
                                                                    "myoktonia=@MYOKTONIA," +
                                                                    "apolymansh=@APOLYMANSH," +
                                                                    "visitDate=@VISITDATE," +
                                                                    "price=@VISITPRICE," +
                                                                    "appComments1=@VISITCOMMS1," +
                                                                    "appComments2=@VISITCOMMS2" +
                                                                    " WHERE ID=@APPID", con);
                cmd.Parameters.AddWithValue("@ENTOMOKTONIA", entomoktoniaTB.Texts);
                cmd.Parameters.AddWithValue("@MYOKTONIA", myoktoniaTB.Texts);
                cmd.Parameters.AddWithValue("@APOLYMANSH", apolymanshTB.Texts);
                cmd.Parameters.AddWithValue("@VISITDATE", visitDateTB.Texts);
                cmd.Parameters.AddWithValue("@VISITPRICE", visitPriceTB.Texts);
                cmd.Parameters.AddWithValue("@VISITCOMMS1", visitComms1TB.Texts);
                cmd.Parameters.AddWithValue("@VISITCOMMS2", visitComms2TB.Texts);
                cmd.Parameters.AddWithValue("@APPID", AppointmentsForm.appo.AppID);
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
    }
}
