using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logistics.EF.Core
{
    public class PageModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        /// <summary>
        /// output
        /// </summary>
        public int PageCount { get; set; }
    }
    public class TableModel<T>
    {
        /// <summary>
        /// 表格数据，支持分页
        /// </summary>
        public int Code { get; set; }
        public string Msg { get; set; }
        public int Count { get; set; }
        public List<T> Data { get; set; }
    }
    public interface ITransientDependency
    {
    }
    public interface IRepository<T>: ITransientDependency where T : class, new()
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
        List<T> GetPageList(int pageIndex, int pageSize);

        /// <summary>
        /// 获取全部
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
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
