using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.DemoProject
{


    public class ManageEmployee
    {
        public ManageEmployee() { }
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }

        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails
            {
                Id = 100,
                Name = "Bharat",
                Gender = "male",
                Salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                Id = 101,
                Name = "sunita",
                Gender = "Female",
                Salary = 50000
            });
            li.Add(new EmployeeDetails
            {
                Id = 103,
                Name = "Karan",
                Gender = "male",
                Salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                Id = 104,
                Name = "Jeetu",
                Gender = "male",
                Salary = 23000
            });
            li.Add(new EmployeeDetails
            {
                Id = 105,
                Name = "Manasi",
                Gender = "Female",
                Salary = 80000
            });
            li.Add(new EmployeeDetails
            {
                Id = 106,
                Name = "Ranjit",
                Gender = "male",
                Salary = 670000
            });
            return li;
        }
        public List<EmployeeDetails> getDetails(int Id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
             
            var li = AllUsers();
            foreach (var x in li)
            {
                if (x.Id == Id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }

    public class EmployeeDetails
    {



        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
    }
}
