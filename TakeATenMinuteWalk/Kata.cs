using System;

namespace TakeATenMinuteWalk
{
    public class Kata
    {
        public bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            int nsWeight = 0;
            int weWeight = 0;

            for (int i = 0; i < walk.Length; i++)
            {
                switch (walk[i])
                {
                    case "n":
                        nsWeight += 1;
                        break;
                    case "s":
                        nsWeight -= 1;
                        break;
                    case "w":
                        weWeight += 1;
                        break;
                    case "e":
                        weWeight -= 1;
                        break;
                }
                
            }

            if ((nsWeight == 0) && (weWeight == 0))
                return true;
            else 
                return false;

        }
    }
}
