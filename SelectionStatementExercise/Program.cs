namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
            
        }  
    }
    
}
