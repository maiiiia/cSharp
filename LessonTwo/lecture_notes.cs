// using System;

// // nothing interesting here

// class Program
// {
//     static void Main(string[] args)
//     {
//         // вывод
//         Console.WriteLine("В феврале {0} или {1} дней.", 28, 29); //formatting string
//         Console.WriteLine("\n"); //new line
//         Console.WriteLine("\t"); //tabulation
//         Console.WriteLine("Первая строка \n Вторая строка");
//         Console.WriteLine("\t Первая строка \n Вторая строка");
//         Console.WriteLine(@"Это буквальный
//                                 строковый литерал,
//                                     занимающий несколько строк.");

//         // приведение типов
//         double x = 5, y = 3;
//         int i;
//         i = (int)(x / y);
//         Console.WriteLine(i); //1

//         // % - деление по модулю
//         int iresult, irem;
//         double dresult, drem;
//         iresult = 10 / 3;
//         irem = 10 % 3;
//         dresult = 10.0 / 3.0;
//         drem = 10.0 % 3.0;
//         Console.WriteLine("Результат и остаток от деления 10/3:" +
//         iresult + " " + irem);
//         Console.WriteLine("Результат и остаток от деления 10.0 / 3.0:" +
//         dresult + " " + drem);

//         // не путать i++ и ++i
//         // & = and, | = or, &&, || = short forms, ! = not, ^ = XOR (exclusive or)
//         // >>, << =  сдвиги вправо, влево (поразрядные), остальные операнды те же
//         // cycles and conditions: while, do while, for, switch, if else, if
//         int j;
//         for (i = 0, j = 10; i < j; i++, j--) Console.WriteLine("i и j:" + i + " " + j);


//         bool done = false;
//         for (i = 0, j = 100; !done; i++, j--)
//         {
//             if (i * i >= j) done = true;
//             Console.WriteLine("i, j:" + i + " " + j);
//         }
        
//         i=0;
//         for (;i < 10;)
//         {
//             Console.WriteLine("Проход No" + i);
//             i++; // инкрементировать переменную управления циклом
//         }

//         // break, continue, goto
//     }
// }








