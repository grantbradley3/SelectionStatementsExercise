namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NumberGuessingGame
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;
            //var counter = 1;
            //do
            //{
            //    Console.WriteLine("Pick a number from 1 - 1000");
            //    userInput = int.Parse(Console.ReadLine());
            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You guessed it! It took you {counter} guesses. ");
            //    }
            //    counter++;
            //} while (userInput != favNumber);

            //SwitchCase
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();
            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate  math!");
                    break;
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!!");
                    break;
                case "english":
                    Console.WriteLine("English is boring");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break; 
            }
        }
    }
}
