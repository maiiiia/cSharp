using System;
using System.Collections.Generic;
using System.Linq;



// Класс, представляющий транспортное средство
class Vehicle
{
    public string Name { get; set; }
    public string Category { get; set; }
}


class Program
{
    static void Main()
    {
        // Создаем список транспортных средств
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Name = "Car1", Category = "Land" },
            new Vehicle { Name = "Car2", Category = "Land" },
            new Vehicle { Name = "Ship1", Category = "Sea" },
            new Vehicle { Name = "Ship2", Category = "Sea" },
            new Vehicle { Name = "Airplane1", Category = "Air" },
            new Vehicle { Name = "Airplane2", Category = "Air" },
            new Vehicle { Name = "Boat1", Category = "River" },
            new Vehicle { Name = "Boat2", Category = "River" },
        };

        // Групповое объединение транспортных средств по категориям
        var groupedVehicles = from vehicle in vehicles
                              group vehicle by vehicle.Category into grouped
                              select new
                              {
                                  Category = grouped.Key,
                                  Vehicles = grouped.ToList()
                              };

        // Выводим информацию о транспортных средствах по категориям
        foreach (var categoryGroup in groupedVehicles)
        {
            Console.WriteLine($"Category: {categoryGroup.Category}");
            foreach (var vehicle in categoryGroup.Vehicles)
            {
                Console.WriteLine($"  {vehicle.Name}");
            }
            Console.WriteLine();
        }
    }
}
