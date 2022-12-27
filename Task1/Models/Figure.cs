using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    static class Figure
    {
        public static string Add(string a, string b)
        {
            return a += b;
        }

        public static double Operation(double a, double b, string s)
        {
            if (s == "+")
            {
                return (a + b);
            }
            else if (s == "-")
            {
                return (a - b);
            }
            else if (s == "*")
            {
                return (a * b);
            }
            else if (s == "/")
            {
                return (a / b);
            }
            else
                return b;

        }
        public static double OperationProc(double a, double b, string s)
        {
            if (s == "+")
            {
                return (a + (a/100*b));
            }
            else if (s == "-")
            {
                return (a - (a / 100 * b));
            }
            else if (s == "*")
            {
                return (a * b/100);
            }
            else if (s == "/")
            {
                return (a /( b/100));
            }
            else
                return b;

        }
    }
}
