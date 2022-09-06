using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.DataAccess.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
    }
}
