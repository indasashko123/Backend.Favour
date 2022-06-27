using System;
namespace Favour.Core.SocialMedia
{
    public class Like
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ContentId { get; set; }
        public bool IsLike { get; set; }
        public DateTime DateTime { get; set; }
    }
}
