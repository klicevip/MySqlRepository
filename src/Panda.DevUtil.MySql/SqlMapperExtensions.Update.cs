using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{
    public static partial class SqlMapperExtensions
    {
        public static async Task UpdateAsync<T>(this IDbConnection connection, T entity, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static void Update<T>(this IDbConnection connection, T entity, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static async Task UpdateFieldsAsync<T>(this IDbConnection connection, dynamic id, object updateFields, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static void UpdateFields<T>(this IDbConnection connection, dynamic id, object updateFields, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static async Task<int> UpdateFieldsWithFilterAsync<T>(this IDbConnection connection, Filter filter, object updateFields, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static int UpdateFieldsWithFilter<T>(this IDbConnection connection, Filter filter, object updateFields, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
