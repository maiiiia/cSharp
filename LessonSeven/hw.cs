// using System;
// using System.IO;
// //hw: 7.9, 7.2, 7.4, 7.10

// class Program
// {
//     static void Main(string[] args)
//     {
//         string path = "C:/Users/1295859/Downloads/thirdYearProgramming/cSharp/LessonSeven/test2.txt";

//         FileStream testStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
//         StreamWriter writer = new StreamWriter(testStream);
//         string value;
//         do
//         {
//             value = Console.ReadLine();
//             if (value != "стоп")
//             {
//                 writer.Write(value + "\r\n");

//             }
//         }
//         while (value != "стоп");
//         writer.Close();
    
//     }

// }