using System;

namespace Teams
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            string srt1 = nums[0];
            string srt2 = nums[1];
            int sum = 0;

            if (srt1.Length > srt2.Length)
            {
                for (int i = 0; i < srt2.Length; i++)
                {
                    int l = srt1[i];
                    int r = srt2[i];
                    sum += l * r;
                }
                for (int i = srt2.Length; i < srt1.Length; i++)
                    sum += srt1[i];
            }
            else
            {
                for (int i = 0; i < srt1.Length; i++)
                {
                    int l = srt1[i];
                    int r = srt2[i];
                    sum += l * r;
                }
                for (int i = srt1.Length; i < srt2.Length; i++)
                    sum += srt2[i];
            }
            Console.WriteLine(sum);
        }
    }

}
