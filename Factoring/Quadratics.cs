using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factoring
{
    struct Quadratic
    {
        public string text;
        public decimal a, b, h, k;

        public Quadratic(string Text, decimal A, decimal B, decimal H, decimal K)
        {
            text = Text;
            a = A;
            b = B;
            h = H;
            k = K;
        }
    }

    class Quadratics
    {
        struct Root
        {
            public decimal one, two;
            public string iOne, iTwo;
            public bool imaginary;
        }

        const string format = "0.####";

        static Root calculateRoots(decimal a, decimal b, decimal c)
        {
            //x = (-b +- sqrt(b^2 - 4ac)) / 2a
            Root roots = new Root();

            decimal discriminant = (b * b) - (4 * a * c);

            roots.imaginary = discriminant < 0;

            if (roots.imaginary)
            {
                roots.iOne = "(" + (b != 0 ? (-b).ToString(format) + " + " : "") + "i * sqrt(" + -discriminant + ")) / (" + 2 * a + ")";
                roots.iTwo = "(" + (b != 0 ? (-b).ToString(format) + " - ": "") + "i * sqrt(" + -discriminant + ")) / (" + 2 * a + ")";
            }
            else
            {
                roots.one = (-b + (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
                roots.two = (-b - (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
            }

            return roots;
        }

        public static Quadratic calculateQuadratic(decimal a, decimal b, decimal c)
        {
            decimal bNew = b / a, h = bNew / 2, k = (-a * h * h + c);

            Root roots = calculateRoots(a, b, c);

            string A = a.ToString(format), B = bNew.ToString(format), H = h.ToString(format), K = k.ToString(format);

            //Make function to make a string for addition/subtraction?

            string text;
            text = "Standard form: y = " + (a != 1 ? a != -1 ? A : "-" : "") + "x^2" + (b > 0 ? (b != 1 ? " + " + b + "x" : " + x") : (b < 0 ? (b != -1 ? " " + B + "x" : " - x") : "")) + (c >= 0 ? " + " + c : " " + c) + "\n";
            text += "Vertex form: y = " + (a != 1 ? a != -1 ? A : "-" : "") + (h > 0 ? "(x + " + H + ")" : h < 0 ? "(x " + H + ")" : "x") + "^2" + (k > 0 ? " + " + K : k < 0 ? " " + K : "") + "\n";
            text += "Vertex: (" + (-h).ToString(format) + ", " + K + ")\n";
            text += (a > 0 ? "Min" : "Max") + " of " + K + " when x = " + (-h).ToString(format) + "\n";
            text += "Root(s):\n";
            if (roots.imaginary)
                text += roots.iOne + "\n" + roots.iTwo;
            else
                text += (roots.one == roots.two ? roots.one.ToString(format) : roots.one.ToString(format) + "\n" + roots.two.ToString(format));

            Quadratic quad = new Quadratic(text, a, bNew, h, k);

            return quad;
        }
    }
}