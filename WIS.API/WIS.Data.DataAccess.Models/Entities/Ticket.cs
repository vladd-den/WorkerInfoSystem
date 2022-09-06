using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.DataAccess.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? TicketName { get; set; }
        public DateTime CreatedDate { get; set; }

        public TicketStatus Status { get; set; }
        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
