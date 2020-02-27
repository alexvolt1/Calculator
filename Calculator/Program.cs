using Calculator.Processor;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For addition press +");
            Console.WriteLine("For subtraction press –");
            Console.WriteLine("For multiplication press *");
            Console.WriteLine("For division press /");
            ICalculationsProcessor processor = new CalculationsProcessor();
            //MathOperation mathOperation = processor.AddMethod;
            Func<string, int, double> mathFunc = processor.AddMethod;
            Char key = Console.ReadKey().KeyChar;


            if (key.Equals('+'))
            {
                //mathOperation = processor.AddMethod;
                mathFunc = processor.AddMethod;
            }
            else if (key.Equals('-'))
            {
                //mathOperation = processor.SubtractMethod;
                mathFunc = processor.SubtractMethod;
            }
            else if (key.Equals('*'))
            {
                //mathOperation = processor.MultiMethod;
                mathFunc = processor.MultiMethod;
            }
            else if (key.Equals('/'))
            {
                //mathOperation = processor.DivMethod;
                mathFunc = processor.DivMethod;
            }

            int i = 0;
            while (true)
            {
                Console.WriteLine("Please Enter the Number");

                string inputString = Console.ReadLine();
                if (inputString.Contains("="))
                {
                    break;
                }
                //mathOperation(inputString, i);
                mathFunc(inputString, i);

                //Console.WriteLine("Result: {0}", processor.TempResult);
                i++;
            }
            Console.WriteLine("Result: {0}", processor.TempResult);


        }
    }
}
