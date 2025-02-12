using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public sealed record AuctionDeleted
    {
        public string Id { get; set; }
    }
}
