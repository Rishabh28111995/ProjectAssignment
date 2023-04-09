namespace LargestNumber;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;
        Console.WriteLine("Enter the number: ");

        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());

        if(num1 > num2 && num2 > num3)
        {
            Console.WriteLine(num1 + " is largest");
        }
        else if(num2 > num3 && num3 > num1)
        {
            Console.WriteLine(num2 + " is largest");
        }
        else
        {
            Console.WriteLine(num3 + " is largest");
        }
    }
}

