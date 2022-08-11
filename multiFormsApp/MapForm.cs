using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiFormsApp
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            StringBuilder querryAddress = new StringBuilder();
            querryAddress.Append("https://www.google.com/maps/place/");
            querryAddress.Append(homeForm.customerClass.CusAddress);
            querryAddress.Append(" " + homeForm.customerClass.CusCity);

            customTB1.Texts = homeForm.customerClass.CusAddress;
            customTB2.Texts = homeForm.customerClass.CusCity;

            webBrowser1.Navigate(querryAddress.ToString());
        }
    }
}
