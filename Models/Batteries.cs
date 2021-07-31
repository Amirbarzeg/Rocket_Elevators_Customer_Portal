using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Batteries
    {
        
        public long Id { get; set; }
        public string Btype { get; set; }
        public string Status { get; set; }
        public DateTime? DateOfCommissioning { get; set; }
        public DateTime? DateOfLastInspection { get; set; }
        public string CertificateOfOperations { get; set; }
        public string Info { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? BuildingId { get; set; }
        public long? EmployeeId { get; set; }

       
    }
}
