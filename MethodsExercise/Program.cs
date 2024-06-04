namespace MethodsExercise
{
    public class Program
    {
        public static int Add(int num1, int num2)
        { var answer = num1 + num2;
        return answer;

        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3; 
        
        
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        
        }
        static void Main(string[] args)
        {   
            var amountOfCars = Add(2, 6);
            var something = Multiply(60, 2, 4);
            var dogs = Divide(10, 2);
            var cats = Subtract(20, 10);

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
           Console.WriteLine("------------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the fist one");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The is: (sum)");

            int add = Add(num1, num2);
            Console.WriteLine($"The sum is: {add}");
        }

    }
}
