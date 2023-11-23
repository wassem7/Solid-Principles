using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class DependencyInversion1
    {
        static void main()
        {
            Bank Calbank = new Bank();
            Calbank.AtmOperation();
            Customer Person = new Customer();
            Person.AtmOperation();
        }
    }

    interface IATM
    {
        void AtmOperation();
    }
    class Bank : IATM
    {
        public void AtmOperation()
        {
            Console.WriteLine("Pushing money to ATM...");
        }
    }

    class Customer : IATM
    {
        public void AtmOperation()
        {
            Console.WriteLine("Withdrawing money...");
        }

    }
}
