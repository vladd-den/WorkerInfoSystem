using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces.Repository;

namespace WIS.Data.DataAccess.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IdentityUserManager IdentityUserManager { get; }
        IdentityRoleManager IdentityRoleManager { get; }

        IEmployeeRepository Employees { get; }
        IProjectRepository ProjectRepository { get; }
        ITicketRepository TicketRepository { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();

        void Commit();
        void Rollback();
        IDbContextTransaction BeginTransaction();
    }
}
