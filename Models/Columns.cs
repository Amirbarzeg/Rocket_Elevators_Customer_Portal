using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Columns
    {
        

        public long Id { get; set; }
        public string ColumnType { get; set; }
        public int? NbOfFloorsServed { get; set; }
        public string Status { get; set; }
        public string Info { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? BatteryId { get; set; }

        
    }
}