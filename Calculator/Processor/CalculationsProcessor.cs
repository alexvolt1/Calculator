using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Processor
{
    public class CalculationsProcessor : ICalculationsProcessor
    {
        public double TempResult { get; set; }
        public double AddMethod(string inputString, int i)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }
            else
            {
                TempResult += Convert.ToDouble(inputString);
                return TempResult;
            }
        }
        public double SubtractMethod(string inputString, int i)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }
            else
            {
                if (i == 0)
                {
                    TempResult = Convert.ToDouble(inputString);
                }
                else
                {
                    TempResult -= Convert.ToDouble(inputString);
                }
                return TempResult;
            }
        }

        public double MultiMethod(string inputString, int i)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }
            else
            {
                if (i == 0)
                {
                    TempResult = Convert.ToDouble(inputString);
                }
                else
                {
                    TempResult *= Convert.ToDouble(inputString);
                }
                return TempResult;
            }
        }

        public double DivMethod(string inputString, int i)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }
            else
            {
                if (i == 0)
                {
                    TempResult = Convert.ToDouble(inputString);
                }
                else
                {
                    TempResult /= Convert.ToDouble(inputString);
                }
                return TempResult;
            }
        }
    }
}
