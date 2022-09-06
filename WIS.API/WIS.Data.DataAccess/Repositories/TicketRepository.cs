using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces.Repository;
using WIS.Data.DataAccess.Models.Entities;

namespace WIS.Data.DataAccess.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(WISDataContext db) : base(db)
        {
        }
    }
}
