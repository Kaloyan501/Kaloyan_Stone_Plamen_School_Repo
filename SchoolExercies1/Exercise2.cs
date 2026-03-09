using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercies1
{
    internal class Exercise2
    {
        public string exercise2()
        {
            int numberToBeChecked = int.Parse(Console.ReadLine());

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
