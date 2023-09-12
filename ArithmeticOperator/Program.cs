namespace ArithmeticOperator;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 Circle Circumference

        Console.WriteLine("Please input the radius of a circle: ");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The circumference of the circle is {CircleCircumference(input).ToString("F2")}.");

        Console.ReadLine();

        
    }

    static double CircleCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
}

