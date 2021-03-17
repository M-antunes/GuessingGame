using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            //QUESTIONS

            List<Question> questions = new List<Question>
            {
                new Question(1, "What's the largest river in the world?", "It is located in Africa", "Nilo"),
                new Question(2, "what's the highest mountain in the world?", "It is located in Asia", "Everest"),
                new Question(3, "what's the largest island in the world?", "It is in the north hemesphere", "Greenland"),
                new Question(4, "What's the largest ocean in the world?", "It's not the Atlantic", "Pacific"),
                new Question(5, "How many bones does the human body have?", "Less than 210, more than 200", "206"),
                new Question(6, "Which ocean is the deepest?", "it has 7 letters", "Pacific"),
                new Question(7, "How many planets are there in the solar system?", "Pluto doesn't count anymore", "8"),
                new Question(8, "Which is the biggest planet in the solar system?", "It has the name of a famous Roman God", "Jupiter"),
                new Question(9, "Which is the smallest planet in the solar system?", "It has the name of a element in the periodic table", "Mercury"),
                new Question(10,"Which is the closest planet to Earth?", "It has the name of a famous Roman Godess", "Venus"),
                new Question(11,"Which ocean did Titanic sink in", "It starts with an A", "Atlantic"),

            };



            Console.WriteLine("-----------------");
            Console.WriteLine("Welcome to our guessing game!!");
            Console.WriteLine("-----------------");
            Console.Write("Please enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Press any key to start the game.");
            Console.ReadLine();
            bool keepPlaying = true;
            while (keepPlaying == true)
            {
                var rnd = new Random();
                int id = rnd.Next(questions.Count);
                var questionShow = questions.Find(x => x.Id == id);
                Console.WriteLine("Answer the question:");
                Console.WriteLine(questionShow.Name);
                string answer = Console.ReadLine();

                if (answer != questionShow.Answer)
                {
                    Console.WriteLine("Too bad. You're wrong!");
                    Console.WriteLine("Thanks for playing!");
                    keepPlaying = false;
                }
                Console.WriteLine("Great! You got it right!");
                Console.WriteLine("Press any key to continue the Quiz.");
                Console.ReadLine();
                questions.RemoveAt(id);
                
                keepPlaying = true;
            }
            

        }
        static void MostrarErro()
        {

        }
        
    }
}
