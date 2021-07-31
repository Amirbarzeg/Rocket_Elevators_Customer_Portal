using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Buildings
    {
        
        public long Id { get; set; }
        public string FullNameOfTheBuildingAdministrator { get; set; }
        public string EmailOfTheAdministratorOfTheBuilding { get; set; }
        public string PhoneNumberOfTheBuildingAdministrator { get; set; }
        public string FullNameOfTheTechContactForTheBuilding { get; set; }
        public string TechContactEmail { get; set; }
        public string TechContactPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? CustomerId { get; set; }
        public long? AddressId { get; set; }
    }
    };