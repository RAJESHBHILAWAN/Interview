using NUnit;
using NUnit.DemoProject;
using NUnit.Framework;
namespace DemoProjectTest
{
    [TestFixture]
    public class Class1
    {
        List<EmployeeDetails> li;
        [Test]
        public void Checkdetails()
        {
            ManageEmployee pobj = new ManageEmployee();
            li = pobj.AllUsers();
            foreach (var x in li)
            {

                bool idisnull = Assert.Equals(x.Id, DBNull.Value);

                //Assert.IsNotNull(x.Name);
                //Assert.IsNotNull(x.Salary);
                //Assert.IsNotNull(x.Gender);
            }
        }


        [Test]
        public void TestLogin()
        {
            ManageEmployee pobj = new ManageEmployee();
            string x = pobj.Login("Ajit", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.Equals("Userid or password could not be Empty.", y);
            Assert.Equals("Incorrect UserId or Password.", x);
            Assert.Equals("Welcome Admin.", z);
        }

        [Test]
        public void getuserdetails()
        {
            ManageEmployee pobj = new ManageEmployee();
            var p = pobj.getDetails(100);
            foreach (var x in p)
            {
                Assert.Equals(x.Id, 100);
                Assert.Equals(x.Name, "Bharat");
            }
        }
    }
}
