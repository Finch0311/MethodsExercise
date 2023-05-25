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
            int legal = Convert.ToInt32( Console.ReadLine() );


            //How do you fix if input is not a number.
            
            
            if( legal < 21 ) 
            {
                Console.WriteLine("You don't know what your missing!");

            }
            else
            {
                Console.WriteLine("You're more than welcome to swing by anytime after work!");

            }
            Console.WriteLine($"So let us recap your name is {name}. You like to watch {tv}. Your favorite drink is {drink}. Your age is {legal}.");
            

           

        }
    }
}
