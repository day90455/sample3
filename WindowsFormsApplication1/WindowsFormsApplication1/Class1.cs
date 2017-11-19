using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public int GetARandowNumber()
        {
            Random r = new Random();
            return r.Next(100);
        }
    }
}
