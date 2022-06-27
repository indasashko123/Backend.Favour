using System;
using System.Collections.Generic;

namespace Favour.Core.PersonalConfigure
{
    public class AuthorConfig
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public List<Guid> PayConfigIds { get; set; }
    }
}
