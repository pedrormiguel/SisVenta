using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class Provider
    {
        public Provider()
        {
        }

        public Guid ProviderId { get; set; }
        public string CompanyName { get; set; }
        public string CommercialSector { get; set; }

        public PersonalDocument TypeDocument { get; set; }
        public string Document { get; set; }

        public string Address { get; set; }
        public string TelephonNumber { get; set; }
        public string Email { get; set; }
        public string UrlSite { get; set; }

    }
}
