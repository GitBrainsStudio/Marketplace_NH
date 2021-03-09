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
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("users");
            Id(x => x.Id, "id");
            Map(x => x.Name, "firstname");
        }
    }
}
