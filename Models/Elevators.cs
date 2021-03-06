using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Elevators
    {
      
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string ElevatorType { get; set; }
        public string Status { get; set; }
        public DateTime? DateOfCommissioning { get; set; }
        public DateTime? DateOfLastInspection { get; set; }
        public string CertificateOfInspection { get; set; }
        public string Info { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? ColumnId { get; set; }

      
    }
}
