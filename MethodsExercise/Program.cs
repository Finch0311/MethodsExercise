namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}!");
            Console.WriteLine($"{name} what is your favorite tv show?");
            string tv = Console.ReadLine();
            Console.WriteLine($"{tv}? Nice mine is M*A*S*H. ");
            Console.WriteLine("What is your favorite beverage after work?");
            string drink = Console.ReadLine();
            Console.WriteLine($"Your favorite is {drink}? My favorite drink after a long day is Modelo");
            Console.WriteLine("You have to be 21 years of age or older to drink Modelo. How old are you?");
            int legal = Convert.ToInt32(Console.ReadLine());


            //How do you fix if input is not a number.


            if (legal < 21)
            {
                Console.WriteLine("You don't know what your missing!");

            }
            else
            {
                Console.WriteLine("You're more than welcome to swing by anytime after work!");

            }
            Console.WriteLine($"So let us recap your name is {name}. You like to watch {tv}. Your favorite drink is {drink}. Your age is {legal}.");

            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now I need another number to add to it.");
            int num2 = int.Parse(Console.ReadLine());
            
            int sum = Sum(num1, num2);

            Console.WriteLine($"{sum}. Here is the sum of your numbers!");

            Console.WriteLine("Now lets multiply some numbers. Please give me a number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Now the second number please.");
            int y = int.Parse(Console.ReadLine());

            int multiply = Multiply(x , y);
            Console.WriteLine($"Your numbers multiplied into {multiply}.");

            Console.WriteLine("Our last trick with code is finding the remainder after dividing two numbers. Please input a number.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks now another number.");
            int d = int.Parse(Console.ReadLine());

            int divide = Divide(c , d);
            Console.WriteLine($"After dividing the numbers we are left with a remainder of {divide}.");



        }
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;


            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Modulus(int c, int d)
        {
            return c % d;
        }
    }

}
