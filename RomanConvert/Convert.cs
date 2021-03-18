using System;
using System.Collections.Generic;
using System.Linq;

/*
    Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

    Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 
    In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 
    1666 uses each Roman symbol in descending order: MDCLXVI.

    RomanConvert.Solution(1000) -- should return "M"

    Symbol    Value
    I          1
    V          5
    X          10
    L          50
    C          100
    D          500
    M          1,000
*/
//https://stackoverflow.com/questions/7040289/converting-integers-to-roman-numerals
namespace RomanConvert
{
    //структуру для хранения
    public class RomanCharaterSequence
    {
        //значение символов
        public int Value { get; set; }
        //Последовательность символов
        public string Characters { get; set; }
    }

    public class RomanConverter
    {
        public List<RomanCharaterSequence> GetRomanCharacterSequences()
        {
            return new List<RomanCharaterSequence>()
            {
                new RomanCharaterSequence(){ Value = 1000 , Characters = "M"},
                new RomanCharaterSequence(){ Value = 900 , Characters = "CM"},
                new RomanCharaterSequence(){ Value = 500 , Characters = "D"},
                new RomanCharaterSequence(){ Value = 400 , Characters = "CD"},
                new RomanCharaterSequence(){ Value = 100 , Characters = "C"},
                new RomanCharaterSequence(){ Value = 90 , Characters = "XC"},
                new RomanCharaterSequence(){ Value = 50 , Characters = "L"},
                new RomanCharaterSequence(){ Value = 40 , Characters = "XL"},
                new RomanCharaterSequence(){ Value = 10 , Characters = "X"},
                new RomanCharaterSequence(){ Value = 9 , Characters = "IX"},
                new RomanCharaterSequence(){ Value = 5 , Characters = "V"},
                new RomanCharaterSequence(){ Value = 4 , Characters = "IV"},
                new RomanCharaterSequence(){ Value = 1 , Characters = "I"},
            };
        }

        public string Convert(int number)
        {
            var romanCharacters = GetRomanCharacterSequences();
            string resultString = "";

            while (number >= 1)
            {
                //вычесть из number максимальный из List не привышающий number
                var maxValue = romanCharacters.Where(x => x.Value <= number).Max(x => x.Value);
                var maxRomanCharaterSequenceByValue = romanCharacters.Where(x => x.Value == maxValue).First();

                number = number - maxRomanCharaterSequenceByValue.Value;
                resultString = resultString + maxRomanCharaterSequenceByValue.Characters;
            }

            return resultString;
        }
    }

    

}
