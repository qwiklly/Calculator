using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalculator
{
    public class Calculator
    {
        public string HandleCE()
        {
            return "";
        }

        public string HandleC()
        {
            return "";
        }

        public string HandleBackspace(string Text)
        {
            if (Text.Length > 0)
            {
                return Text.Substring(0, Text.Length - 1);
            }
            return Text;
        }

        public string HandleNegative(string Text)
        {   if (Text.Length > 0)
            {
                double value1 = (-1) * double.Parse(Text);
                return value1.ToString();
            }
        return Text;
        }
        public string HandlePow(string Text)
        {
            double value1 = Math.Pow(double.Parse(Text), 2);
            return value1.ToString();
        }

        public string HandleInverse(string Text)
        {
            double value1 = 1 / double.Parse(Text);
            return value1.ToString();
        }

        public string HandleSqrt(string Text)
        {
            double value1 = Math.Sqrt(double.Parse(Text));
            return value1.ToString();
        }
 
        public string HandleEquals(string Text)
        {


            try
            {

                if (Text.Contains("x"))
                {
                    string[] values = SplitIntoTwo(Text, 'x');
                    double result = Double.Parse(values[0]) * Double.Parse(values[1]);
                    return result.ToString();

                }
                else if (Text.Contains("÷"))
                {
                    string[] values = SplitIntoTwo(Text, '÷');
                    double result = Double.Parse(values[0]) / Double.Parse(values[1]);
                    return result.ToString();
                }
                else if (Text.Contains("%"))
                {
                    string[] values = SplitIntoTwo(Text, '%');
                    double result = Double.Parse(values[0]) * Double.Parse(values[1]) / 100;
                    return result.ToString();
                }
                else if (Text.Contains("+"))
                {
                    string[] values = SplitIntoTwo(Text, '+');
                    double result = Double.Parse(values[0]) + Double.Parse(values[1]);
                    return result.ToString();
                }
                else if (Text.Contains("-"))
                {
                    string[] values = SplitIntoTwo(Text, '-');
                    double result = Double.Parse(values[0]) - Double.Parse(values[1]);
                    return result.ToString();

                }
            }
            catch { return "error"; }
            return "";
        }

        
        private string[] SplitIntoTwo(string Text, char calculationMethod)
        {
            return Text.Split(calculationMethod);
        }



    }
}

