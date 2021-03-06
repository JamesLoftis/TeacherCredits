using System;
using System.Collections.Generic;

namespace Server.Models
{
    public class User
    {
        public User()
        {
            UserSemesters = new List<UserSemester>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TeachingCredits { get; set; }
        public List<UserSemester> UserSemesters { get; set; }
    }
}