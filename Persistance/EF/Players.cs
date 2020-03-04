using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class Players
    {
        public Players()
        {
            PlayerMatchdetails = new HashSet<PlayerMatchdetails>();
        }

        public int PlayerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Country { get; set; }
        public string Lastname1 { get; set; }

        public ICollection<PlayerMatchdetails> PlayerMatchdetails { get; set; }
    }
}
