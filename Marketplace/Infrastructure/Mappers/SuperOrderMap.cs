using FluentNHibernate.Mapping;
using Marketplace.Domain.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace Marketplace.Infrastructure.Mappers
{
    public class SuperOrderMap : ClassMap<SuperOrder>
    {
        public SuperOrderMap()
        {
            Id(x => x.Id, "id");
            Map(x => x.Name, "name");

            HasManyToMany(x => x.Orders)
               .Table("orders_orders")
               .ParentKeyColumn("super_order_id")
               .ChildKeyColumn("order_id")
               .Inverse()            
               .Cascade.All();

            Table("super_orders");
        }
    }
}
