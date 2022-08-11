using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace multiFormsApp
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        static string DbLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../multiFormsDB.mdb");
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + DbLocation +"; Persist Security Info=True");

        public static Customer customerClass = new Customer();

        private void DisplayAllCustomers()
        {
            con.Open();
            string Query = "SELECT * FROM cusInfo";
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, con);
            OleDbCommandBuilder Builder = new OleDbCommandBuilder(oda);
            var ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCusForm = new NewCustomerForm();
            newCusForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ΕΞΟΔΟΣ ΑΠΟ ΤΗΝ ΕΦΑΡΜΟΓΗ", "ΠΡΟΣΟΧΗ !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {                
                this.Close();                
            }                      
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'multiFormsDBDataSet.cusInfo' table. You can move, or remove it, as needed.
            this.cusInfoTableAdapter.Fill(this.multiFormsDBDataSet.cusInfo);
            //MessageBox.Show(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"").ToString());

        }

        //ΠΕΛΑΤΕΣ BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAllCustomers();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                customerClass.CusID = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                customerClass.CusLname = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                customerClass.CusFname = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                customerClass.CusPhone1 = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                customerClass.CusPhone2 = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                customerClass.CusAddress = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                customerClass.CusCity = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                customerClass.CusCategory = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                customerClass.CusJobName = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                customerClass.CusJob = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                customerClass.CusAfm = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                customerClass.CusDoy = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                customerClass.CusNextVisit = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                customerClass.CusComments1 = dataGridView1.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
                customerClass.CusComments2 = dataGridView1.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();

                CustomerInfoForm f = new CustomerInfoForm();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("register failed due to " + ex);
            }
        }

        //ΑΝΑΖΗΤΗΣΗ 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM cusInfo WHERE (phone1 LIKE @Search)" +
                                                        "OR (phone2 LIKE @Search)" +
                                                        "OR (sName LIKE @Search)" +
                                                        "OR (address LIKE @Search)" +
                                                        "OR (nextVisit LIKE @Search)" +
                                                        "OR (category LIKE @Search)" +
                                                        "OR (city LIKE @Search)";
                OleDbCommand cmd = new OleDbCommand(Query, con);
                cmd.Parameters.AddWithValue("@Search", "%" + textBox1.Text.ToString() + "%");
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>1)
            {
                try
                {
                    con.Open();
                    string Query = "SELECT * FROM cusInfo WHERE (" +
                                                                "(phone1 LIKE @Search)" +
                                                                "OR (phone2 LIKE @Search)" +
                                                                "OR (sName LIKE @Search)" +
                                                                "OR (address LIKE @Search)" +
                                                                "OR (nextVisit LIKE @Search)" +
                                                                "OR (category LIKE @Search)" +
                                                                "OR (city LIKE @Search))" +
                                                                "AND (" +
                                                                    "(phone1 LIKE @Search2)" +
                                                                    "OR (phone2 LIKE @Search2)" +
                                                                    "OR (sName LIKE @Search2)" +
                                                                    "OR (address LIKE @Search2)" +
                                                                    "OR (nextVisit LIKE @Search2)" +
                                                                    "OR (category LIKE @Search2)" +
                                                                    "OR (city LIKE @Search2)" +
                                                                    ")";

                    OleDbCommand cmd = new OleDbCommand(Query, con);
                    cmd.Parameters.AddWithValue("@Search", "%" + textBox1.Text.ToString() + "%");
                    cmd.Parameters.AddWithValue("@Search2", "%" + textBox2.Text.ToString() + "%");
                    DataTable dt = new DataTable();
                    OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Register Failed Due to " + ex,"ERROR");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string pathd = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //String path = "C:\\Users\\Michalis\\Desktop\\yolo.pdf";
                PdfWriter writer = new PdfWriter(pathd + "/yolo.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document doc = new Document(pdf,iText.Kernel.Geom.PageSize.A4.Rotate());
                PdfFont normalFont = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\arial.ttf", "Identity-H");

                doc.SetFont(normalFont);
                doc.SetFontSize(10);            
   
                try
                {
                    Table pTable = new Table(8,true);
                    pTable.SetPadding(5);
                    pTable.SetMaxWidth(UnitValue.CreatePercentValue(100));
                    
                    pTable.AddCell(dataGridView1.Columns[0].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[1].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[2].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[3].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[4].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[5].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[6].HeaderText);
                    pTable.AddCell(dataGridView1.Columns[7].HeaderText);

                    foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                    {                                 
                        pTable.AddCell(viewRow.Cells[0].Value.ToString());
                        pTable.AddCell(viewRow.Cells[1].Value.ToString());
                        pTable.AddCell(viewRow.Cells[2].Value.ToString());
                        pTable.AddCell(viewRow.Cells[3].Value.ToString());
                        pTable.AddCell(viewRow.Cells[4].Value.ToString());
                        pTable.AddCell(viewRow.Cells[5].Value.ToString());
                        pTable.AddCell(viewRow.Cells[6].Value.ToString());
                        pTable.AddCell(viewRow.Cells[7].Value.ToString());
                    }

                    doc.Add(pTable);
                    doc.Close();
                    MessageBox.Show("Data Export Successfully", "INFO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting Data" + ex.Message , "ERROR");
                }

            }
            else
            {
                MessageBox.Show("No Records Found","ERROR");
            } 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

    }
}
