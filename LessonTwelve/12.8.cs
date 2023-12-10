//12.8
// Написать программу для учета товаров на складе. Реализовать класс с
// двумя свойствами: наименование и инвентарный номер товара и класс со
// свойствами: инвентарный номер товара и количество единиц товара на
// складе. Сформировать запрос по результатам которого будет создан
// массив объектов содержащих информацию о наименование товара и
// количестве единиц на складе.

using System;
using System.Linq;

class ProductName
{
    public string name;
    public int number;

    public ProductName(string n1, int n2)
    {
        name = n1;
        number = n2;
    }

}

class ProductAmount
{
    public int number;
    public int amount;

    public ProductAmount(int n1, int n2)
    {
        number = n1;
        amount = n2;
    }

}

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n_prod = 5;
//         ProductName[] names = new ProductName[n_prod];
//         ProductAmount[] amounts = new ProductAmount[n_prod];
//         char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
//         string[] mynames = new string[n_prod];

//         for (int i = 0; i < n_prod; i++)
//         {
//             mynames[i] = alphabet[i].ToString();
//             int n = i * 100;
//             names[i] = new ProductName(mynames[i], n);
//             amounts[i] = new ProductAmount(n, i);
//         }

//         for (int i = 0; i < n_prod; i++)
//         {
//             Console.WriteLine("Product: ");
//             Console.WriteLine(names[i].name);
//             Console.WriteLine(names[i].number);
//             Console.WriteLine(amounts[i].number);
//             Console.WriteLine(amounts[i].amount);
//         }

//         var result = from pName in names
//                      join pAmount in amounts 
//                      on pName.number equals pAmount.number
//                      select new {pName.name, pAmount.amount};

//         foreach (var item in result)
//         {
//             Console.WriteLine($"Товар: {item.name}, Количество: {item.amount}");
//         }
//     }
// }