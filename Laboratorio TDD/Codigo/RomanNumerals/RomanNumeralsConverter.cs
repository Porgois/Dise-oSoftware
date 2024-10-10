using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace RomanNumerals;


public class RomanNumeralsConverter
{
    public static string Translate(int a)
    {
        List<string> roman_characters = ["I", "V", "X", "L", "C", "D", "M"];
        
        string result = "";

        string number_string = a.ToString();
        int length = number_string.Length;

        int current_number;
        int value_offset = 0;

        for (int i = length - 1; i >= 0; i--)
        {
            current_number = Convert.ToInt32(number_string[i].ToString());

            if (current_number < 4)
            {
                result = string.Concat(Enumerable.Repeat(roman_characters[value_offset], current_number)) + result;
            } 
            else if (current_number == 4)
            {
                result = roman_characters[value_offset] + roman_characters[value_offset + 1] + result;
            }
            else if (current_number < 9)
            {
                result = roman_characters[value_offset + 1] + String.Concat(Enumerable.Repeat(roman_characters[value_offset], current_number - 5)) + result;
            } 
            else
            {
                result = roman_characters[value_offset] + roman_characters[value_offset + 2] + result;
            }
            value_offset += 2;
        }
        return result;
    }
}