namespace Lab7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            while(input != 3)
            {
                Console.WriteLine("What would you like to do?\n" +
                    "\t[0]: Add an item at the beginning of the list\n" +
                    "\t[1]: Add an item at the end of the list\n" +
                    "\t[2]: Print out the contents of the list\n" +
                    "\t[3]: Exit the program");
                input = Convert.ToInt16(Console.ReadLine());

                switch(input)
                {
                    case 0:
                        Console.Write("Value of item: ");
                        int valueInput = Convert.ToInt16(Console.ReadLine());
                        list.AddFirst(valueInput);
                        break;
                    case 1:
                        Console.Write("Value of item: ");
                        valueInput = Convert.ToInt16(Console.ReadLine());
                        list.AddLast(valueInput);
                        break;
                    case 2:
                        foreach(int i in list)
                        {
                            Console.Write($"{i}, ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        break;
                }
            }
        }
    }
}