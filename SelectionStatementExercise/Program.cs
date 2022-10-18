using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        
      static void Main(string[] args)
        { 
           //------exercise 1-------
            int favNumber = 4;

            string input = Console.ReadLine();

            int userGuess = int.Parse(input);

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too low, please try again");
            }
            if (userGuess > favNumber)
            {
                Console.WriteLine("Too high, Please try again");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine("CORRECT, HOW DID YOU GUESS THAT?");
            }
            //------exercise 2-------

            Console.WriteLine("What is your favorite subject in school?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is one the most useful subjects there is! ");
                    break;

                case "History":
                    Console.WriteLine("History is in the making if its your favorite subject");
                    break;
                case "English":
                    Console.WriteLine("English is a very cool subject");
                    break;
                case "Science":
                    Console.WriteLine("Science experiments are always fun!");
                    break;
                case "Spanish":
                    Console.WriteLine("Learning a new language is very beneficial");
                    break;
                default:
                    Console.WriteLine($"Thats a very interesting subject to like! {subject} sounds like its really cool!");
                    break ;
                    
            }
              
        }    
    }
    
}
