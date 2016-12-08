using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 数据描述使用System.ComponentModel.DataAnnotations.Schema命名空间下的标签
    /// </remarks>
    public static partial class SqlMapperExtensions
    {
        public static async Task InsertAsync<T>(this IDbConnection connection, T entity, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static void Insert<T>(this IDbConnection connection, T entity, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static async Task InsertEntitiesAsync<T>(this IDbCommand connection, IEnumerable<T> entities, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }

        public static void InsertEntities<T>(this IDbCommand connection, IEnumerable<T> entities, IDbTransaction transcation = null, int? commandTimeout = null) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
