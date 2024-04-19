using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniYurt
{
     class Connection
    {
        public string connectionString = System.IO.File.ReadAllText(@"C:\test.txt");
    }
}
