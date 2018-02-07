namespace _420JV4AS_TP3
{
    class Room
    {
        public string name;
        public Room previous;
        public Room next;

        public Room(string name) : this(name, null, null) {}

        public Room(string name, Room next) : this(name, null, next) {}

        public Room(string name, Room previous, Room next)
        {
            this.name = name;
            this.previous = previous;
            this.next = next;
        }

        public static Room CreateDungeon()
        {
            Room room = new Room("A", new Room("B", new Room("C", new Room("D", new Room("E")))));
            for (Room r = room; r.next != null; r = r.next)
            {
                r.next.previous = r;
            }
            return room;
        }
    }
}
