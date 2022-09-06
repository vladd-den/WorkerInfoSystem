using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.BLL.Services.Models.Models;

namespace WIS.BLL.Services.Interfaces.Interfaces
{
    public interface IAuthService
    {
        Task<object> SignInAsync(UserDTO userDTO);
        Task<object> SignUpAsync(UserDTO userDTO);
    }
}
