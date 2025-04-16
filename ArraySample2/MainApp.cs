using System;
using static System.Formats.Asn1.AsnWriter;

namespace ArraySample2
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;            
            // 80 74 81 90 34
            // 0  1  2  ^2 ^1

            int sum = 0;
            foreach (int score in scores)
            {
                Console.WriteLine(score);
                sum += score;                
            }
            
            Console.WriteLine(sum);
        }
    }
}
