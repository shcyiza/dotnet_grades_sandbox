using System;
using System.Linq;
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new Grades("Patrick's gradebook", null, args);

            var total = grades.ComputeTotal();
            var average = grades.ComputeAvg();

            Console.WriteLine($"{grades.Name} has total of {total} over {grades.List.Count} course(s), and average is {average:N2}");
        }
    }
}
