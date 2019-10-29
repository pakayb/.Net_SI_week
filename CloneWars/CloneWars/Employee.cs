using System;

namespace CloneWars
{
    public class Employee : Person, ICloneable
    {
        private int Salary { get; }
        private string Profession { get; }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession) : base(name,
            birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + " | " + "Profession: " + Profession + " | " + "Salary: " + Salary +" | " + "Room: " + Room.RoomNumber;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Room
    {
        public int RoomNumber { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }

}