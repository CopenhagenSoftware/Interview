using System;

namespace InterviewCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John");
            Console.WriteLine(p.Name);
        }
    }

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public Person Sibling1 => new Person("Some sibling");
        public Person Sibling2 { get; } = new Person("Some other sibling");
    }
}
