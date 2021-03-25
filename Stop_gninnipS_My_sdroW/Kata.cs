using System;

namespace Stop_gninnipS_My_sdroW
{
    public class Kata
    {
        public string SpinWords(string sentence)
        {
            string result = "";
            string bufer = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                
                if (sentence[i] == ' ')
                {
                    result = result + ReverseStringMoreThan(bufer, 5);

                    result = result + " ";
                    bufer = "";
                }
                else 
                    bufer = bufer + sentence[i];

                if (i == sentence.Length - 1 && (bufer.Length != 0))
                {
                    result = result + ReverseStringMoreThan(bufer, 5);
                }
            }
            return result;
        }

        public string ReverseStringMoreThan(string str, int i)
        {
            string result = "";
            if (str.Length >= i)
            {
                result = ReverseString(str);
            }
            else
            {
                result = str;
            }

            return result;
        }

        public string ReverseString(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result = result + str[i];
            }
            return result;
        }
    }
}
