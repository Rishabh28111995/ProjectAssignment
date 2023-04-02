namespace PowerOfN;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of N: ");
            int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("2^{0} = {1}", i, Math.Pow(2, i));
        }
    }
}
