// using System;
// using System.Linq;

//12.4
// Для объектов класса ContactInfo, содержащего три свойства (имя
// пользователя, его e-mail и телефон) сформировать запрос и вывести по
// его результатам объекты класса EmailAddress (см. предыдущий пример)


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