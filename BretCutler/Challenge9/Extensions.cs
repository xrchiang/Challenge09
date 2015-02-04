using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge9 {

    public static class Extensions {

        public static bool IsFibonacci(this long val) {

            long first = 0;
            long second = 1;
            long fib = first + second;

            while (fib < val) {

                first = second;
                second = fib;
                fib = first + second;
            }

            return fib == val;

        }
    }
}
