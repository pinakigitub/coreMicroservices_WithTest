using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class UserCrens
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
