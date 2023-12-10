

using System;


delegate string StrMod(ref string str);



// class Program
// {
//     static string reverse(ref string str)
//     {
//         string result = "";
//         char t;
//         for (int i = str.Length - 1; i >= 0; i--)
//         {
//             t = str[i];
//             result += t;
//         }
//         str = result;
//         return str;
//     }

//     static string remove_spaces(ref string str)
//     {
//         string result = "";
//         char space = ' ';
//         char t;
//         for (int i = 0; i < str.Length; i++)
//         {
//             t = str[i];
//             if (t != space)
//             {
//                 result += t;
//             }
//         }
//         str = result;
//         return str;
//     }

//     static void Main(string[] args)
//     {

//         string str = "hello world!!!   !!";
//         StrMod strOp;
//         StrMod reverseStr = reverse;
//         StrMod removeSp = remove_spaces;
//         // Организовать групповую адресацию.
//         strOp = reverseStr;
//         strOp += removeSp;
//         Console.WriteLine("Результат:" + strOp(ref str));

//     }
// }