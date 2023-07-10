using LikeList;

class LinkedList
{
    Node head;

    public LinkedList()
    {
        head = null;
    }

    //Add new element at the end of the list
    public void push_back(int newElement)
    {
        Node newNode = new Node();
        newNode.data = newElement;
        newNode.next = null;
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = new Node();
            temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = newNode;
        }
    }

    //Inserts a new element at the given position
    public void push_at(int newElement, int position)
    {
        Node newNode = new Node();
        newNode.data = newElement;
        newNode.next = null;

        if (position < 1)
        {
            Console.Write("\nposition should be >= 1.");
        }
        else if (position == 1)
        {
            newNode.next = head;
            head = newNode;
        }
        else
        {

            Node temp = new Node();
            temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                if (temp != null)
                {
                    temp = temp.next;
                }
            }

            if (temp != null)
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }
            else
            {
                Console.Write("\nThe previous node is null.");
            }
        }
    }

    //display the content of the list
    public void PrintList()
    {
        Node temp = new Node();
        temp = this.head;
        if (temp != null)
        {
            Console.Write("The list contains: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }
}