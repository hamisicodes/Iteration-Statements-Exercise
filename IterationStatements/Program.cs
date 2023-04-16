namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbersFrom1000()
        {
            Console.WriteLine("Printing all numbers 1000 through -1000 ...");

            for(var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbersFrom3()
        {
            Console.WriteLine("Printing all numbers from 3 through 999 by 3");

            for(var i = 3; i <= 999  ;i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckIntegerEquality(int firstNum, int SecondNum)
        {
            var output = (firstNum == SecondNum) ? "Integers are equal": "Integers are not equal";
            Console.WriteLine(output);
        }
        
        //Write a method to check whether a given number is even or odd
        public static void CheckOddOrEven(int num)
        {
            var ouput = (num % 2 == 0) ? $"{num} is even" : $"{num} is odd";
            Console.WriteLine(ouput);

        }
        
        //Write a method to check whether a given number is positive or negative
        public static void CheckPositiveOrNegative(int num)
        {
            var output = (num >= 0) ? $"{num} is positive": $"{num} is negative";
            Console.WriteLine(output);
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckIfCanVote()
        {
            int userAge;
            bool isParsed;

            do
            {
                Console.WriteLine("Hello, Please enter your age");
                isParsed = int.TryParse(Console.ReadLine(), out userAge);
            }
            while(!isParsed);

            var output = (userAge > 18) ? $"Your {userAge} years so you can vote": $"Sorry, as a {userAge} year old, you cannot vote";
            Console.WriteLine(output);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void CheckIntInRange()
        {
            Console.WriteLine("Please enter a number");
            var inputNum =  int.Parse(Console.ReadLine());

            var output = (inputNum >= -10 && inputNum <= 10)? "Integer within the range": "Integer not in range";
            Console.WriteLine(output);
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable()
        {
            Console.WriteLine("Please enter a number");
            var inputNum = int.Parse(Console.ReadLine());

            for(var i = 1 ; i <= 12; i++)
            {
                var product = inputNum * i ;
                Console.WriteLine($"{inputNum} x {i} =  {product}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbersFrom1000();
            PrintNumbersFrom3();

            Console.WriteLine("Enter the first number");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var seconNumber = int.Parse(Console.ReadLine());
            CheckIntegerEquality(firstNumber, secondNumber);

            Console.WriteLine("Enter a number to check whether its odd or even");
            var evenOrOddNum = int.Parse(Console.ReadLine());
            CheckOddOrEven(evenOrOddNum);

            Console.WriteLine("Enter a number to check whether its positive or negative");
            var posOrNegNum = int.Parse(Console.ReadLine());
            CheckPositiveOrNegative(posOrNegNum);

            CheckIfCanVote();

            CheckIntInRange();

            DisplayMultiplicationTable();
        }
    }
}
