using System;

namespace Server.Models
{
    public class UserSemester
    {
        public UserSemester()
        {

        }
        public Guid Id { get; set; }
        public Semester Semester { get; }
        public double NumberRegularHoursTaught { get; set; }
        public int NumberClassesTaught { get; set; }
        public int NumberOfLongClasses { get; set; }
        public bool IsTeachingDrama { get; set; }
        public bool IsResponsibleAdult { get; set; }
        public bool IsCoordinator { get; set; }
        public bool IsBoardMember { get; set; }
    }
}