namespace Test.Solutions;
/*
The following code prints the next 20 leap years from the current year
*/
public class LeapYearSolution
{
    
    private static void PrintNext20LeapYears()
    {
        var year = DateTime.Now.Year;  //Getting the current year of the local machine
        int count = 0;

        Console.WriteLine("===== NEXT LEAP YEARS =====");
        // Using while loop to make sure that only 20 years are printed
        while (count < 20)
        {
            // A leap year is divisible by 4 and divisible by 400 when divisible by 100(century)
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("{0}. {1}", count + 1, year);
                count += 1;
            }
            year += 1;
        }
    }

    public static void Run()
    {
        PrintNext20LeapYears();
    }
}