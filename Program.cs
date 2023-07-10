

internal class Program
{
    public static void Main(string[] args)
    {

        //LinkedList list = new LinkedList();

        //list.push_at(40, 1);
        //list.push_at(30, 2);
        //list.push_at(60, 3);

        //list.PrintList();

        //list.push_at(600, 3);
        //list.PrintList();

        //list.push_back(20);
        //list.PrintList();
        

        //likedList.Insert(70);
        
        


        //likedList.Delete(20);
        //likedList.Delete(30);
        //likedList.Delete(60);
        //Console.WriteLine("After Deleting");
        //likedList.Dispaly();
        //Console.WriteLine("Hello, World!");

        LinkedList<int> list = new LinkedList<int>();
        LinkedListNode<int> node1 = new LinkedListNode<int>(10);
        LinkedListNode<int> node2 = new LinkedListNode<int>(30);
        LinkedListNode<int> node3 = new LinkedListNode<int>(50);
        LinkedListNode<int> node4 = new LinkedListNode<int>(100);

        list.AddLast(node1);
        list.AddLast(node2);
        list.AddAfter(node3, node2);
        list.AddBefore(node1, node3);

        foreach(int i in list)
        {
            Console.WriteLine(i);
        }

    }
}