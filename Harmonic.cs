namespace HarmonicN;
class Harmonic
{
    static void Main(string[] args)
    {
        Console.Write("Enter a integer N: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0
                / i;
        }

        Console.WriteLine("the {0}th harmonic no. is {1}", n, sum);
    }
}

