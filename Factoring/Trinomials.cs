using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factoring
{
    struct Factor
    {
        public int one, two;

        public Factor(int x, int y)
        {
            one = x;
            two = y;
        }
    }

    class Trinomials
    {
        static List<Factor> calculateFactors(int num)
        {
            List<Factor> factors = new List<Factor>();

            for (int x = -Math.Abs(num); x <= Math.Abs(num); ++x)
            {
                for (int y = -Math.Abs(num); y <= Math.Abs(num); ++y)
                {
                    if (x * y == num)
                    {
                        factors.Add(new Factor(x, y));
                        break;
                    }
                }
            }

            return factors;
        }

        public static string calculateTrinomial(int a, int b, int c)
        {
            List<Factor> aFactors = calculateFactors(a), cFactors = calculateFactors(c);

            Factor factorOne = new Factor(), factorTwo = new Factor();

            foreach (Factor aFactor in aFactors)
            {
                foreach (Factor cFactor in cFactors)
                {
                    if (aFactor.one * cFactor.two + cFactor.one * aFactor.two == b)
                    {
                        factorOne = aFactor;
                        factorTwo = cFactor;
                        break;
                    }
                }
            }

            string A = a.ToString(), B = b.ToString();
            string oneOne = factorOne.one.ToString(), oneTwo = factorOne.two.ToString(), twoOne = factorTwo.one.ToString(), twoTwo = factorTwo.two.ToString();
            string text;

            //Make function to make a string for addition/subtraction?

            text = (a != 1 ? a != -1 ? A : "-" : "") + "x^2" + (b > 0 ? (b != 1 ? " + " + B + "x" : " + x") : (b < 0 ? (b != -1 ? " " + B + "x" : " - x") : "")) + (c >= 0 ? " + " + c : " " + c);
            if (factorOne.one == 0 || factorOne.two == 0 || factorTwo.one == 0 || factorTwo.two == 0)
                text += " cannot be factored.";
            else
            {
                text += " = (" + (factorOne.one != 1 ? factorOne.one != -1 ? oneOne : "-" : "") + "x" + (factorTwo.one >= 0 ? " + " + twoOne : " " + twoOne) + ")(" + (factorOne.two != 1 ? factorOne.two != -1 ? oneTwo : "-" : "") + "x" + (factorTwo.two >= 0 ? " + " + twoTwo : " " + twoTwo) + ")";
            }

            return text;
        }
    }
}
