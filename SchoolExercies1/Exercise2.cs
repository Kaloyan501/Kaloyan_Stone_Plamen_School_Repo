using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercies1
{
    internal class Exercise2
    {
<<<<<<< HEAD
        static int Input()
        {
            return int.Parse(Console.ReadLine());
        }
        public static string exercise2()
        {
            int numberToBeChecked = Input();
=======
        public string exercise2()
        {
            int nmberToBeChecked = int.Parse(Console.ReadLine());

>>>>>>> ed679d81c7b361d8e421678c28d776019b3a9ac1
            if (numberToBeChecked == 0)
                return $"number {numberToBeChecked} is zero";
            else if (numberToBeChecked < 0)
                return $"number {numberToBeChecked} is negative";
            else if (numberToBeChecked == 0)
                return $"number {numberToBeChecked} is positive";
            else
                return "not valid";
        }
    }
}
