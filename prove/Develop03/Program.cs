using System;

class Program
{
    static void Main(string[] args)
    {


        Reference ref1 = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        string answer = "";

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayTextScript());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            if (answer == "")
                {
                    scripture.HiddeRandomWords(3);
                }

            bool allWordsHiden = scripture.IsCompletelyHiden();
            if(allWordsHiden == true)
            {
                break;
            }

            
        
        } while (answer != "quit");

        Console.WriteLine("Thank you for use this program to memorize your scriptures!");
    }
}