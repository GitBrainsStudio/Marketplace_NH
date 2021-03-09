using Marketplace.Domain.Entities;
using Marketplace.Domain.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure.Repositories
{
    public class SuperOrderRepository : ISuperOrderRepository
    {
        ISession _session;
        public SuperOrderRepository(ISession session)
        {
            _session = session;
        }
        IQueryable<SuperOrder> ISuperOrderRepository.SuperOrders =>
            _session.Query<SuperOrder>();

        void ISuperOrderRepository.Delete(SuperOrder entity)
        {
            _session.SaveOrUpdateAsync(entity);
        }

        void ISuperOrderRepository.Save(SuperOrder entity)
        {
            _session.DeleteAsync(entity);
        }

        void ISuperOrderRepository.Update(SuperOrder entity)
        {
            _session.Update(entity);
        }
    }
}
