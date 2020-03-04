using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class Productinfos
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public int? Unitprice { get; set; }
    }
}
