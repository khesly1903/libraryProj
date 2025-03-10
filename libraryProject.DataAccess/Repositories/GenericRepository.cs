﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using libraryProject.DataAccess.Abstractions;
using libraryProject.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace libraryProject.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDBContext db)
        {
            _dbContext = db;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }
        
        public void Delete(Guid id)
        {
            var data = _dbSet.Find(id);
            if (data != null)
            {
                _dbSet.Remove(data);
                _dbContext.SaveChanges();
            }
        }
        
       
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid id)
        {
            var data = _dbSet.Find(id);
            if (data == null)
            {
                throw new Exception("Bulunamadı.");
            }
            return data;
        }
        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
