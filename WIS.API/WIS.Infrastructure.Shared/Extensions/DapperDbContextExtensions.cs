using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WIS.Data.DataAccess;

namespace WIS.Infrastructure.Shared.Extensions
{
    public static class DapperDbContextExtensions
    {
        public static async Task<IEnumerable<T>> QueryAsync<T>(this DbContext context, string query, object parameters)
        {
            DbConnection connection = context.Database.GetDbConnection();
            return await connection.QueryAsync<T>(query, parameters);
        }

        public static async Task<int> ExecuteAsync(this DbContext context, string command, object parameters)
        {
            DbConnection connection = context.Database.GetDbConnection();
            return await connection.ExecuteAsync(command, parameters);
        }

        public static async Task<T> QuerySingle<T>(this DbContext context, string query, object parameters)
        {
            DbConnection connection = context.Database.GetDbConnection();
            return await connection.QuerySingleAsync<T>(query, parameters);
        }
    }
}
