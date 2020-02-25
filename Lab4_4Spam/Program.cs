using System;

namespace Lab4_4Spam

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blacklistWords = {
            "buy", "viagra", "XXX", "free money", "free",
                "lifetime offer", "send money", "bank account",
                "nigeria", "online pharmacy", "h8te", "meet girls" };

            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < blacklistWords.Length; i++)
            {
                if (message.Contains(blacklistWords[i]))
                {
                    isSpam = true;
                }
            }


            if (isSpam == true)
            {
                Console.WriteLine("The message contained spam");
            }
            else
            { 
                Console.WriteLine("The message does not contain spam.");
            }
        }
    }
}