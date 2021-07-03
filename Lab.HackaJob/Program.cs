using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab.HackaJob
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //var unsortedInput = "11 5 7 3 8 1 9";
            string unsortedInput = null;
            //var result = test.Split(" ");

            //var stringList = test.Split(' ').OrderBy(x => x).ToArray();

            //var result1 = String.Join(" ", stringList);


            var unsortedList = unsortedInput?.Split(' ').OrderBy(x => Convert.ToInt32(x)).ToList();
            var sortedOutput = String.Join(" ", unsortedList);

            //var unsortedInput = "11 5 7 3 8 1 9";
            //Regex number = new Regex(@"^\d+");
            //string sortedOutput = string.Join(" ", unsortedInput.Split(' ').OrderBy(x => Convert.ToInt32(number.Match(x).Value)).ThenBy(x => number.Replace(x, "")));


            Console.WriteLine(sortedOutput);
        }
    }
}

//using System;
//using System.Linq;
//using System.Text.RegularExpressions;

//public class Solution
//{
//    static public string Run(string unsortedInput)
//    {
//        //
//        // Write your code below; return type and arguments should be according to the problem's requirements
//        //
//        Regex number = new Regex(@"^\d+");
//        string sortedOutput = string.Join(" ", unsortedInput.Split(' ').OrderBy(x => Convert.ToInt32(number.Match(x).Value)).ThenBy(x => number.Replace(x, "")));
//        return sortedOutput;
//    }
//}