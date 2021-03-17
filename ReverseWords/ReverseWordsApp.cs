using System;
using System.Linq;
using System.Text;
/// <summary>
/// Complete the fuction that accepts a string parameter, and reverses each word in the string.
/// All spaces in the string should be reatained.
/// Examples: 
/// "This is an example" ===> "sihT si na !elpmaxe"
/// "double  spaces" ===> "elbuod  secaps"
/// </summary>
namespace ReverseWords
{
    public class ReverseWordsApp
    {
        public string ReverseWordsLinq(string str)
        {
            string[] strArr = str.Split(" ");

            var result = strArr.Select( word=> new string(word.Reverse().ToArray())).ToArray();

            return string.Join(" ", result);
        }

        public string ReverseWords(string str)
        {
            StringBuilder reverseSb = new StringBuilder();
            string bufer = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    bufer += str[i];
                }

                if (str[i] == ' ')
                {
                    if (string.IsNullOrWhiteSpace(bufer) == false)
                        reverseSb.Append(ReverseOneWord(bufer));

                    bufer = "";
                    reverseSb.Append(" ");
                }
            }

            if (string.IsNullOrWhiteSpace(bufer) == false)
                reverseSb.Append(ReverseOneWord(bufer));

            return reverseSb.ToString();
        }

        private string ReverseOneWord(string word)
        {
            StringBuilder reverseSb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseSb.Append(word[i]);
            }
            return reverseSb.ToString();
        }
    }
}
