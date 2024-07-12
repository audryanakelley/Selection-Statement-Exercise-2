using System.Runtime.InteropServices;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "What is your favorite subject?");
            string favSubject = Console.ReadLine();
            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("Math is great for problem - solving skills!");
                    break;
                case "reading":
                    Console.WriteLine("Reading expands your knowledge, enhances your vocabulary!");
                    break;  
                case "science":
                    Console.WriteLine("Science helps us understand the world around us.");
                    break;
                case "art":
                    Console.WriteLine("Art allows us to express our creativity.");
                    break;
                case "music":
                    Console.WriteLine("Music enhances mood, reduces stress, and boosts brain function.");
                    break;
                default:
                    Console.WriteLine("That's an interesting choice! All subjects have their own unique value.");
                    break;
                
                    
                     
            }
                
        }
    }
}