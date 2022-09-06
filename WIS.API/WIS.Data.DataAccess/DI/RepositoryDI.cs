using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces;
using WIS.Data.DataAccess.Interfaces.Repository;
using WIS.Data.DataAccess.Interfaces.UoW;
using WIS.Data.DataAccess.Models.Entities;
using WIS.Data.DataAccess.Repositories;
using WIS.Data.DataAccess.UoW;

namespace WIS.Data.DataAccess.DI
{
    public static class RepositoryDI
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IdentityUserManager>();
            services.AddScoped<IdentityRoleManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddIdentityCore<User>().AddRoles<IdentityRole>().AddEntityFrameworkStores<WISDataContext>();
            return services;
        }
    }
}
