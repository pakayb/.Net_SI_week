using System;

namespace CreateClass
{
    public class Employee : Person
    {
        private int Salary { get; }
        private string Profession { get; }
        private Room Room { get; }

        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession, Room room) : base(name,
            birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
            Room = room;
        }

        public override string ToString()
        {
            return base.ToString() + " | " + "Profession: " + Profession + " | " + "Salary: " + Salary +" | " + "Room: " + Room.RoomNumber;
        }
    }

    public class Room
    {
        public int RoomNumber { get; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }

}