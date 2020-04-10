using System;
using System.Net.Http;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              
                   // fara methods
                
                   Console.WriteLine("The Name Game !");

                   Console.WriteLine("Enter your First Name: ");
                   string firstName = Console.ReadLine();

                   Console.WriteLine("Enter your Last Name: ");
                   string lastName = Console.ReadLine();

                   Console.WriteLine("In what city are you born: ");
                   string city = Console.ReadLine();


                   char[] firstNameArray = firstName.ToCharArray();
                   Array.Reverse(firstNameArray);

                   char[] lastNameArray = lastName.ToCharArray();
                   Array.Reverse(firstNameArray);

                   char[] cityArray = city.ToCharArray();
                   Array.Reverse(firstNameArray);

                   string result = " ";

                   foreach (char item in firstNameArray)
                   {
                       result += item;
                   }
                   result += " ";

                   foreach (char item in lastNameArray)
                   {
                       result += item;
                   }
                   result += " ";

                   foreach (char item in city)
                   {
                       result += item;
                   }
                   result += " ";

                   Console.WriteLine("Result: " + result);
                   Console.ReadLine();

            */
            Console.WriteLine("The Name Game !");

            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city are you born: ");
            string city = Console.ReadLine();

            Console.Write("Result: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();
        }
         // methods
        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }

    }
}

