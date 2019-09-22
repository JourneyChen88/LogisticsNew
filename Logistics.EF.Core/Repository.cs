using Logistics.EF.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logistics.EF.Core
{
    /// <summary>
    /// 服务层基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly LogisticsDbContext _context = null;
        private readonly DbSet<T> _dbSet;
        public Repository(LogisticsDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T GetById(object id)
        {
            return this._dbSet.Find(id);
        }
        public bool Add(T entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges() > 0;

        }

        public long Count()
        {
            return _dbSet.LongCount();
        }

        public bool Delete(object id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            return _context.SaveChanges() > 0;
        }

      

        public List<T> GetPageList(int pageIndex, int pageSize)
        {
            var list = _dbSet.Skip(pageIndex* pageSize).Take(pageSize).ToList();
            return list;
        }
        public List<T> GetAll()
        {
            var list = _dbSet.ToList();
            return list;
        }
        public bool Update(T entity)
        {
            _dbSet.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }

}
