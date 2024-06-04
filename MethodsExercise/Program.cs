namespace MethodsExercise
{
    public class Program
    {


        public static void Add(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }
        public static void Multiply(int num1, int num2)       
        {
            int answer = num1 * num2;
            Console.WriteLine(answer);
        }
        
        
        public static void Divide(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine(answer);

        }
        public static void Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine(answer);
        
        }
        static void Main(string[] args)
        {
            

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

            Add(10, 10);
            Subtract(10, 5);
            Multiply(10, 5);
            Divide(10, 5);

            






        }

    }
}
