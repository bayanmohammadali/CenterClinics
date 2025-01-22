using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CenterClinics.Model
{
    public class Clinic
    {

        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public int SpecialtyID { get; set; }
        public Specialty Specialty
        {
            get; set;
        }
    }
}