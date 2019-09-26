using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logistics.EF.Core
{
    public interface ITransientDependency
    {
    }
    public interface IRepository<T, TPrimaryKey> : ITransientDependency where T : EntityBase<TPrimaryKey>, new()
    {
        /// <summary>
        /// 泛型方法，通过id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(object id);

        /// <summary>
        /// 获取分页列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IEnumerable<T> GetPageList(int pageIndex, int pageSize);

        /// <summary>
        /// 获取全部
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(T entity);
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        bool Delete(object id);

        long Count();
       
    }
}
