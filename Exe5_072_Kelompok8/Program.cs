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

    }
}