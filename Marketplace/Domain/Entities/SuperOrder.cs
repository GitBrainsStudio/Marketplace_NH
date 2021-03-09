using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Domain.Entities
{
    public class SuperOrder
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual IList<Order> Orders { get; protected set; }
    }
}
