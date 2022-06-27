using System;

namespace Favour.Core.Identity
{
    public class Login
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
    }
}
