using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Each child class can be replaced by its parent
    internal class Liskov
    {

        static void Main()
        {
            Chair C1 = new OfficeChair();
            C1.GetColor();
        }


    }

    abstract class Chair
    {
        public abstract void GetColor();
    }

    class OfficeChair : Chair
    {
        public override void GetColor()
        {
            Console.WriteLine("Purple");
        }
    }


}
