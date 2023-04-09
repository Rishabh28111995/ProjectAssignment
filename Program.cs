namespace LeapYear;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine(year + " is a Leap year");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap year) ");
        }
        
    }
}
