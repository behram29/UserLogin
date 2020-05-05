using System;
using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }

    }
}
