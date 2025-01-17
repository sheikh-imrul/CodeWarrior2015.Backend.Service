﻿using System.Collections.Generic;

namespace BuySell.GenericRepository
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
