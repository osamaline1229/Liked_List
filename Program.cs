

internal class Program
{
    public static void Main(string[] args)
    {

        LinkedList list = new LinkedList();

        list.push_at(40, 1);
        list.push_at(30, 2);
        list.push_at(60, 3);

        list.PrintList();

        list.push_at(600, 3);
        list.PrintList();

        list.push_back(20);
        list.PrintList();
        

        //likedList.Insert(70);
        
        


        //likedList.Delete(20);
        //likedList.Delete(30);
        //likedList.Delete(60);
        //Console.WriteLine("After Deleting");
        //likedList.Dispaly();
        //Console.WriteLine("Hello, World!");
    }
}