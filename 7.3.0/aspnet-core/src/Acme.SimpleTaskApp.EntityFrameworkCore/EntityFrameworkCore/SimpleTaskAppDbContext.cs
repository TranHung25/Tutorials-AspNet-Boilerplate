using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Acme.SimpleTaskApp.Authorization.Roles;
using Acme.SimpleTaskApp.Authorization.Users;
using Acme.SimpleTaskApp.MultiTenancy;
using Acme.SimpleTaskApp.Tasks;

namespace Acme.SimpleTaskApp.EntityFrameworkCore
{
    public class SimpleTaskAppDbContext : AbpZeroDbContext<Tenant, Role, User, SimpleTaskAppDbContext>
    {
        public DbSet<Person> People { get; set; }

        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }
        public SimpleTaskAppDbContext(DbContextOptions<SimpleTaskAppDbContext> options)
            : base(options)
        {
        }
    }
}
