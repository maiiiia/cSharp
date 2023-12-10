

// using System;
// using System.Globalization;
// using System.Linq.Expressions;


// delegate string StrMod(ref string str);
// delegate int intMod(int n);
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
//         //8.1
//         string str = "hello world!!!   !!";
//         StrMod strOp;
//         StrMod reverseStr = reverse;
//         StrMod removeSp = remove_spaces;

//         strOp = reverseStr;
//         strOp += removeSp;
//         //Console.WriteLine("Результат:" + strOp(ref str));

//         //8.3
//         StrMod test_delegate = delegate (ref string str)
//         {
//             str += "some text";
//             return str;
//         };
//         string newstr = "1,2,3";
//         //Console.WriteLine(test_delegate(ref newstr));


//         static intMod somemethod()
//         {
//             int sum = 0;
//             intMod int_del = delegate (int num)
//             {
//                 for (int i = 0; i <= num; i++)
//                 {
//                     sum += i;
//                 }
//                 return sum;
//             };
//             return int_del;
//         }

//         intMod myintmod = somemethod();
//         //Console.WriteLine(myintmod(11));
//         //Console.WriteLine(myintmod(10));

//         //8.6
//         intMod mylambda = (n) =>
//         {
//             int res=1;
//             for(int i =1; i<=n;i++) 
//             {
//                 res*=i;
//             }
//             return res;
//         };

//         //Console.WriteLine(mylambda(5));

//     }
// }