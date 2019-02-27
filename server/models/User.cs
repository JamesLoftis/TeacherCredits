using System.Collections.Generic;

namespace server.models
{
    public class User
    {
        public User()
        {
            UserSemesters = new List<UserSemester>();
        }
        public string Name { get; set; }
        public int TeachingCredits { get; set; }
        public List<UserSemester> UserSemesters { get; set; }
    }
}