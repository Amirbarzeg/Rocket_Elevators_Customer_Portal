using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public partial class Users
    {
        

        public long Id { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}