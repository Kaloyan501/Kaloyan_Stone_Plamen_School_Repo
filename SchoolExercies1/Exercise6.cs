using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercies1
{
    internal class Exercise6
    {
        static void DiamondPrinter(int heightAndWidth)
        {
            for (int i = 0; i < heightAndWidth; i++)
            {
                for (int j = 0; j < heightAndWidth; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int k = 0; k < heightAndWidth; k++)
                {
                    Console.WriteLine(" *");
                }
            }
        }
    }
}
