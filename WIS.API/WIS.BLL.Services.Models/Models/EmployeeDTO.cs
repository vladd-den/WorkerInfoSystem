using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.BLL.Services.Models.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ProjectId { get; set; }
        public ProjectDTO Project { get; set; }
        public UserDTO User { get; set; }
    }
}
