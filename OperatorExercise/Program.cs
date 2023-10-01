namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Divide(17, 4);
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)};");
        }
        public static int Mod(int a, int b)
        {
            return a % b;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            return a / b;
        }
        public static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
    }
}
