using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            char transacttype;


           Console.WriteLine("Do you want to withdraw or deposit(d/w)");
            transacttype = char.Parse(Console.ReadLine());
            Accounting ac = new Accounting();

            if (transacttype == 'd')
               ac.Deposit();

           else
               ac.Withdraw();

            ac.display();
            Shapes S = new Shapes();
            S.area(5);
            S.area(5, 10);
            S.area(90);
            S.area(6, 9);

            Info i= new Info();
            i.Age();


        }
    }
}

