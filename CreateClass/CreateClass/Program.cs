using System;

namespace CreateClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var barna = new Person("Barna", new DateTime(1996, 1, 2), Gender.Male);
            var diana = new Person("Diana", DateTime.Now, Gender.Female);
            Console.WriteLine(barna.ToString());
            Console.WriteLine(diana.ToString());
            Console.ReadLine();
        }
    }
}