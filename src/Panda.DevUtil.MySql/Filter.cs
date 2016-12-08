using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.DevUtil.MySql
{
    public class Filter
    {
        public string Name { get; set; }

        public int Compare { get; set; }

        public object Value { get; set; }

        public Filter Left { get; set; }

        public Filter Right { get; set; }

        public bool IsAnd { get; set; }

        public static Filter Null
        {
            get { throw new NotImplementedException(); }
        }

        public static Filter operator &(Filter left, Filter right)
        {
            throw new NotImplementedException();
        }

        public static Filter operator |(Filter left, Filter right)
        {
            throw new NotImplementedException();
        }

        public static Filter Euqal(string name, object value)
        {
            throw new NotImplementedException();
        }

        public static Filter Greater(string name, object value)
        {
            throw new NotImplementedException();
        }

        public static Filter Less(string name, object value)
        {
            throw new NotImplementedException();
        }

        public static Filter In(string name, object value)
        {
            throw new NotImplementedException();
        }
    }
}
