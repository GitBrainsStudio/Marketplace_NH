using Marketplace.Domain.Entities;
using Marketplace.Domain.Repositories;
using Marketplace.Infrastructure.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure.Common
{
    public class NHibernateMapperSession : IMapperSession
    {
        private readonly ISession _session;
        private ITransaction _transaction;
        public IUserRepository UserRepository { get; } 
        public IOrderRepository OrderRepository { get; }
        public ISuperOrderRepository SuperOrderRepository { get; }
        public NHibernateMapperSession(ISession session)
        {
            _session = session;
            UserRepository = new UserRepository(session);
            OrderRepository = new OrderRepository(session);
            SuperOrderRepository = new SuperOrderRepository(session);
        }

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }
    }
}
