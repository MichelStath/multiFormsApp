using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiFormsApp
{
    public class Appointment
    {
        private string appID;
        private string cusID;
        private string entomoktonia;
        private string myoktonia;
        private string apolymansh;
        private string visitDate;
        private string price;
        private string appComments1;
        private string appComments2;

        public string AppID { get => appID; set => appID = value; }
        public string CusID { get => cusID; set => cusID = value; }
        public string Entomoktonia { get => entomoktonia; set => entomoktonia = value; }
        public string Myoktonia { get => myoktonia; set => myoktonia = value; }
        public string Apolymansh { get => apolymansh; set => apolymansh = value; }
        public string VisitDate { get => visitDate; set => visitDate = value; }
        public string Price { get => price; set => price = value; }
        public string AppComments1 { get => appComments1; set => appComments1 = value; }
        public string AppComments2 { get => appComments2; set => appComments2 = value; }
    }
}
