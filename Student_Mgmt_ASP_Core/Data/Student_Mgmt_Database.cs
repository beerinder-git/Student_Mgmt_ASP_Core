using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_ASP_Core.Model;

namespace Student_Mgmt_ASP_Core.Data
{
    public class Student_Mgmt_Database : DbContext
    {
        public Student_Mgmt_Database (DbContextOptions<Student_Mgmt_Database> options)
            : base(options)
        {
        }

        public DbSet<Student_Mgmt_ASP_Core.Model.Course> Course { get; set; }

        public DbSet<Student_Mgmt_ASP_Core.Model.Student> Student { get; set; }
    }
}
