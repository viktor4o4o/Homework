﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSON_Stringify
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                string[] inputParams = inputLine.Split(new[] { '-', '>', ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var studentName = inputParams[0];
                var studentAge = int.Parse(inputParams[1]);
                var studentGrades = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();
                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);
               
                inputLine = Console.ReadLine();
            }

            string output = string.Empty;

            output += "[";
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";
                if (i < students.Count-1)
                {
                    output += ",";
                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
