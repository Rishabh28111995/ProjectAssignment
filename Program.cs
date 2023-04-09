namespace QuotientRemainder;
class Program
{
    static void Main(string[] args)
    {
        int dividend;
        int divisor;
        int quotient;
        int remainder;

        Console.WriteLine("Enter the value of dividend: ");
        dividend = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of divisor: ");
        divisor = int.Parse(Console.ReadLine());

        quotient = dividend / divisor;
        remainder = dividend % divisor;

        Console.WriteLine("Quotient is: " + quotient);
        Console.WriteLine("Remainder is: " + remainder);
    }
}

