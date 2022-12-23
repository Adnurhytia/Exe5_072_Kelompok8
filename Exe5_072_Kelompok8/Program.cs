using System;

namespace Exe5_072_Kelompok3
{
    class Node
    {
       
        public string nama;
        public Node next;
        public Node(string i, Node  n)
        {
            nama = i;
            next = n;
        }
    }

    class Queue
    {
        Node Adinda, Nurhayati;

        public Queue()
        {
            Adinda = null;
            Nurhayati = null;
        }

        public void Enter()
        {
            string data;
            Node newNode = new Node("", null);
            Console.Write("Masukkan Input: ");
            data = Console.ReadLine();
            newNode.nama = data;
            newNode.next = null;
            if (Adinda == null)
            {
                Adinda = newNode;
                Nurhayati = newNode;
                return;
            }
            Nurhayati.next = newNode;

        }
        public void Delete()
        {
            if (Adinda == null)
            {
                Console.WriteLine("Tidak ada data didalam antrian");
                return;
            }
            Console.WriteLine("Data yang dihapus " + Adinda.nama);
            Console.ReadKey();
            Adinda = Adinda.next;
            if (Adinda == null)
                Nurhayati = null ;
        }
        public void Display()
        {
            if (Adinda == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian");
                return ;
            }
            Node display;
            for (display = Adinda; display != null; display = display.next)
                Console.WriteLine(display.nama);
            Console.WriteLine("\nTekan 'Enter' untuk melanjutkan Program");
            Console.ReadKey();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("menu");
                    Console.WriteLine("1. Implement Enter operation");
                    Console.WriteLine("2. Implement Delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Console.Clear();
                            q.Enter();
                            break;
                        case '2':
                            Console.Clear();
                            q.Delete();
                            break;
                        case '3':
                            Console.Clear();
                            q.Display();
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Silahkan periksa kembali data yang kamu masukkan!");
                }
            }
        }
    }

}