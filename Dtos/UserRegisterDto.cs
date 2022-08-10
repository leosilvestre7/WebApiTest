using System;

namespace WebApiTest.Dtos
{
    public class UserRegisterDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool State { get; set; }

        public DateTime CreationDate  { get; set; }

        public UserRegisterDto()
        {
            CreationDate = DateTime.Now;
            State = true;
        }

    }
}
