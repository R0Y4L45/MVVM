using System.Linq;
using System;
using WPF_HomeWork_14__MVVM_.Models;
using WPF_HomeWork_14__MVVM_.Repository.Abstracts;
using WPF_HomeWork_14__MVVM_.Repository.Contexts;
using System.Collections.Generic;

namespace WPF_HomeWork_14__MVVM_.Repository.Concrets;

public class CarRepository : ICarRepository
{
    public void Add(Car entity) => FakeDbContext.Cars.Add(entity);
    public Car? Get(Func<Car, bool> predicate) => FakeDbContext.Cars.FirstOrDefault(predicate);
    public IList<Car> GetList(Func<Car, bool>? predicate = null) 
        => (predicate is null) switch
            {
                true => FakeDbContext.Cars,
                false => FakeDbContext.Cars.Where(predicate).ToList(),
            };
    public void Remove(Car entity) => FakeDbContext.Cars.Remove(entity);
    public void Update(Car entity)
    {
        var index = FakeDbContext.Cars.IndexOf(entity);
        FakeDbContext.Cars[index] = entity;
    }
}
