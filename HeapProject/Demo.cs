using System;
using System.Collections.Generic;
using System.Text;

namespace HeapProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            Heap h= new Heap(20);

            int choice, value;

            while (true)
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Delete Root");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("5.Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        h.Insert(value);
                        break;
                    case 2:
                        Console.WriteLine("Maximum Value is:"+h.DeleteRoot());
                        break;
                    case 3:
                        h.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
