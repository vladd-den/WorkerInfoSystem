using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces.Repository;
using WIS.Data.DataAccess.Models.Entities;
using WIS.Infrastructure.Shared.Extensions;

namespace WIS.Data.DataAccess.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(WISDataContext db) : base(db)
        {
        }
    }
}
