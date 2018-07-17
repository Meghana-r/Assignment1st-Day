using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Accounting
    {
        int accntno = 45367;
        string custname = "Meg";
        string accnttype = "CA";
        int amount;
        int balance=5000;
       
               public void Deposit()
        {
            Console.WriteLine("Enter the amount to deposit");
            amount = int.Parse(Console.ReadLine());
            balance = balance + amount;

        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to Withdraw");
            amount = int.Parse(Console.ReadLine());
            balance = balance - amount;

        }
        public void display()
        {
            Console.WriteLine("Name" + custname);
            Console.WriteLine("Account Number:" + accntno);
            Console.WriteLine("Account Type" + accnttype);
            Console.WriteLine("Your new balance is" + balance);


        }

    }
    }



