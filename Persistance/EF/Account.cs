using System;
using System.Collections.Generic;

namespace Persistance.EF
{
    public partial class Account
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
