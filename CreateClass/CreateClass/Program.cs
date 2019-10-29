using System;

namespace CreateClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var barna = new Person("Barna", new DateTime(1996, 1, 2), Gender.Male);
            var diana = new Person("Diana", DateTime.Now, Gender.Female);
            var room202 = new Room(202);
            var employee = new Employee("Barna", DateTime.Now, Gender.Male, 1000, "coder", room202);
            Console.WriteLine(barna.ToString());
            Console.WriteLine(diana.ToString());
            Console.WriteLine(employee.ToString());
            Console.ReadLine();
        }
    }
}