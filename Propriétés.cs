using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();
            house.AddDoor(houseDoor);
            room.AddDoor(roomDoor);
            house.AddRoom(room);
        }
    }

    public class House
    {
        public List<Room> rooms { set; get; }
        public List<Door> doors { set; get; }

        public House()
        {
            rooms = new List<Room>();
            doors = new List<Door>();
        }

        public void AddDoor(Door door)
        {
            doors.Add(door);
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
    }

    public class Room
    {
        public List<Door> doors 
        {
            get;
        }

        public Room()
        {
            doors = new List<Door>();
        }

        public void AddDoor(Door door)
        {
            doors.Add(door);
        }
    }

    public class Door
    {
        public bool isOpen 
        {
            get;
            set;
        }

        public Door()
        {
            isOpen = false;
        }

        public void Open()
        {
            if (isOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                isOpen = true;
            }
        }

        public void Close()
        {
            if (!isOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                isOpen = false;
            }
        }
    }
}
