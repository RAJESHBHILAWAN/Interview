using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.EntityFrameword
{
    internal class EntityDB : DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public EntityDB() : base("name=WebApiDbEntities")
        {


        }

    }
}
