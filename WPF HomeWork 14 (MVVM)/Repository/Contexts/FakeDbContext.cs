using System.Collections.Generic;
using MVVM.Models;

namespace MVVM.Repository.Contexts;

public class FakeDbContext
{
    public static List<Car> Cars { get; set; } = new()
    {
        new Car { Id = 1, Model = "Kia", Make="Cerato", Year = 2013 },
        new Car { Id = 2, Model = "Hyundai", Make = "i30", Year = 2015 },
        new Car { Id = 3, Model = "Bmw", Make = "M8", Year = 2022 },

    };

    public static List<Car> GetCars()
    {
        var list = new List<Car>();
        return list;
    }

}
