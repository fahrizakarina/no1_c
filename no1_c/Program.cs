using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b, c: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation quadraticEquation = new QuadraticEquation(a,b,c);
            Console.WriteLine("The equation has ");
            if (quadraticEquation.getDiscriminant() < 0) 
            {
                Console.WriteLine("no real roots");
            }
            else if (quadraticEquation.getDiscriminant() > 0)
            {
                Console.WriteLine("Two roots " + quadraticEquation.getRoot1() + " and " + quadraticEquation.getRoot2());
            }
            else 
            {
                Console.WriteLine("one root " + (quadraticEquation.getRoot1()>0? quadraticEquation.getRoot1() : quadraticEquation.getRoot2()));
            }
            Console.ReadLine();
        }
    }
}