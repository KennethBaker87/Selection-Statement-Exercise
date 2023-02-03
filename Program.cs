namespace Selection_Statement_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------First Exercise--------------------
            var favNumber = 7;
            Console.WriteLine("Guess my favorite number between 1 and 10.");
            var guess = int.TryParse(Console.ReadLine(), out int guess1);
            if (guess1 == favNumber)
            {
                Console.WriteLine($"Great Job! {favNumber} is correct!");
            }
            else if(guess1 > favNumber )
            {
                Console.WriteLine("Too High");
            }
            else if(guess1 < favNumber) 
            {
                Console.WriteLine("Too Low");
            }
            //------------------Second Exercise------------------------
            Console.WriteLine("What is your favorite school subject?: ");
            var answer2 = Console.ReadLine();
            
            switch (answer2)
            {
                case "P.E.":
                    Console.WriteLine($"{answer2}: I can accept failure, everyone fails at something/ But I can't accept not trying - Michael Jordan");
                    break;
                case "Science":
                    Console.WriteLine($"{answer2}: Scientists have become the bearers of the torch of discovery in our quest for knowledge - Stephan Hawking");
                    break;
                case "History":
                    Console.WriteLine($"{answer2}: Love your Enemies, for they tell you your Faults - Benjamin Franklin.");
                    break;
                case "English":
                    Console.WriteLine($"{answer2}: It was the best of times, it was the worst of times - Charles Dickens");
                    break;
                case "Algebra":
                    Console.WriteLine($"{answer2}: Please Excuse My Dear Aunt Sally - every math teach ever");
                    break;
                default
                    : Console.WriteLine($"{answer2}: Try another subject next time.");
                    break;


            } 
        }
    }
}