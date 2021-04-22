using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int menuSelection;

            Calculator calculator1 = new Calculator();

            while(true)
            {
                Console.WriteLine("##### Object-Oriented Calculator V1.1 #####\n");

                Console.WriteLine("Type the first number");
                calculator1.firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nType the second number");
                calculator1.secondNumber = Convert.ToDouble(Console.ReadLine());

                ShowMenu();
                menuSelection = Convert.ToInt32(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1: calculator1.Add(); break;
                    case 2: calculator1.Sub(); break;
                    case 3: calculator1.Multiple(); break;
                    case 4: calculator1.Division(); break;
                    case 0: Environment.Exit(0); break;
                }

                Console.WriteLine(calculator1.operationHistory);

                Console.WriteLine("\nPress any button to do another operation");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\nPlease, select the desired operation:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Sub");
            Console.WriteLine("3 - Multiple");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit\n");
        }
    }
}
