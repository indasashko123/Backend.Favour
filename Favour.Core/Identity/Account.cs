using Favour.Core.Enums;
using System;

namespace Favour.Core.Identity
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public DateTime Created { get; set; }
    }
}
