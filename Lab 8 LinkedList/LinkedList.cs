using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_LinkedList
{
    public class LinkedList
    {
        //List count
        public int Count = 0;

        public Node Head;
        public LinkedList() 
        { 
        }
        // Method to add a node with the given value to the beginning of the linked list
        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.next = Head;
            Head = newNode;
            Count++;
        }
        // Method to add a node with the given value to the end of the linked list
        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            Node CurrentNode = Head;

            //Checks if Head is null
            if (Head == null)
            {
                Head = newNode;
                Count++;

                //Exiting method after excuted
                return;
            }

            //Checks every node in the list until the end then adds node to it
            while(CurrentNode.next != null)
            {
                CurrentNode = CurrentNode.next;
            }
            CurrentNode.next = newNode;    
            //Increase count
            Count++;
        }
        //Removes the first node in the list
        public void RemoveFirst()
        {

            if (Head != null)
            {
                Head = Head.next;
                Count--; //Decrements count 
            }
        }

        //Removes the last node of the list
        public void RemoveLast()
        {
            //Checks if list is empty
            if (Head == null)
            {
                return;
            }
            //Checks if there is only one node on the list
            if (Head.next == null)
            {
                Head = null;

                //Decrements count
                Count--;
                return;
            }
            //For list that has more than one node
            //Loops to check next.next until it has hit the last node then deletes that node
            
            Node temp1 = Head;
            
            while (temp1.next.next != null)
            {
                temp1 = temp1.next;
            }
            temp1.next = null;
            Count--;
        }
        //Gets value at certain index 
        public string GetValue(int index)
        {
            //Checks if the index value is out of range 
            if (index < 0 || index >= Count)
            {
                return "Out of Range";
            }
            //Loops through the list until Currentkey matches the index value inputted
            Node currentKey = Head;
            int initialIndex = 0;
            while(currentKey != null)
            {

                if(initialIndex == index)
                {
                   return currentKey.data; //returns the information of that Object
     
                }
                currentKey = currentKey.next;
                initialIndex++; 
            }
            return "Error";

        }
    }
}
