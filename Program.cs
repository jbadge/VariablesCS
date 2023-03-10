using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 2;
            var fullName = "Jeremy Badger";
            DateTime today = DateTime.Now;

            Console.WriteLine($"{numberOfCupsOfCoffee} {fullName} {today}");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            if (userName == "Alice" || userName == "alice")
            {
                Console.WriteLine("Hey Alice! Great to see you again!");
            }
            else
            {
                Console.WriteLine($"It is a pleasure to meet you, {userName}");
            }

            Console.WriteLine("Please enter a number, and push Enter. Then, enter a second number. ");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine($"{userName}, you chose the numbers {firstNumberAsString} and {secondNumberAsString}.");
            Console.WriteLine($"If you add {firstNumberAsString} and {secondNumberAsString}, you get {sum}.");
            Console.WriteLine($"If you subtract {secondNumberAsString} from {firstNumberAsString}, you get {difference}.");
            Console.WriteLine($"If you multiply {firstNumberAsString} and {secondNumberAsString}, you get {product}.");
            Console.WriteLine($"If you divide {firstNumberAsString} by {secondNumberAsString}, you get {quotient} with a remainder of {remainder}.");




        }
    }
}
