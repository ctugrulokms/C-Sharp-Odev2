using System;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            string sentence = Console.ReadLine()!;
            char[] sentence_arr = sentence.ToCharArray();

            char[] sesli = {'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü', 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> sesli_list = new List<char>();

            foreach(char item in sentence_arr)
            {
                if(sesli.Contains(item))
                {
                    sesli_list.Add(item);
                    Console.Write(item + " ");
                }
            }

        
        }
    }
}
