using System;

namespace WebApiTest.Models
{
    public class User
    {
        public int UserId { get; set;}

        public string Email { get; set; }

        public string Password { get; set; }

        public bool State { get; set; }

        public DateTime CreationDate  { get; set; }
    }
}
