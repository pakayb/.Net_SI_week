using System;

namespace CreateClass
{
    class Person
    {
        protected string Name { get; }
        protected DateTime BirthDate { get; }
        protected Gender Gender { get; }

        public Person(string name, DateTime birthDate, Gender gender)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | " +"Gender: " + Gender + " | " + "Birth Date: "+ BirthDate.ToShortDateString();
        }

        static void Main(string[] args)
        {
            var barna = new Person("Barna", new DateTime(1996,1,2),Gender.Male );
            var diana = new Person("Diana", DateTime.Now, Gender.Female);
            Console.WriteLine(barna.ToString());
            Console.WriteLine(diana.ToString());
            Console.ReadLine();
        }


    }
    internal enum Gender
    {
        Male,
        Female,
    }
}
