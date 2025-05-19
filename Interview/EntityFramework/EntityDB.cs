using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.EntityFramework
{
    internal class EntityDB : DbContext
    {
        public EntityDB() : base("name=WebApiDbEntities")
        {


        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

      

    }
}
