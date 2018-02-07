// Nom ici

using System;

namespace _420JV4AS_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question1a(7));
            //Console.WriteLine(Question1a(20));
            //Console.WriteLine(Question1b("bonk"));
            //Console.WriteLine(Question1b("alucard"));
            //Print(Question2a(Room.CreateDungeon(), 2));
            //Print(Question2a(Room.CreateDungeon(), 0));
            //Print(Question2b(Room.CreateDungeon()));
            //Print(Question2c(Room.CreateDungeon()));
            Console.Read();
        }

        static int Question1a(int n)
        {
            return 0;
        }

        static string Question1b(string s)
        {
            return s;
        }

        static Room Question2a(Room startingRoom, int n)
        {
            return startingRoom;
        }

        static Room Question2b(Room startingRoom)
        {
            return startingRoom;
        }

        static Room Question2c(Room startingRoom)
        {
            return startingRoom;
        }

        static void Print(Room startingRoom)
        {
            for (Room r = startingRoom; r != null; r = r.next)
            {
                Console.Write("-[{0}]", r.name);
            }
            Console.WriteLine();
        }
    }
}
