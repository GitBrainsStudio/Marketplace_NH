using Marketplace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Domain.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void Save(User entity);
        void Delete(User entity);
        void Update(User entity);
    }
}
