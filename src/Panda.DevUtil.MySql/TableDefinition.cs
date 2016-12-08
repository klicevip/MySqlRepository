using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{
    /// <summary>
    /// 表定义
    /// </summary>
    public class TableDefinition
    {
        /// <summary>
        /// 实体类型
        /// </summary>
        public Type EntityType { get; set; }
        /// <summary>
        /// 表名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 列
        /// </summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        public ColumnDefinition PrimaryColumn { get; set; }
    }
}
