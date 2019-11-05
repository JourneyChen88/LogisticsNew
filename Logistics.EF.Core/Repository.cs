using Logistics.EF.Core;
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
    public class Repository<T, TPrimaryKey> : IRepository<T, TPrimaryKey> where T : EntityBase<TPrimaryKey>, new()
    {
        private readonly LogisticsDbContext _context = null;
        private readonly DbSet<T> _dbSet;
        public Repository(LogisticsDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public bool Add(T entity)
        {
          var res=  _dbSet.Add(entity);
            return _context.SaveChanges() > 0;

        }
        public bool AddRange(List<T> entitys)
        {
             _dbSet.AddRange(entitys);
            return _context.SaveChanges() > 0;

        }

        public bool Delete(object id)
        {
            var entity = _dbSet.Find(id);
            entity.IsDeleted = true;
            _dbSet.Update(entity);
            return _context.SaveChanges() > 0;
        }
        public bool Update(T entity)
        {
            _dbSet.Update(entity);
            return _context.SaveChanges() > 0;
        }
        public T GetById(object id)
        {
            return this._dbSet.Where(a => a.IsDeleted == false).FirstOrDefault(a => a.Id.ToString() == id.ToString());
        }
        public long Count()
        {
            return _dbSet.Where(a => a.IsDeleted == false).LongCount();
        }

        public IEnumerable<T> GetPageList(int pageIndex, int pageSize)
        {
            var list = _dbSet.Where(a => a.IsDeleted == false).Skip(pageIndex * pageSize).Take(pageSize);
            return list;
        }
        public IEnumerable<T> GetAll()
        {
            var list = _dbSet.Where(a => a.IsDeleted == false);
            return list;
        }
    }

}
