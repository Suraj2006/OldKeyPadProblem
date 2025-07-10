using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public  static String OldPhonePad(string input)
    {
        Dictionary<char, string> keypad = new Dictionary<char, string>()
    {
        { '2', "ABC" }, { '3', "DEF" }, { '4', "GHI" },
        { '5', "JKL" }, { '6', "MNO" }, { '7', "PQRS" },
        { '8', "TUV" }, { '9', "WXYZ" }
    };

        StringBuilder result = new StringBuilder();
        string[] numbercombo = input.Split(' ');

        foreach (string number in numbercombo)
        {
            char? prevChar = null;
            int count = 0;

            foreach (char c in number)
            {
                if (prevChar == null)
                {
                    prevChar = c;
                    count = 1;
                }
                else if (c == prevChar)
                {
                    count++;
                }
                else
                {
                    if (keypad.ContainsKey((char)prevChar))
                    {
                        string letters = keypad[(char)prevChar];
                        int index = (count - 1) % letters.Length;
                        result.Append(letters[index]);
                    }

                    prevChar = c;
                    count = 1;
                }
            }

            
            if (prevChar != null && keypad.ContainsKey((char)prevChar))
            {
                string letters = keypad[(char)prevChar];
                int index = (count - 1) % letters.Length;
                result.Append(letters[index]);
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
