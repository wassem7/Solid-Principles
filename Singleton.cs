using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class Singleton
    {
        static void Main()
        {
            Car car = Car.Instance;
            
        }
    }

    class Car
    {
        private static readonly Car _instance = new Car();
        private int _numberofinstances = 0;
        private Car()
        {
            ++_numberofinstances;
            Console.WriteLine("Number of instances : {0}",_numberofinstances);
        }

        public static Car Instance
        {
            get { return _instance;  }
        }
    }
}
