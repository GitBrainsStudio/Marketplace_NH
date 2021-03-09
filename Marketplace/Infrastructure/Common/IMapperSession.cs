using Marketplace.Domain.Entities;
using Marketplace.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure.Common
{
    public interface IMapperSession
    {
        void BeginTransaction();
        Task Commit();
        Task Rollback();
        void CloseTransaction();
        IUserRepository UserRepository { get; }
        IOrderRepository OrderRepository { get; }
        ISuperOrderRepository SuperOrderRepository { get; }
    }
}
