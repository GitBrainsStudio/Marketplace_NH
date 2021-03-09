using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Domain.Entities
{
    public class Order
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual User User { get; protected set; }
    }
}
