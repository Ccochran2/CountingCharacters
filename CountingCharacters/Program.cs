using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence. No numbers.");
        string sentence = Console.ReadLine()!;

        Dictionary<char, int> letterCount =
            new Dictionary<char,int>();

        if (sentence.Any(char.IsDigit))
        {
            Console.WriteLine("There's a number in there! Start over!");
            return;
          
        } else
        {
            foreach (char c in sentence!)
            {
                if (letterCount.ContainsKey(c))
                {
                    letterCount[c]++;
                }
                else
                {
                    letterCount.Add(c, 1);
                }
            }
            foreach (KeyValuePair<char, int> KeyValues in letterCount)
            {
                Console.WriteLine($"There are {KeyValues.Value} instances of the letter {KeyValues.Key} in this sentence.");
            }
        }

        }
    }
