using System;
using System.Linq;
using System.Collections.Generic;

namespace gradebook {
    public class Grades
    {
        // getters & setter
        public List<double> List
        {
            get
            {
                return list;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // constuctor
        public Grades(string name, double[] doubles, string[] console_args)
        {
            this.name = name;
            console_args = console_args ?? new string[] {};
            doubles = doubles ?? new double[] {};

            if (doubles.Length > 0)
            {
                doubles.ToList().ForEach(elt => AddGrade(elt));
            }

            if (console_args.Length > 0)
            {
                AddGradesFromStingArray(console_args);
            }
        }

        // state management logic
        public void AddGrade (double new_grade)
        {
            if(new_grade >= 0 && new_grade <= 100)
            {
                list.Add(new_grade);
            }
            else
            {
                Console.WriteLine($"{new_grade} is not 0 >= x >= 100");
            }
        }

        public void AddGradesFromStingArray(string[] string_arr)
        {
            string_arr.ToList().ForEach(elt => AddGrade(double.Parse(elt)));
        }

        // statistics
        public double ComputeTotal()
        {
            return list.Sum();
        }

        public double ComputeAvg()
        {
            return list.Average();
        }

        public double ComputeMin()
        {
            return list.Min();
        }

        public double ComputeMax()
        {
            return list.Max();
        }
        // private fields
        string name;
        List<double> list = new List<double>();

    }
}
