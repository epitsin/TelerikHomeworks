namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class EntryPoint
    {
        public static void Main()
        {
            var data = new OrderedDictionary<Course, SortedSet<Student>>();
            var students = ParseInput();

            foreach (var student in students)
            {
                var currentCourse = new Course(student.Item3);
                var curretnStudent = new Student(student.Item1, student.Item2, currentCourse);

                if (!data.ContainsKey(currentCourse))
                {
                    data[currentCourse] = new SortedSet<Student>();
                }

                data[currentCourse].Add(curretnStudent);
            }

            PrintStudentCourses(data);
        }

        static List<Tuple<string, string, string>> ParseInput()
        {
            using (var reader = new StreamReader("../../data.txt"))
            {
                var students = new List<Tuple<string, string, string>>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var studentInfo = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    students.Add(new Tuple<string, string, string>(studentInfo[0], studentInfo[1], studentInfo[2]));
                }

                return students;
            }
        }

        public static void PrintStudentCourses(OrderedDictionary<Course, SortedSet<Student>> data)
        {
            foreach (var course in data)
            {
                Console.WriteLine(course.Key.Name);

                foreach (var student in course.Value)
                    Console.WriteLine(" - {0}", student.FirstName + " " + student.LastName);

                Console.WriteLine();
            }
        }
    }
}
