using Marketplace.Domain.Entities;
using Marketplace.Domain.Repositories;
using NHibernate;
using System.Linq;

namespace Marketplace.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ISession _session;

        public OrderRepository(ISession session)
        {
            _session = session;
        }

        IQueryable<Order> IOrderRepository.Orders =>
             _session.Query<Order>();

        void IOrderRepository.Save(Order entity)
        {
            _session.SaveOrUpdateAsync(entity);
        }

        void IOrderRepository.Delete(Order entity)
        {
            _session.DeleteAsync(entity);
        }

        void IOrderRepository.Update(Order entity)
        {
            _session.UpdateAsync(entity);
        }
    }
}
