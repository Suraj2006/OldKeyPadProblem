using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static string OldPhonePad(string input)
    {
        Dictionary<char, string> keypad = new Dictionary<char, string>()
        {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
        };

        StringBuilder result = new StringBuilder();

        char lastKey = '\0';
        int pressCount = 0;

        void CommitCharacter()
        {
            if (lastKey != '\0' && keypad.ContainsKey(lastKey))
            {
                string letters = keypad[lastKey];
                int index = (pressCount - 1) % letters.Length;
                result.Append(letters[index]);
            }
            lastKey = '\0';
            pressCount = 0;
        }

        foreach (char c in input)
        {
            if (c == '#')
            {
                CommitCharacter();
                break;
            }
            else if (c == '*')
            {
                CommitCharacter();
                if (result.Length > 0)
                    result.Remove(result.Length - 1, 1);
            }
            else if (c == ' ')
            {
                CommitCharacter();
            }
            else if (char.IsDigit(c))
            {
                if (c == lastKey)
                {
                    pressCount++;
                }
                else
                {
                    CommitCharacter();
                    lastKey = c;
                    pressCount = 1;
                }
            }
        }

        return result.ToString();
    }




    public static void Main()
    {

        Console.WriteLine("Please Enter number sequence");
        string input = Console.ReadLine();
        input = input.TrimEnd('#');

        string result = OldPhonePad(input);
        Console.WriteLine("Output text: " + result);
    }

    
}
