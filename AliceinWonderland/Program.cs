using System;

namespace AliceinWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("What word would you like to search for?");
            string word = Console.ReadLine();
            Console.WriteLine(line.ToUpper().Contains(word.ToUpper()));
            Console.WriteLine("What word would you like to remove?");
            string removable = Console.ReadLine();
            int index = line.ToUpper().IndexOf(word.ToUpper());
            int length = removable.Length;
            Console.WriteLine(removable + " is in the sentence at index: " + index + " and it has length: " + length);
            string newstring = line.Remove(index, length);
            Console.WriteLine(newstring);

        }
    }
}
