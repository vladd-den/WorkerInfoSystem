using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.BLL.Services.Models.Models
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public string? TicketName { get; set; }
        public DateTime CreatedDate { get; set; }

        public TicketStatusDTO Status { get; set; }
        public ProjectDTO Project { get; set; }
        public EmployeeDTO Employee { get; set; }
    }
}
