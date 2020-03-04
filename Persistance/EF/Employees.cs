using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int? Salary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
