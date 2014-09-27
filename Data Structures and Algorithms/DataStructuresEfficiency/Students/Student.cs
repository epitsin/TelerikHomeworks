namespace Students
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName, Course course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Course = course;
        }

        public string FirstName { get; set; }

        public string LastName { get; private set; }

        public Course Course { get; set; }

        public int CompareTo(Student other)
        {
            var compare = this.LastName.CompareTo(other.LastName);

            if (compare == 0)
                compare = this.FirstName.CompareTo(other.FirstName);

            return compare;
        }
    }
}
