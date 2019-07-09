using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class ViewModel
    {
        public List<ClassCalendars> ClassCalendars { get; set; }
        public List<ClubInfos> ClubInfos { get; set; }
        public List<Coupons> Coupons { get; set; }
        public List<CourseSchedules> CourseSchedules { get; set; }
        public List<Packages> Packages { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Days> Days { get; set; }
        public List<Payments> Payments { get; set; }
        public List<Rooms> Rooms { get; set; }
        public List<Trainers> Trainers { get; set; }
        public List<UserLists> UserLists { get; set; }
        public List<UserProfiles> UserProfiles { get; set; }
      
    }
}