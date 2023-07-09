using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {

        LikedList likedList = new LikedList();
        likedList.Insert(10);
        likedList.Insert(20);
        likedList.Insert(30);
        likedList.Insert(40);
        likedList.Insert(50);
        likedList.Dispaly();

        likedList.Delete(20);
        likedList.Delete(30);
        Console.WriteLine("After Deleting");
        likedList.Dispaly();
        Console.WriteLine("Hello, World!");
    }
}