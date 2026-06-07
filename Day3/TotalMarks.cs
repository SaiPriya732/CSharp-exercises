// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int x = Convert.ToInt32(Console.ReadLine());
//         int y = Convert.ToInt32(Console.ReadLine());
//         int n1 = Convert.ToInt32(Console.ReadLine());
//         int n2 = Convert.ToInt32(Console.ReadLine());
//         int m = Convert.ToInt32(Console.ReadLine());

//         bool found = false;
//         int type1 = 0;
//         int type2 = 0;

//         for (int i = n1; i >= 0; i--)
//         {
//             for (int j = n2; j >= 0; j--)
//             {
//                 if ((i * x) + (j * y) == m)
//                 {
//                     type1 = i;
//                     type2 = j;
//                     found = true;
//                     break;
//                 }
//             }

//             if (found)
//             {
//                 break;
//             }
//         }

//         if (found)
//         {
//             Console.WriteLine("Valid");
//             Console.WriteLine(type1);
//             Console.WriteLine(type2);
//         }
//         else
//         {
//             Console.WriteLine("Invalid");
//         }
//     }
// }
