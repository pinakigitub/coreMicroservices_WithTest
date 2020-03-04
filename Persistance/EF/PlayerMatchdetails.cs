using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class PlayerMatchdetails
    {
        public int PlayerMatchdetailsId { get; set; }
        public int? Nooftestmatch { get; set; }
        public int? Noofonedaymatch { get; set; }
        public int? PlayerId { get; set; }

        public Players Player { get; set; }
    }
}
