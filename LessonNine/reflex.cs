// using System;
// using System.Reflection;
// using System.Reflection.Metadata;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Assembly asm = Assembly.LoadFrom("C:/Users/1295859/Downloads/thirdYearProgramming/cSharp/LessonNine/MyLibrary.dll");
//         Type[] alltypes = asm.GetTypes();
//         // foreach (Type el in alltypes)
//         // {
//         //     Console.WriteLine(el);
//         //     ConstructorInfo[] ci1 = el.GetConstructors();
//         //     foreach (ConstructorInfo c in ci1)
//         //     {
//         //         Console.WriteLine(c);
//         //     }

//         // }

//         Type t = alltypes[0];
//         //Console.WriteLine(t);
//         ConstructorInfo[] ci2 = t.GetConstructors();

//         int value = 142;
//         object[] obj = { value };
//         object reflectOb = ci2[0].Invoke(obj);
        
        
//         Console.WriteLine(reflectOb);
//         MethodInfo[] mi = t.GetMethods();
//         foreach (MethodInfo m in mi) //Вызвать метод.
//         {
//             //Console.WriteLine(m);
//             if (m.Name.CompareTo("Sum") == 0)
//             {
//                 object[] ar = {};
//                 Console.WriteLine(m.Invoke(reflectOb, ar));
//             }
//             ParameterInfo[] pi = m.GetParameters(); //Получить параметры.
//             // foreach(ParameterInfo p in pi)
//             // {
//             //     Console.WriteLine(p);
//             // }
            
//         }



//     }
// }