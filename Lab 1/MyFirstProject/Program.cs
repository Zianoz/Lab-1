using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Pakapol (Zian) Pathumthammarong NET24
namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Skapar en integer som heter "number" med värdet 10*/
            int number = 10;

            /*Kollar om number är större än 10 och skriver ut texten om den är det*/
            if (number > 10)
            {
                Console.Write("Talet är stort!");

            }

            /*Om number inte är större än 10 skriver den ut texten*/
            else {

                Console.Write("Oj. Lågt Tal!\n");

            }

            /*Frågar om användarens namn och sparar stringen till userName och printar sedan ut Texten + stringen*/
            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Hej! " + userName);

            /*Kollar om int i är mindre eller likamed number. Om ja printar den ut + "1" och loopar tills talet blir = number*/
            for (int i = 0; i <= number ; i++) 
            {
                Console.WriteLine(i);
            }


        }

    }
}
