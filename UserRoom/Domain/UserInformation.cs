using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRoom.Domain
{
    public class UserInformation
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public DateTime DateLogin { get; set; }
        public string Password { get; set; }
        
    }
}

