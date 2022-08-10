using System;

namespace WebApiTest.Dtos
{
    public class UserListDto
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public bool State { get; set; }

        public DateTime CreationDate  { get; set; }
    }
}
