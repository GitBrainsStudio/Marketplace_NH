using Marketplace.Domain.Entities;
using System.Linq;

namespace Marketplace.Domain.Repositories
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void Save(Order entity);
        void Delete(Order entity);
        void Update(Order entity);
    }
}
