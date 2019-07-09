using Fitness_Asp.Net_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.DAL
{
    public class Fitness:DbContext
    {
        public Fitness():base("Fitness")
        {
           
        }
        public DbSet<ClassCalendars> classCalendars { get; set; }
        public DbSet<ClubInfos> clubInfos { get; set; }
        public DbSet<Coupons> coupons { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<CourseSchedules> courseSchedules { get; set; }
        public DbSet<Packages> packages { get; set; }
        public DbSet<Payments> payments { get; set; }
        public DbSet<Rooms> rooms { get; set; }
        public DbSet<Trainers> trainers { get; set; }
        public DbSet<UserLists> userLists { get; set; }
        public DbSet<UserProfiles> userProfiles { get; set; }
        public DbSet<Days> days { get; set; }
        public DbSet<AdminUser> adminUsers { get; set; }


    }

    
}