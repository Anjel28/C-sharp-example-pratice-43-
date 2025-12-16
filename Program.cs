//RECURSION EXAMPLES -1.
using System;
using System.Runtime.CompilerServices;

/*class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        return 1;
        else
        return n * Factorial(n-1);
    }
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {result}");
    }
}*/

//2.
/*public class MedicineBox<T>
{
    private  List<T> medicines = new List<T>();

    public void Add(T medicine)
    {
        medicines.Add(medicine);
        Console.WriteLine($"{medicine} added to box.");
    }
}
class Program
{
    static void Main()
    {
        var nameBox = new MedicineBox<string>();
        nameBox.Add("Paracetamol");
        nameBox.Add("Vitamin C");

        var idBox = new MedicineBox<int>();
        idBox.Add(101);
        idBox.Add(202);

    }
}*/

//3.
/*public class Locker<T>
{
    public T item {get; set;}

}
class Program
{
    static void Main()
    {
        var jewelryLocker = new Locker<string> {item = "Gold Necklace"};
        var cashLocker = new Locker<int> {item = 50000};

        Console.WriteLine($"Jewelry: {jewelryLocker.item}");
        Console.WriteLine($"Cash: {cashLocker}");
    }
}*/

//4.
public class Bag<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }
    public void ShowItems()
    {
        foreach(var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main()
    {
        var bookBag = new Bag<string>();
        bookBag.AddItem("Math Book");
        bookBag.AddItem("Science NoteBook ");
        bookBag.ShowItems();

        
    }
}