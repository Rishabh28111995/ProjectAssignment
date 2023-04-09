namespace Alphabet;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the alphabet: ");
        char ch = char.Parse(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("Alphabet is vowel.");
        }
        else
        {
            Console.WriteLine("Alphabet is consonant.");
        }


    }
}

