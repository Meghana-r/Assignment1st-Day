using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Info
    {
        string fname;
        string lname;
        string email;
       
        public Info()
        {
            Console.WriteLine("Enter your first name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lname = Console.ReadLine();
            Console.WriteLine("Enter your email");
            email = Console.ReadLine();
           
           
        }
        public Info(string firstname, string lastname, string email)
        {
            Console.WriteLine("Enter your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter your email");
            email = Console.ReadLine();


        }

        public Info(string firstname, string lastname)
        {
            Console.WriteLine("Enter your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter your dob");
            
        }
        public void Age()
        {
            Console.WriteLine("Enter your dob");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            dob = DateTime.Parse(dob.ToString("dd-MM-yyyy"));
            DateTime n = DateTime.Now;
            int age = n.Year - dob.Year;
            if (n.Month < dob.Month || (n.Month == dob.Month && (n.Day < dob.Day)))

                age--;
            Console.WriteLine("The age is" + age);
            if (age >= 18)

                Console.WriteLine("Adult");


            else

                Console.WriteLine("Minor");


            if (n.Date == dob.Date && n.Month == dob.Month)

                Console.WriteLine("Happy Birthday");

            switch (dob.Month)
            {
                case 1:Console.WriteLine("Capricorn");
                    break;
                case 2:
                    Console.WriteLine("Aquarius");
                    break;
                case 3:
                    Console.WriteLine("Pisces");
                    break;
                case 4:
                    Console.WriteLine("Aries");
                    break;
                case 5:
                    Console.WriteLine("Taurus");
                    break;
                case 6:
                    Console.WriteLine("Gemini");
                    break;
                case 7:
                    Console.WriteLine("Cancer");
                    break;
                case 8:
                    Console.WriteLine("leo");
                    break;
                case 9:
                    Console.WriteLine("Virgo");
                    break;
                case 10:
                    Console.WriteLine("Libra");
                    break;
                case 11:
                    Console.WriteLine("Scorpio");
                    break;
                case 12:
                    Console.WriteLine("Sagittarius");
                    break;
            }
        }
    }
}
           
    
   

       