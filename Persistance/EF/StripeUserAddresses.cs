using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class StripeUserAddresses
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StripeCustId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? StripeUserId { get; set; }

        public StripeUsers StripeUser { get; set; }
    }
}
