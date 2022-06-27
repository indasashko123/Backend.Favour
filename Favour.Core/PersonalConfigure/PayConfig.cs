using Favour.Core.Enums;
using System;
namespace Favour.Core.PersonalConfigure
{
    public class PayConfig
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public EthereumChains EthereumChain { get; set; }
        public uint Value { get; set; }
        public SubscribeLevel SubscribeLevel { get; set; }
    }
}
