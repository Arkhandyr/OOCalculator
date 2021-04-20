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
            Calculator calculator1 = new Calculator();
            calculator1.firstNumber = 3;
            calculator1.secondNumber = 5;
            
            calculator1.Add();
            calculator1.Sub();
            calculator1.Multiple();
            calculator1.Division();

            Console.WriteLine(calculator1.operationHistory);
            Console.ReadLine();
        }

    }
}
