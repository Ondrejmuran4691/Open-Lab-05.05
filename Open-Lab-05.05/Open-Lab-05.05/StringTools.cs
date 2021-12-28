using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            int repeat = 0;
            string final = "";
            string a = "";
            original = original.ToLower();
            foreach (char c in original)
            {
                if (c.ToString() != " ")
                {
                    repeat++;
                }
                
                if (repeat % 2 == 0)
                {
                    a = c.ToString();
                }
                else
                {
                    a = c.ToString().ToUpper();
                }

                final += a;
            }

            return final;
        }
    }
}
