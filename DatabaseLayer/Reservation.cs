using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace DatabaseLayer
{
    public class Reservation
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string MName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string EGN { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string TicketType { get; set; }

        [Required]
        public Flight Flight { get; set; }


        private Reservation()
        {

        }  
        public Reservation(string fname, string mname, string lname, string egn, string email, string phonenum, string nationality, string tickettype, Flight flight)
        {
            ID = Guid.NewGuid().ToString();
            FName = fname;
            MName = mname;
            LName = lname;
            EGN = egn;
            Email = email;
            PhoneNum = phonenum;
            Nationality = nationality;
            TicketType = tickettype;
            Flight = flight;
        }
    }
}
