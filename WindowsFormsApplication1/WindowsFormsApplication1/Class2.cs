using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class2
    {
        public bool IsPrime(int n)
        {
            if(n < 2)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

                return true;
        }
    }
}
