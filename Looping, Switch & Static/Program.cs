using Looping__Switch___Static.Exceptions;


namespace Looping__Switch___Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student();

                Console.Write("Enter Name : ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    throw new InvalidInput("Name cannot be null or empty");
                }
                s.Name = name;

                Console.WriteLine();

                decimal[] arr = new decimal[5];

                Console.WriteLine("Enter 5 Subject Marks (Value Should be positive & less than 100) : ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter {i + 1} Mark : ");
                    arr[i] = Convert.ToDecimal(Console.ReadLine());
                    if (arr[i] < 0 || arr[i] > 100)
                    {
                        throw new InvalidMarks("Marks Should be positive & less than 100");
                    }
                }

                s.Marks = arr;

                Console.WriteLine();

                Console.WriteLine("Select Any 1 Option : ");
                Console.WriteLine($"1) Aggregate");
                Console.WriteLine($"2) MinMark");
                Console.WriteLine($"3) MaximumMark");
                Console.WriteLine($"4) Grade");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option < 1 || option > 4)
                {
                    Console.WriteLine("Invalid Option");
                }

                Console.WriteLine();

                switch ((Options)option)
                {
                    case Options.Aggregate:
                        decimal avg = s.CalculateAverageMarks();
                        Console.WriteLine($"Name : {s.Name}, \nAverage Marks : {avg}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"Name : {s.Name}, \nMinimum Marks : {s.Marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"Name : {s.Name}, \nMaximum Marks : {s.Marks.Max()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine($"Name : {s.Name}, \nGrade : {s.CalculateGrade(s.CalculateAverageMarks())}");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}