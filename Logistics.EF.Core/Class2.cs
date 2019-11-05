using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logistics.EF.Core
{
    public class UnitOfWorks<TContext> : IUnitOfWorks<TContext>
        where TContext : DbContext
    {
        protected TContext dbContext;
        protected bool _IsCommit = false;
        public bool IsCommit { get { return _IsCommit; } set { _IsCommit = value; } }

        public UnitOfWorks()
        {
            dbContext = (TContext)EFCoreContextFactory.GetDbContext();
        }

        /// <summary>
        /// 设置DbContext上下文
        /// </summary>
        /// <param name="context"></param>
        public void SetDb(TContext context)
        {
            dbContext = context;
        }

        private IDictionary<Type, object> RepositoryDic = new Dictionary<Type, object>();

        //注册Respository
        //public void Register<T>(IRepository<T> respository)
        //{
        //    var key = typeof(T);
        //    if (RepositoryDic.ContainsKey(key))
        //    {
        //        RepositoryDic.Add(key, respository);
        //    }
        //}

        protected IRepository<T> GenericRepository<T>() where T : class
        {
            return new Repository<DbContext, T>(dbContext);
        }

        public IRepository<T> GetRepository<T>()
            where T : class
        {
            IRepository<T> repository = null;
            var key = typeof(T);

            if (RepositoryDic.ContainsKey(key))
            {
                repository = (IRepository<T>)RepositoryDic[key];
            }
            else
            {
                repository = GenericRepository<T>();
                RepositoryDic.Add(key, repository);
            }
            return repository;
        }

        /// <summary>
        /// 获取所有实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> All<T>() where T : class
        {
            return GetRepository<T>().All();
        }

        /// <summary>
        /// 根据Lamda表达式来查询实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> Where<T>(Expression<Func<T, bool>> whereLambda) where T : class
        {
            return GetRepository<T>().Where(whereLambda);
        }

        /// <summary>
        /// 获取所有实体数量
        /// </summary>
        /// <returns></returns>
        public int Count<T>() where T : class
        {
            return GetRepository<T>().Count();
        }

        /// <summary>
        /// 根据表达式获取实体数量
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public int Count<T>(Expression<Func<T, bool>> whereLambda) where T : class
        {
            return GetRepository<T>().Count(whereLambda);
        }

        /// <summary>
        /// 实体对象新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add<T>(T model) where T : class
        {
            return GetRepository<T>().Add(model, IsCommit);
        }

        /// <summary>
        /// 实体对象修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update<T>(T model) where T : class
        {
            return GetRepository<T>().Update(model, IsCommit);
        }

        /// <summary>
        /// 实体对象根据字段修改
        /// </summary>
        /// <param name="model"></param>
        /// <param name="proName"></param>
        /// <returns></returns>
        public int Update<T>(T model, params string[] proName) where T : class
        {
            return GetRepository<T>().Update(model, IsCommit, proName);
        }

        /// <summary>
        /// 实体对象删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete<T>(T model) where T : class
        {
            return GetRepository<T>().Delete(model, IsCommit);
        }

        /// <summary>
        /// 删除复核条件的多个实体对象
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public int Delete<T>(Expression<Func<T, bool>> whereLambda) where T : class
        {
            return GetRepository<T>().Delete(whereLambda, IsCommit);
        }

        /// <summary>
        /// 修改信息提交
        /// </summary>
        /// <returns></returns>
        public int SaveChanges(bool validatonSave = true)
        {
          
            return dbContext.SaveChanges();
        }
        

        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
