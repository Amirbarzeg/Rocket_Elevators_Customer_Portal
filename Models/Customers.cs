using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Customers
    {
       
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string NameOfContact { get; set; }
        public string CompanyContactPhone { get; set; }
        public string EmailOfTheCompany { get; set; }
        public string CompanyDescription { get; set; }
        public string NameOfServiceTechAuthority { get; set; }
        public string TechAuhtorityPhone { get; set; }
        public string TechManagerServiceEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UserId { get; set; }
        public long? AddressId { get; set; }

    }
}
