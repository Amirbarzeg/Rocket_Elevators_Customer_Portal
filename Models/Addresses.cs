using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Addresses
    {
        public long Id { get; set; }
        public string Typeofaddress { get; set; }
        public string Status { get; set; }
        public string Entity { get; set; }
        public string Numberandstreet { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Notes { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}