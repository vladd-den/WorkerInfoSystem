using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces;
using WIS.Data.DataAccess.Interfaces.Repository;
using WIS.Data.DataAccess.Interfaces.UoW;

namespace WIS.Data.DataAccess.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WISDataContext _db;
        public IdentityUserManager IdentityUserManager { get; }
        public IdentityRoleManager IdentityRoleManager { get; }
        public IEmployeeRepository Employees { get; }
        public IProjectRepository ProjectRepository { get; }
        public ITicketRepository TicketRepository { get; }

        public UnitOfWork(WISDataContext db,
           IdentityUserManager IdentityUserManager,
           IdentityRoleManager IdentityRoleManager,
           IEmployeeRepository Employees,
           IProjectRepository ProjectRepository,
           ITicketRepository TicketRepository)
        {
            _db = db;
            this.IdentityUserManager = IdentityUserManager;
            this.IdentityRoleManager = IdentityRoleManager;
            this.Employees = Employees;
            this.ProjectRepository = ProjectRepository;
            this.TicketRepository = TicketRepository;
        }

        public int SaveChanges()
        {
           return _db.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            int rowsChanged = await _db.SaveChangesAsync();
            return rowsChanged;
        }

        public void Commit()
        {
            _db.Database.CurrentTransaction.Commit();
        }

        public void Rollback()
        {
            _db.Database.RollbackTransaction();
        }

        public IDbContextTransaction BeginTransaction()
        {
            using IDbContextTransaction transaction = _db.Database.BeginTransaction();
            return transaction;
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
