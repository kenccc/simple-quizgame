namespace C__starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            var questions = new[]
                {
                    new Tuple<string, string, string, bool>("What is the capital of France?", "Paris", "London", true),
                    new Tuple<string, string, string, bool>("Which planet is known as the Red Planet?", "Mars", "Jupiter", true),
                    new Tuple<string, string, string, bool>("Which of the following is NOT a primary color?", "Green", "Red", true),
                    new Tuple<string, string, string, bool>("What is the largest planet in our solar system?", "Jupiter", "Saturn", true),
                    new Tuple<string, string, string, bool>("Which of the following authors wrote 'To Kill a Mockingbird'?", "F. Scott Fitzgerald", "Harper Lee", false)
                };
            foreach (var question in questions)
            {
                part(question.Item1, question.Item2, question.Item3, question.Item4);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void part(string question, string optionA, string optionB, bool correctAnswer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(question + " A) " + optionA + " or B) " + optionB);
            string user_input = Console.ReadLine().ToUpper(); 
            if (user_input == "A")
            {
                if (correctAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                }
            }
            else if (user_input == "B")
            {
                if (!correctAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}