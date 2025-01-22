using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CenterClinics.Model
{
    public class Specialty
    {
        public int SpecialtyID { get; set; }
      public string SpecialtyName { get; set; }
        public ICollection<Clinic> Clinics { get; set; }
    }
}