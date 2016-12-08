using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{
    public static partial class SqlMapperExtensions
    {
        public static async Task<T> FindOneOrDefaultAsync<T>(this IDbConnection connection, dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static T FindOneOrDefault<T>(this IDbConnection connection, dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static async Task<IEnumerable<T>> FindAsync<T>(this IDbConnection connection, Filter filter = null, string[] selectFields = null, string[] orderByFileds = null, bool? orderbyDesc = null, int? skip = null, int? limit = null, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Find<T>(this IDbConnection connection, Filter filter = null, string[] selectFields = null, string[] orderByFileds = null, bool? orderbyDesc = null, int? skip = null, int? limit = null, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static async Task<int> CountAsync<T>(this IDbConnection connection, Filter filter = null, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static int Count<T>(this IDbConnection connection, Filter filter = null, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
