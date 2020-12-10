using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
            public static void LogIn()
            {
                Console.Title = "Welcome User";
                Console.WriteLine("");
                Console.WriteLine("[1] For Customer Log-in ");
                Console.WriteLine("[2] For Admin Log-in");
                Console.WriteLine("[0]Exit the online shop.");

                Console.WriteLine("Pick one option:");
                string Input = Console.ReadLine();

                if (Input == "1")
                {
                     Console.WriteLine("USERNAME:");
                     Console.ReadLine();
                     Console.WriteLine("PASSWORD:");
                     Console.ReadLine();
                     Console.Clear();
                     AppManager.DisplayMenu();
                }
                else if (Input == "2")
                {
                     Console.WriteLine("USERNAME:");
                     Console.ReadLine();
                     Console.WriteLine("PASSWORD:");
                     Console.ReadLine();
                     Console.Clear();
                     AdminPage.Displaymenu();
                }
                else if (Input == "0")
                {
                     Environment.Exit(0);
                }
            }
        }
}
