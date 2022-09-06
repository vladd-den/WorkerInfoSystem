using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.Repositories.Interfaces.Interfaces
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "WISDB_ConnectionString");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "WISDB_ConnectionString");
    }
}
