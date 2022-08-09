using System;

namespace WebApiTest.Models
{
    public class CourseResult
    {
        public int CourseResultId { get; set;}

        public int CourseId { get; set; }

        public int UserId { get; set; }

        public int StudentId { get; set; }

        public int Note { get; set; }

        public bool State { get; set; }

        public DateTime CreationDate  { get; set; }
    }
}
