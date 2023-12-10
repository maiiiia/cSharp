// using System;
// using System.IO;


// class Program
// {
//     // static void Main(string[] args)
//     // {
//     //     string path = "C:/Users/1295859/Downloads/thirdYearProgramming/cSharp/LessonSeven/test.txt";

//     //     FileStream testStream = new FileStream(path, FileMode.Open, FileAccess.Read);
//     //     StreamReader reader = new StreamReader(testStream);

//     //     Console.SetIn(reader);
//     //     while (!reader.EndOfStream)
//     //     {
//     //         Console.WriteLine(Console.ReadLine());
//     //     }
//     //     Console.ReadKey();
//     // }

//     static void Main(string[] args)
//     {
//         ConsoleKeyInfo cki;
//         do
//         {
//             //cki = Console.ReadLine();
//             cki = Console.ReadKey();
//             Console.WriteLine(cki.Key);
//             Console.WriteLine(cki.KeyChar);

//         }
//         while (cki.Key != ConsoleKey.Escape);
//     }


//     //hw: 7.9, 7.2, 7.4

// }