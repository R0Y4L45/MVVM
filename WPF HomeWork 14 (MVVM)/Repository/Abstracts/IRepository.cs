using System.Collections.Generic;
using System;

namespace WPF_HomeWork_14__MVVM_.Repository.Abstracts;

public interface IRepository<T>
{
    T? Get(Func<T, bool> predicate);
    IList<T> GetList(Func<T, bool>? predicate = null);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
}
