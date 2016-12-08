using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            long id = 0;
            long loginTime = 1111;
            Filter filter = Filter.Euqal("ID", id) & Filter.Less("loginTime", loginTime);
        }
    }
}
