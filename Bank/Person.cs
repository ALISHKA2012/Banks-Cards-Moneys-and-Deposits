using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Person : Entity
    {
        private byte _age;

        public string name { get; set; }
        public string Surname { get; set; }
        public byte Age { get { return _age; } set { _age = value > 0 && value < 90 ? value : (byte)0; } }
    }
}
