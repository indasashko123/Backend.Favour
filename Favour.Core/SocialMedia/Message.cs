using Favour.Core.Enums;
using System;
using System.Collections.Generic;

namespace Favour.Core.SocialMedia
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public List<string> ContentLinks { get; set; }
        public ContentType ContentType { get; set; }
    }
}
