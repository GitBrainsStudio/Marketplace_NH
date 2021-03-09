using Marketplace.Domain.Entities;
using Marketplace.Domain.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISession _session;

        public UserRepository(ISession session)
        {
            _session = session;
        }

        IQueryable<User> IUserRepository.Users => 
         _session.Query<User>();

        void IUserRepository.Save(User entity)
        {
            _session.SaveOrUpdateAsync(entity);
        }

        void IUserRepository.Delete(User entity)
        {
            _session.DeleteAsync(entity);
        }

        void IUserRepository.Update(User entity)
        {
            _session.UpdateAsync(entity);
        }
    }
}

