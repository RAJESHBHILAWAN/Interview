using InterviewPrep.LinqQueries.Examples.Props;
using System.ComponentModel.DataAnnotations;

namespace InterviewPrep.LinqQueries.Examples
{
    public class EmpInfo
    {
        public EmpInfo()
        {
            DepartmentsList();
            EmployeesList();
            // SalaryLessThan();
            // MaxSalary();
            //NameStartsWith("P");
            // ExpInYears();
            //EmployeeWithValidEmail();
            //EmployeeDepartment();
            NumOfEmployeeInEachDept();
        }

        private void NumOfEmployeeInEachDept()
        {
            var empllst = EmployeesList();
            var deplst = DepartmentsList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has DeptID {emp.DepID}.");
            }
            foreach (var dept in deplst)
            {
                Console.WriteLine($"DepartmentID : {dept.DepId} has Name {dept.Name}.");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");
            var deptemployee = from emp in empllst
                               join
                                dept in deplst
                                on emp.DepID equals dept.DepId
                               group dept by dept.DepId
                              into g
                               select new
                               {
                                   Id = g.Key,
                                   Count = g.Count()
                               };

            foreach (var dept in deptemployee)
            {
                Console.WriteLine($"Department ID : {dept.Id} has Employees {dept.Count}.");

            }

            var empdepname = from dept in deplst
                         join empGroup in (
                            from e in empllst
                            group e by e.DepID into g
                            select g
                         ) on dept.DepId equals empGroup.Key
                         select new
                         {
                             Name = dept.Name,
                             Employees = empGroup.ToArray()
                         };

            foreach (var dept in empdepname)
            {
                Console.WriteLine($"Department Name : {dept.Name} has Employees {dept.Employees.Count() }.");

            }


        }
        private void EmployeeDepartment()
        {
            var empllst = EmployeesList();
            var deplst = DepartmentsList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has DeptID {emp.DepID}.");
            }
            foreach (var dept in deplst)
            {
                Console.WriteLine($"DepartmentID : {dept.DepId} has Name {dept.Name}.");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");
            var empwithdep = from emp in empllst
                             join
                              dep in deplst on
                              emp.DepID equals dep.DepId
                             select new
                             {
                                 Name = emp.Name,
                                 Department = dep.Name
                             };

            foreach (var emp in empwithdep)
            {
                Console.WriteLine($"Employee : {emp.Name} is in department  {emp.Department}.");

            }

        }
        private void EmployeeWithValidEmail()
        {


            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has Email as {emp.Email} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");

            EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();

            var empwithvalidemail = from emp in empllst
                                    where emailAddressAttribute.IsValid(emp.Email) &&
                                    !String.IsNullOrEmpty(emp.Email)
                                    select emp;
            foreach (var emp in empwithvalidemail)
            {
                Console.WriteLine($"Employee : {emp.Name} has valid email address as {emp.Email}.");

            }

        }
        private void ExpInYears()
        {
            var empllst = EmployeesList();

            var empexperiance = empllst.Select(
              e => new
              {
                  Id = e.Id,
                  EmplloyeeName = e.Name,
                  EmployeeSalary = e.Salary,
                  Experiance = (System.DateTime.Now.Date - e.DOJ) / 365,
                  DateOfJoin = e.DOJ
              }
              );
            foreach (var emp in empexperiance)
            {
                Console.WriteLine($"Employee : {emp.EmplloyeeName} has DOJ as {emp.DateOfJoin} has {emp.Experiance} years experiance.");
            }

        }

        private void NameStartsWith(string strstart)
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has Salary of {emp.Salary} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");
            var startswithR = from emp in empllst
                              where emp.Name.ToLower().StartsWith(strstart.ToLower())
                              select emp;
            foreach (var emp in startswithR)
            {
                Console.WriteLine($"Employee Name whose name starts with {strstart}  : {emp.Name} ");
            }

        }
        private void MaxSalary()
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has Salary of {emp.Salary} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");

            var highestpaidemployee = from emp in empllst
                                      where emp.Salary == empllst.Max(x => x.Salary)
                                      select emp;
            foreach (var emp in highestpaidemployee)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has max salary with salary of {emp.Salary}");
            }





        }

        private void SalaryLessThan()
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has Salary of {emp.Salary} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");
            int minsal = 5600;
            var empl = from emp in EmployeesList()
                       where emp.Salary < minsal
                       select emp;

            foreach (var emp in empl)
            {
                Console.WriteLine($"Employee Name : {emp.Name} has Salary of {emp.Salary} is less than {minsal}");
            }
        }

        public List<Department> DepartmentsList()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Name = "Physics", DepId = 10 });
            departments.Add(new Department { Name = "Biology", DepId = 20 });
            departments.Add(new Department { Name = "Chemistry", DepId = 30 });
            return departments;
        }
        public List<Employee> EmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                DepID = 10,
                Name = "Abhi Singh",
                DOJ = new DateTime(2022, 4, 12),
                Id = 1,
                Salary = 2500,
                Email = "a@com"
            });
            employees.Add(new Employee
            {
                DepID = 20,
                Name = "Priyanka Gupta",
                DOJ = new DateTime(2023, 5, 13),
                Id = 2,
                Salary = 5500
            });
            employees.Add(new Employee
            {
                DepID = 20,
                Name = "Piyush Srivastava",
                DOJ = new DateTime(2020, 6, 15),
                Id = 3,
                Salary = 7500,
                Email = "a@a.com"
            });
            employees.Add(new Employee
            {
                DepID = 30,
                Name = "Ankit Verma",
                DOJ = new DateTime(2022, 8, 1),
                Id = 4,
                Salary = 8000,
                Email = "prafull@gmail.net"
            });
            employees.Add(new Employee
            {
                DepID = 20,
                Name = "Pratyush Sharma",
                DOJ = new DateTime(2021, 2, 23),
                Id = 5,
                Salary = 3000,
                Email = "anukrishnaom@gmail.com"
            });
            employees.Add(new Employee
            {
                DepID = 10,
                Name = "Kiran Rao",
                DOJ = new DateTime(2019, 8, 28),
                Id = 6,
                Salary = 5700,
                Email = "xyz"
            });
            return employees;
        }
    }
}
