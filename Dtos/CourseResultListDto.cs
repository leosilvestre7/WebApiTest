using System;

namespace WebApiTest.Dtos
{
    public class CourseResultListDto
    {
        public int Note { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate  { get; set; }
    }
}
