// using System;

// class EnumDemo
// {
//     //Вне метода main обязательно!!!!
//     enum Apple { Jonathan, GoldenDel, RedDel, Winesap, Cortland, McIntosh };
    
//     static void Main()
//     {
//         string[] color = {"красный","желтый","красный","красный",
//         "красный","красновато-зеленый"};

//         Apple i; // объявить переменную перечислимого типа
//                  // Использовать переменную i для циклического
//                  // обращения к членам перечисления.
        
//         for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
//         Console.WriteLine(i + " имеет значение " + (int)i);
        
//         Console.WriteLine();

//         // Использовать перечисление для индексирования массива.
//         for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
//             Console.WriteLine("Цвет сорта " + i + " - " + color[(int)i]);
//     }
// }