using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.LinqQueries.Examples.Props
{
    public class Employee
    {
        public int Id { get; set; }

        public int DepID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public DateTime DOJ { get; set; }

        public String Email { get; set; }


    }
}
