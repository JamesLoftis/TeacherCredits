using System;

namespace Server.Models
{
    public class Semester
    {
        public Semester()
        {
        }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}