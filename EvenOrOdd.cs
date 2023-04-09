namespace EvenOrOdd;
class Program
{
    static void Main(string[] args)
    {
        int N;
        Console.WriteLine("Enter the number: ");
         N = int.Parse(Console.ReadLine());

        if(N % 2 == 0)
        {
            Console.WriteLine("Number is Even");

        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
}

