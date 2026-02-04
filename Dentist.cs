using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo1forProject
{
    internal class Dentist
    {
        private String name;
        private SqlDateTime availibility;
        private String speciality;
        private List<Patient>  personalPatients;
    }
}
