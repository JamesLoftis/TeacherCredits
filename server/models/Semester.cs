using System;
using System.Collections.Generic;

namespace Server.Models
{
    public class Semester
    {
        public Semester()
        {
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<UserSemester> UserSemesters { get; set; }

    }
}