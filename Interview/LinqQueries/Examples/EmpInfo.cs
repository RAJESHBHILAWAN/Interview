using InterviewPrep.LinqQueries.Examples.Props;
using System.ComponentModel.DataAnnotations;

namespace InterviewPrep.LinqQueries.Examples
{
    public class EmpInfo
    {
        public EmpInfo()
        {
            //DepartmentsList();
            //EmployeesList();
            //SalaryLessThan();
            //MaxSalary();
            //NameStartsWith("P");
            //ExpInYears();
            //EmployeeWithValidEmail();
            //EmployeeDepartment();
            // NumOfEmployeeInEachDept();
            LeftJoin();
        }

        private void LeftJoin()
        {
            var empllst = EmployeesList();
            var deplst = DepartmentsList();
            //foreach (var emp in empllst)
            //{
            //    Console.WriteLine($"Employee Name : {emp.EmpName} has DeptID {emp.DepID}.");
            //}
            //foreach (var dept in deplst)
            //{
            //    Console.WriteLine($"DepartmentID : {dept.DepId} has Name {dept.DepName}.");
            //}
            var q =
            from emp in empllst
            join dept in deplst on emp.DepID equals 
            dept.DepId into gr
            from d in gr.DefaultIfEmpty()
            select new { Employee = emp.EmpName , DepartmentName = d == null ? "(not yet allocated)" : d.DepName };
            foreach (var obj in q)
            {
                Console.WriteLine($"Employee {obj.Employee}'s department is {obj.DepartmentName}");
            }

        }

        private void NumOfEmployeeInEachDept()
        {
            var empllst = EmployeesList();
            var deplst = DepartmentsList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has DeptID {emp.DepID}.");
            }
            foreach (var dept in deplst)
            {
                Console.WriteLine($"DepartmentID : {dept.DepId} has Name {dept.DepName}.");
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
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");

            var empdepname = from dept in deplst
                             join empGroup in (
                                from e in empllst
                                group e by e.DepID into g
                                select g
                             ) on dept.DepId equals empGroup.Key
                             select new
                             {
                                 Name = dept.DepName,
                                 Employees = empGroup.ToArray()
                             };

            foreach (var x in empdepname)
            {
                Console.WriteLine($"Department Name : {x.Name} has Employees {x.Employees.Count()}.");

            }


        }
        private void EmployeeDepartment()
        {
            var empllst = EmployeesList();
            var deplst = DepartmentsList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has DeptID {emp.DepID}.");
            }
            foreach (var dept in deplst)
            {
                Console.WriteLine($"DepartmentID : {dept.DepId} has Name {dept.DepName}.");
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
                                 Name = emp.EmpName,
                                 Department = dep.DepName
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
                Console.WriteLine($"Employee Name : {emp.EmpName} has Email as {emp.Email} ");
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
                Console.WriteLine($"Employee : {emp.EmpName} has valid email address as {emp.Email}.");

            }

        }
        private void ExpInYears()
        {
            var empllst = EmployeesList();

            var empexperiance = empllst.Select(
              e => new
              {
                  Id = e.Id,
                  EmplloyeeName = e.EmpName,
                  EmployeeSalary = e.Salary,
                  Experiance = (System.DateTime.Now.Date - e.DOJ) / 365,
                  DateOfJoin = e.DOJ
              }
              );
            foreach (var emp in empexperiance)
            {
                Console.WriteLine($"Employee : {emp.EmplloyeeName} has DOJ as {emp.DateOfJoin} has {String.Format("{0:##}", emp.Experiance)} years experiance.");
            }

        }

        private void NameStartsWith(string strstart)
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has Salary of {emp.Salary} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");
            var startswithR = from emp in empllst
                              where emp.EmpName.ToLower().StartsWith(strstart.ToLower())
                              select emp;
            foreach (var emp in startswithR)
            {
                Console.WriteLine($"Employee Name whose name starts with {strstart}  : {emp.EmpName} ");
            }

        }
        private void MaxSalary()
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has Salary of {emp.Salary} ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("******************************************");
            Console.WriteLine("------------------------------------------");

            var highestpaidemployee = from emp in empllst
                                      where emp.Salary == empllst.Max(x => x.Salary)
                                      select emp;
            foreach (var emp in highestpaidemployee)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has max salary with salary of {emp.Salary}");
            }





        }

        private void SalaryLessThan()
        {
            var empllst = EmployeesList();
            foreach (var emp in empllst)
            {
                Console.WriteLine($"Employee Name : {emp.EmpName} has Salary of {emp.Salary} ");
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
                Console.WriteLine($"Employee Name : {emp.EmpName} has Salary of {emp.Salary} is less than {minsal}");
            }
        }

        public List<Department> DepartmentsList()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { DepName = "Physics", DepId = 10 });
            departments.Add(new Department { DepName = "Biology", DepId = 20 });
            departments.Add(new Department { DepName = "Chemistry", DepId = 30 });
            return departments;
        }
        public List<Employee> EmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            int empid = 0;
            employees.Add(new Employee
            {
                DepID = 10,
                EmpName = "Abhi Singh",
                DOJ = new DateTime(2022, 4, 12),
                Id = ++empid,
                Salary = 2500,
                Email = "a@com"
            });
            employees.Add(new Employee
            {
                DepID = 20,
                EmpName = "Priyanka Gupta",
                DOJ = new DateTime(2023, 5, 13),
                Id = ++empid,
                Salary = 5500
            });
            employees.Add(new Employee
            {
                DepID = 20,
                EmpName = "Piyush Srivastava",
                DOJ = new DateTime(2020, 6, 15),
                Id = ++empid,
                Salary = 7500,
                Email = "a@a.com"
            });
            employees.Add(new Employee
            {
                DepID = 30,
                EmpName = "Ankit Verma",
                DOJ = new DateTime(2022, 8, 1),
                Id = ++empid,
                Salary = 8000,
                Email = "prafull@gmail.net"
            });
            employees.Add(new Employee
            {
                DepID = 20,
                EmpName = "Pratyush Sharma",
                DOJ = new DateTime(2021, 2, 23),
                Id = ++empid,
                Salary = 3000,
                Email = "anukrishnaom@gmail.com"
            });
            employees.Add(new Employee
            {
                DepID = 10,
                EmpName = "Kiran Rao",
                DOJ = new DateTime(2019, 8, 28),
                Id = ++empid,
                Salary = 5700,
                Email = "xyz"
            });
            employees.Add(new Employee
            {

                EmpName = "Dept Singh",
                DOJ = new DateTime(2019, 8, 28),
                Id = ++empid,
                Salary = 5700,
                Email = "xyz"
            });
            return employees;
        }
    }
}
