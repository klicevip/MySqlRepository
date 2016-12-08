using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{
    public class MySqlRepository
    {
        public string ConnectionString { get; private set; }

        public MySqlConnection NewConnection
        {
            get
            {
                return new MySqlConnection(ConnectionString);
            }
        }

        public MySqlRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
