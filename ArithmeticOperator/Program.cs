namespace ArithmeticOperator;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 Circle Circumference

        Task1();
        Console.ReadLine();

        // Task 2 Circle Area
        Task2();
        Console.ReadLine();

        // Task 3 Divisor
        Task3();
        Console.ReadLine();

        // Task 4 Hypotenuse
        Task4();
        Console.ReadLine();

        // Task 5 Book Division
        Task5();
        Console.ReadLine();

        // Task 6 Block Size
        Task6();
        Console.ReadLine();

        // Task 7 Block Size
        Task7();
        Console.ReadLine();
    }

    static double CircleCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static bool IsDivisor(double number1, double number2)
    {
        return number1 % number2 == 0;
    }

    static double Hypotenuse(double number1, double number2)
    {
        return Math.Sqrt(Math.Pow(number1, 2) + Math.Pow(number2, 2));
    }

    static int BlockCalculation(double fileSize)
    {
        const int blockSize = 512;
        const int kiB2Byte = 1024;
        return (int) Math.Ceiling(fileSize * kiB2Byte / blockSize);
    }

    static void Task1()
    {
        Console.WriteLine("Please input the radius of a circle: ");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The circumference of the circle is {CircleCircumference(input).ToString("F2")}.");
    }

    static void Task2()
    {
        Console.WriteLine("Please input the radius of a circle: ");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The area of the circle is {CircleArea(input).ToString("F2")}.");
    }

    static void Task3()
    {
        Console.WriteLine("Please input two numbers: ");
        string[] inputs = Console.ReadLine()!.Split();
        double number1 = Convert.ToDouble(inputs[0]), number2 = Convert.ToDouble(inputs[1]);

        if (IsDivisor(number1, number2) == true)
        {
            Console.WriteLine($"{number1} is divisible by {number2}.");
        }
        else
        {
            Console.WriteLine($"{number1} is not divisible by {number2}.");
        }
    }

    static void Task4()
    {
        Console.WriteLine("Please input two numbers: ");
        string[] inputs = Console.ReadLine()!.Split();
        double number1 = Convert.ToDouble(inputs[0]), number2 = Convert.ToDouble(inputs[1]);
        Console.WriteLine($"The hypotenuse will be: {Hypotenuse(number1, number2).ToString("F2")}");
    }

    static void Task5()
    {
        Console.WriteLine("Please input the number of students and the number of books: ");
        string[] inputs = Console.ReadLine()!.Split();
        int numberStudent = int.Parse(inputs[0]), numberBook = int.Parse(inputs[1]);

        int numberPerStudent = numberBook / numberStudent, numberLeftOver = numberBook % numberStudent;

        Console.WriteLine($"The number of books each student will get is {numberPerStudent} and {numberLeftOver} will be left over.");
    }

    static void Task6()
    {
        Console.WriteLine("Please input the size of a file in KiB (kibibytes): ");
        double fileSize = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The number of blocks used will be: {BlockCalculation(fileSize)}");
    }

    static void Task7()
    {
        Console.WriteLine("Please input the total amount of pocket money earned each week: ");
        decimal pocketMoney = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please input the precentage you want to save: (without %)");
        decimal savePercentage = Convert.ToDecimal(Console.ReadLine());

        decimal moneySaved = pocketMoney * savePercentage / 100;

        const int months = 12;
        decimal moneySavedYear = moneySaved * months;

        Console.WriteLine($"You will save {moneySaved} per day and {moneySavedYear} per year.");
    }
}

