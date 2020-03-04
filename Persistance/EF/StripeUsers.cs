using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class StripeUsers
    {
        public StripeUsers()
        {
            StripeUserAddresses = new HashSet<StripeUserAddresses>();
            StripeUserShippingAddresses = new HashSet<StripeUserShippingAddresses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? Amount { get; set; }
        public int? MobileNo { get; set; }
        public string StripeCustId { get; set; }
        public string PlanType { get; set; }
        public string Coupon { get; set; }
        public bool? IsPaymentodMethodeAdded { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<StripeUserAddresses> StripeUserAddresses { get; set; }
        public ICollection<StripeUserShippingAddresses> StripeUserShippingAddresses { get; set; }
    }
}
