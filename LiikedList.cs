using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LikedList
    {
        private Node head;
        public LikedList() 
        {
            head = null;
        }

        public void Insert (int data)
        {
            Node newNode = new Node(data);

            //1. Empty Liked List . Head is Null
            if(head == null)
            {
                head = newNode;
            }

            //2.When item is added at tthe end.
            else
            {
                Node currentNode = head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode; 
            }
        }

        public void Delete (int data)
        {
            //1. Head is null
            if(head == null)
            {
                Console.WriteLine("linked list is empty.");
            }

            //2.Head is not null
            else
            {
                if(head.data == data) 
                {
                    head = head.next; 
                }

                else
                {
                    Node currentNode = head;
                    Node preNode = null;
                    while(currentNode.next != null && currentNode.data != data)
                    {
                        
                        preNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    if(currentNode == null)
                    {
                        Console.WriteLine("Data not found in the liked list");

                    }
                    preNode.next = currentNode.next;
                }
            }
        }
        
      
        public void Dispaly()
        {
            Node node = head;
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        
    }
}
