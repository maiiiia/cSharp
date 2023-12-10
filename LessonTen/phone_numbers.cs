// using System;
// using System.ComponentModel;

//10.10

// class Contact
// {
//     public Contact(string number, string name)
//     {
        
//     }
// }

// class PhoneNumberList
// {
//     string[] numList = new string[1000];
//     int current = 0;
//     string cat;

//     public PhoneNumberList(string category)
//     {
//         cat = category;
//     }

//     public void AddNumber(string phoneNum)
//     {
//         numList[current] = phoneNum;
//         current++;
//         Console.WriteLine("number added successfully");
//     }
//     public void RemoveLastNumber()
//     {
//         current--;
//         Console.WriteLine("last number in list removed successfully");
//     }

//     public void ShowList()
//     {
//         for (int i = 0; i < current; i++)
//         {
//             Console.WriteLine(numList[i]);
//         }
//     }

//     public void ShowCategory()
//     {
//         Console.WriteLine("List for phonenumbers of my ", cat);
//     }

// }


// class PhoneNumberBook
// {
//     PhoneNumberList[] lists;
//     public PhoneNumberBook(string[] types, int n)
//     {
//         lists = new PhoneNumberList[n];
//         for (int i = 0; i < n; i++)
//         {
//             lists[i] = new PhoneNumberList(types[i]);
//         }
//     }

//     public void AddNumber(string cat, string number)
//     {
//         foreach(PhoneNumberList el in lists)
//         {
//             if(el.)
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Your code here
//     }
// }

