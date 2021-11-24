using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            throw new NotImplementedException();
            char[] characters = original.ToCharArray();
            bool Lower = false;

            for (int i = 0; i <= characters.Length - 1; i++)
            {
                if (characters[i].ToString() != " ")
                {
                    if (Lower == false)
                    {
                        characters[i] = characters[i].ToString().ToUpper().ToCharArray()[0];
                        Lower = true;
                    }
                    else
                    {
                        characters[i] = characters[i].ToString().ToLower().ToCharArray()[0];
                        Lower = false;
                    }
                }
            }
            return new string(characters);
        }
    }
}
