
using System;
using System.Collections.Generic;

namespace Tuwaiq
{
    class Program
    {
        /*static void tokenizer(string source)
        {
            string text = "";
            int i = 0;
            while (i < source.Length)
            {
                text = "";
                if (source.IsLetter("", 0) || source[i] == "_")
                {
                    text += text[i];
                }
                
            }
        }*/




        static void Main(string[] args)
        {
            /*id - number - = */
            // id -> (letter|underscore) + loop(digit|letter|underscore)
            // ali = 2 => 

            //string value = "";
            //Console.WriteLine(source[i]);

            string tweet = "هافنق فن ان طويق #مرح #فرح #تسلية @hello اليوم";
            List<string> found = new List<string>();
            foreach (var item in tweet.Split(' '))
            {
                if (item.StartsWith("#") || item.StartsWith("@"))
                {
                    found.Add(item);
                }

            }
            foreach (var item in found)
            {
                Console.WriteLine(item);
            }

            countTweet(found);


        }
        static void countTweet(List<string> arr)
        {
            int count_h = 0;
            int count_m = 0;

            foreach (var item in arr)
            {
                if (item.StartsWith("#"))
                {
                    count_h++;
                }
                else if (item.StartsWith("@"))
                {
                    count_m++;

                }
            }
            Console.WriteLine("The number of hashtags: " + count_h);
            Console.WriteLine("The number of mentions: " + count_m);
        }
    }

}


