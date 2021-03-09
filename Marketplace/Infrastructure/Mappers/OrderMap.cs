using FluentNHibernate.Mapping;
using Marketplace.Domain.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure.Mappers
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {

            Id(x => x.Id, "id");
            Map(x => x.Name, "order_name");
            References(x => x.User, "user_id").Cascade.None();

            Table("orders");
        }
    }
}
