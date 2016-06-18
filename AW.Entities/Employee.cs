using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Entities
{
    public class Employee
    {
        public int BusinessEntityID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginId { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public Int16 VacationHours { get; set; }

    }
}
