using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiFormsApp
{
    public class Customer
    {
        private string cusID;
        private string cusFname;
        private string cusLname;
        private string cusPhone1;
        private string cusPhone2;
        private string cusAddress;
        private string cusCity;
        private string cusCategory;
        private string cusJobName;
        private string cusJob;
        private string cusAfm;
        private string cusDoy;
        private string cusNextVisit;
        private string cusComments1;
        private string cusComments2;

        public string CusID { get => cusID; set => cusID = value; }
        public string CusFname { get => cusFname; set => cusFname = value; }
        public string CusLname { get => cusLname; set => cusLname = value; }
        public string CusPhone1 { get => cusPhone1; set => cusPhone1 = value; }
        public string CusPhone2 { get => cusPhone2; set => cusPhone2 = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public string CusCity { get => cusCity; set => cusCity = value; }
        public string CusCategory { get => cusCategory; set => cusCategory = value; }
        public string CusJobName { get => cusJobName; set => cusJobName = value; }
        public string CusJob { get => cusJob; set => cusJob = value; }
        public string CusAfm { get => cusAfm; set => cusAfm = value; }
        public string CusDoy { get => cusDoy; set => cusDoy = value; }
        public string CusNextVisit { get => cusNextVisit; set => cusNextVisit = value; }
        public string CusComments1 { get => cusComments1; set => cusComments1 = value; }
        public string CusComments2 { get => cusComments2; set => cusComments2 = value; }
    }
}
