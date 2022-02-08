using HMS_Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS_DAL.Data
{
     public class HMSDbContext:DbContext
    {

        public HMSDbContext(DbContextOptions<HMSDbContext> options) : base(options)
        {

        }
        public DbSet<PatientReg> patientReg { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Reception> reception { get; set; }

    }
}
