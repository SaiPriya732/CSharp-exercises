// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n = Convert.ToInt32(Console.ReadLine());

//         int count = 0;
//         int current = 10;

//         while (current != n)
//         {
//             if (current * 3 <= n)
//             {
//                 current = current * 3;
//             }
//             else if (current < n)
//             {
//                 current = current + 2;
//             }
//             else
//             {
//                 current = current - 1;
//             }

//             count++;
//         }

//         Console.WriteLine(count);
//     }
// }