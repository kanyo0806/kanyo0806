using System;

namespace BidvestData.Common.Models
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public GenderType Gender { get; set; }
        public string IPAddress { get; set; }
    }
}
