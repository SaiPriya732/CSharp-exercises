// using System;

// class Program
// {
//     static bool IsVowel(char ch)
//     {
//         ch = char.ToLower(ch);
//         return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
//     }

//     static void Main(string[] args)
//     {
//         string word1 = Console.ReadLine();
//         string word2 = Console.ReadLine();

//         string result = "";

//         foreach (char ch in word1)
//         {
//             bool remove = false;

//             if (!IsVowel(ch))
//             {
//                 foreach (char c in word2)
//                 {
//                     if (char.ToLower(ch) == char.ToLower(c))
//                     {
//                         remove = true;
//                         break;
//                     }
//                 }
//             }

//             if (!remove)
//             {
//                 result += ch;
//             }
//         }

//         string finalResult = "";

//         foreach (char ch in result)
//         {
//             if (finalResult.Length == 0 ||
//                 char.ToLower(ch) != char.ToLower(finalResult[finalResult.Length - 1]))
//             {
//                 finalResult += ch;
//             }
//         }

//         Console.WriteLine(finalResult);
//     }
// }