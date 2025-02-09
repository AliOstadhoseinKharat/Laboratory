using System;

namespace DomainModel.ViewModels
{
    public class ReceptionTestViewModel
    {

        public int PatientTestDetailsID { get; set; }

        public int PatientTestHeaderID { get; set; }

        public int PatientID { get; set; }


        public string PatientName { get; set; }

        public DateTime HeaderDate { get; set; }

        public int TestID { get; set; }

        public string TestName { get; set; }

        public int Price { get; set; }

        public float Result { get; set; }

        public string HasStar { get; set; }
    }

}
