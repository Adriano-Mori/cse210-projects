using System;

class Program
{
    static void Main(string[] args)
    {
        // clear and welcome
        Console.Clear();
        Console.WriteLine("Greetings user.");
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // extra feature added - 4 scriptures instead of just one
        // create a library of different scriptures with references
        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(
                new Reference("1 Nephi",3,7),
                "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            ),
            new Scripture(

                new Reference ("John", 3,16),

                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("D & C", 6, 36, 37),
                "Look unto me in every thought; doubt not, fear not. Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven. Amen."
            ),
        };

        //pick at random
        Random rand = new Random();
        Scripture chosen = library[rand.Next(library.Count)];

        // loop until all the words are hidden (or the user quits)
        while (true)
        {
            Console.Clear();
            Console.WriteLine(chosen.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            //if user types quit
            if (input.ToLower() == "quit")
            {
                break;
            }
            // if pressing enter
            if (input == "")
            {
                chosen.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(chosen.GetDisplayText());

                if (chosen.IsCompletelyHidden())
                {
                    break;
                }
            }
            //if presses other key
            else
            {
                Console.WriteLine("Invalid input. Please press ENTER or type 'quit'.");
            }
        }
    }
}