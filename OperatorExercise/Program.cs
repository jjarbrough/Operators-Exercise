namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Divide(17, 4);
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
    }
}
