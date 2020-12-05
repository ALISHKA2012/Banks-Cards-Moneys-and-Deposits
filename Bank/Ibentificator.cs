using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Ibentificator<T>
    {
        private static int _counter;
        static Ibentificator()
        {
            _counter = 0;
        }
        public static int GetId()
        {
            _counter++;
            return _counter;
        }
    }
}
