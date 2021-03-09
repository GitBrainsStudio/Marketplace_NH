using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Marketplace.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using NHibernate.Cfg;

namespace Marketplace.Infrastructure.Common
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            ISessionFactory sessionFactory = Fluently.Configure()

            .Database(SQLiteConfiguration.Standard.ConnectionString(connectionString)
                   .ShowSql())

           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
           //SchemeUpdate позволяет создавать/обновлять в БД таблицы и поля (2 поле ==true) 
           //.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
           .BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<IMapperSession, NHibernateMapperSession>();
            return services;
        }
    }
}
