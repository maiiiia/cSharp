// using System;
// using System.Reflection;
// using System.Reflection.Metadata;



// [AttributeUsage(AttributeTargets.Method)]
// public class MethodAttribute : Attribute
// {
//     string pri_remark = "this is a method";
//     public MethodAttribute(string comment)
//     {
//         pri_remark = comment;
//     }
//     public string Remark
//     {
//         get
//         {
//             return pri_remark;
//         }
//     }
// }

// public class Qwerty
// {
//     public string keyboard = "qwerty";

//     public Qwerty(string s)
//     {
//         keyboard = s;
//     }

//     [Method("В этом классе используется атрибут!!!!!!!")]
//     public void Show()
//     {
//         Console.WriteLine(keyboard);
//     }

// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         Qwerty test = new Qwerty("hello world");
//         test.Show();

//         Type t = typeof(Qwerty);
//         MethodInfo[] mInfo = t.GetMethods();
//         foreach (MethodInfo m in mInfo)
//         {
//             Attribute[] attr = Attribute.GetCustomAttributes(m);
//             foreach (Attribute o in attr)
//             {
//                 Console.WriteLine(o);

//             }

//         }
        
//         Type q = typeof(Qwerty);
//         MethodInfo m2 = q.GetMethod("Show");
//         Type ma = typeof(MethodAttribute);
//         MethodAttribute MA = (MethodAttribute)Attribute.GetCustomAttribute(m2, ma);
//         Console.WriteLine(MA.Remark);

//     }
// }