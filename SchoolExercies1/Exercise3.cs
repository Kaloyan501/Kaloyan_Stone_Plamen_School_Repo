using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercies1
{
    internal class Exercise3
    {
        public static void exercise3() {
            int triangleheight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleheight; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int f = triangleheight; f > 0; f--)
            {
                for (int g = 1; g < f; g++)
                {
                    Console.Write(g);
                }
                Console.WriteLine();
            }
        }
    }
}
