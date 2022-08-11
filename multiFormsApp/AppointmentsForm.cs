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
    public partial class AppointmentsForm : Form
    {
        
        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "multiFormsDB.mdb");
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation + "; Persist Security Info=True");

        public AppointmentsForm()
        {
            InitializeComponent();                                
        }

        public static Appointment appo = new Appointment();

        private void showAppointment(string customerID)
        {
            try
            {
                //"SELECT * FROM cusAppointment WHERE cusID=" + customTB4.Texts + "";               
                con.Open();
                string Query = "SELECT * FROM cusAppointment WHERE (cusID LIKE @CusID)";

                OleDbCommand cmd = new OleDbCommand(Query, con);
                cmd.Parameters.AddWithValue("@CusID", customerID);
                DataTable dt = new DataTable();
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
            finally
            {
                con.Close();
            }
        }
              

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'multiFormsDBDataSet1.cusAppointment' table. You can move, or remove it, as needed.
            this.cusAppointmentTableAdapter.Fill(this.multiFormsDBDataSet1.cusAppointment);

            customTB1.Texts = homeForm.customerClass.CusFname;
            customTB2.Texts = homeForm.customerClass.CusLname;
            customTB3.Texts = homeForm.customerClass.CusAddress;
            customTB4.Texts = homeForm.customerClass.CusID.ToString();

            showAppointment(homeForm.customerClass.CusID);



        }

        //ΝΕΟ ΡΑΝΤΕΒΟΥ
        private void button1_Click(object sender, EventArgs e)
        {
            NewAppointmentForm naf = new NewAppointmentForm();
            naf.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showAppointment(customTB4.Texts);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
                appo.AppID= dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                appo.CusID= dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                appo.Entomoktonia= dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                appo.Myoktonia= dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                appo.Apolymansh= dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                appo.VisitDate= dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                appo.Price= dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                appo.AppComments1= dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                appo.AppComments2= dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();


                AppointmentInfoForm aif = new AppointmentInfoForm();
                aif.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
        }
    }
}
