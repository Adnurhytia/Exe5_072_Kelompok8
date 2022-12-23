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
        Node Front, Rear;

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void Enter()
        {
            string data;
            Node newNode = new Node();
            Console.Write("Masukkan Input: ");
            data = Console.ReadLine();
            newNode.nama = data;
            newNode.next = null;
            if (Front == null)
            {
                Front = newNode;
                Rear = newNode;
                return;
            }
            Rear.next = newNode;

        }
        public void Delete()
        {
            if (Front == null)
            {
                Console.WriteLine("Tidak ada data didalam antrian");
                return;
            }
            Console.WriteLine("Data yang dihapus " + Front.nama);
            Console.ReadKey();
            Front = Front.next;
            if (Front == null)
                Rear = null ;
        }
    }
}