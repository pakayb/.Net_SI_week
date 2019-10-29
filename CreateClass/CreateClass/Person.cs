using System;

namespace CreateClass
{
    public class Person
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

    }

    public enum Gender
    {
        Male,
        Female,
    }
}
