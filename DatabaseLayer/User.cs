using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string EGN { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Role { get; set; }
        private User()
        {

        }
        public User(string username, string password, string email, string fname, string lname, string egn, string address, string phonenumber, string role = "staff")
        {
            Username = username;
            Password = password;
            Email = email;
            FName = fname;
            LName = lname;
            EGN = egn;
            Address = address;
            PhoneNumber = phonenumber;
            Role = role;

        }
    }
}
