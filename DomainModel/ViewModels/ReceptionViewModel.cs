using System;

namespace DomainModel.ViewModels
{
    public class ReceptionViewModel
    {

        public int PatientTestHeaderID { get; set; }

        public string PatientTestHeaderName { get; set; }

        public DateTime HeaderDate { get; set; }


        public int PatientID { get; set; }
        public string PatientName { get; set; }


        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }


        public int InsuranceTypeID { get; set; }
        public string InsuranceTypeName { get; set; }

        public string DrName { get; set; }

        public long TotalPrice { get; set; }

        public int Age { get; set; }

    }
}
