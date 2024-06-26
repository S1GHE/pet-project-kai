﻿using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
interface IRepository<T> : IDisposable
       where T : class
{
    IEnumerable<T> GetAll();
    T Get(int id);
    void Create(T item);
    void Update(T item);
    void Delete(int id);
    void Save();
}
