using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class Flight
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string FromLocation { get; set; }
        [Required]
        public string ToLocation { get; set; }
        [Column(TypeName = "datetime2")]
        [Required]
        public DateTime TakeOffTime { get; set; }
        [Required]
        public DateTime LandingTime { get; set; }
        [Required]
        public string PlaneType { get; set; }
        [Required]
        public string PlaneID { get; set; }
        [Required]
        public string PilotName { get; set; }
        [Required]
        public int NormalTicketCount { get; set; }
        [Required]
        public int BusinessTicketCount { get; set; }


        private Flight()
        {

        }
        public Flight(string fromlocation, string tolocation, DateTime takeofftime, DateTime landingtime, string planetype, string planeid, string pilotname, int normalticketcount, int businessticketcount)
        {
            ID = Guid.NewGuid().ToString();
            FromLocation = fromlocation;
            ToLocation = tolocation;
            TakeOffTime = takeofftime;
            LandingTime = landingtime;
            PlaneType = planetype;
            PlaneID = planeid;
            PilotName = pilotname;
            NormalTicketCount = normalticketcount;
            BusinessTicketCount = businessticketcount;

        }
    }
}
