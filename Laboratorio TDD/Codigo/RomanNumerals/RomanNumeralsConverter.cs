using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace RomanNumerals;


public class RomanNumeralsConverter
{
    public static string Translate(int a) {
        List<string> roman_characters = ["I", "V", "X", "L", "C", "D", "M"];
        
        string result = "";

        string number_string = a.ToString();
        int length = number_string.Length;

        int current_number;
        int value_offset = 0;

        for (int i = length - 1; i >= 0; i--) {
            current_number = Convert.ToInt32(number_string[i].ToString());

            switch (current_number)
            {
                case 1:
                case 2:
                case 3:
                    result += string.Concat(Enumerable.Repeat(roman_characters[value_offset], current_number));
                    break;
                case 4:
                    result += roman_characters[value_offset];
                    result += roman_characters[value_offset + 1];
                    break;
                case 5:
                    result += roman_characters[value_offset + 1];
                    break;
                case 6:
                case 7:
                case 8:
                    result += roman_characters[value_offset + 1];
                    result += string.Concat(Enumerable.Repeat(roman_characters[value_offset], current_number - 5));
                    break;
                case 9:
                    result += roman_characters[value_offset];
                    result += roman_characters[value_offset + 2];
                    break;
            }
            value_offset += 2;
        }
        return result;
    }
}