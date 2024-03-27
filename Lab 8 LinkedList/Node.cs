using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_LinkedList
{
    public class Node
    {
        //Properties
        public string data;
        public Node next;
        public int count;

        public Node(string d) 
        {
            data = d;
            next = null;
        }

    }
}
