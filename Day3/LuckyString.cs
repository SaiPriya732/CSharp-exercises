using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();

        if (n > str.Length)
        {
            Console.WriteLine("Invalid");
            return;
        }

        bool lucky = false;
        int required = n / 2;

        for (int i = 0; i <= str.Length - n; i++)
        {
            string sub = str.Substring(i, n);

            int pCount = 0;
            int sCount = 0;
            int gCount = 0;

            int maxP = 0;
            int maxS = 0;
            int maxG = 0;

            foreach (char ch in sub)
            {
                if (ch == 'P')
                {
                    pCount++;
                    maxP = Math.Max(maxP, pCount);
                }
                else
                {
                    pCount = 0;
                }

                if (ch == 'S')
                {
                    sCount++;
                    maxS = Math.Max(maxS, sCount);
                }
                else
                {
                    sCount = 0;
                }

                if (ch == 'G')
                {
                    gCount++;
                    maxG = Math.Max(maxG, gCount);
                }
                else
                {
                    gCount = 0;
                }
            }

            if (maxP >= required || maxS >= required || maxG >= required)
            {
                lucky = true;
                break;
            }
        }

        if (lucky)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
