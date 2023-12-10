using System;
using System.Linq;
using System.Net.WebSockets;

//12.2
// Написать программу в которой, для базы данных клиентов банка,
// формируется запрос с сортировкой по трем критериям: фамилии клиента,
// имени и остатку на его счете. Вывести результаты на консоль


class Client
{
    public string surname;
    public string name;
    public double balance;

    public Client(string s, string n, double b)
    {
        surname = s;
        name = n;
        balance = b;
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Client person1 = new Client("Ivanov", "Ivan", 31415);
//         Client person2 = new Client("Petrov", "Ivan", 10000000);
//         Client person3 = new Client("Sidorov", "Boris", 2.7);
//         Client person4 = new Client("Ivanov", "Mikhail", 31415);
//         Client[] clients = new Client[4];

//         clients[0] = person1;
//         clients[1] = person2;
//         clients[2] = person3;
//         clients[3] = person4;

//         var sortedClients = from c in clients
//                             orderby c.surname ascending,
//                             c.name ascending,
//                             c.balance ascending
//                             select c;

//         foreach (var client in sortedClients)
//         {
//             Console.WriteLine($"Фамилия: {client.surname}, Имя: {client.name}, Баланс: {client.balance}");
//         }

//     }
// }