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
            Node newNode = new Node();
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

    }
}