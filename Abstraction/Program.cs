using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Body objBdy = new Body();


            objBdy.color();
            objBdy.abstractMethod();
            objBdy.NormalMethod();


        }
    }
}
