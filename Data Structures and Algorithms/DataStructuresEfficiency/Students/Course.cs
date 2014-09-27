namespace Students
{
    using System;

    public class Course : IComparable<Course>
    {
        public Course(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public int CompareTo(Course other)
        {
            return string.Compare(this.Name, other.Name, true);
        }
    }
}
