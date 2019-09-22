using System;

namespace Logistics.Models
{
    public class EntityBase : EntityBase<Guid>
    {
        //public override Guid Id { get; set; } = Guid.NewGuid();
    }
    public class EntityBase<TPrimaryKey> 
    {
        /// <summary>唯一标识</summary>
        public TPrimaryKey Id { get; set; }
        /// <summary>
        /// 创建世间
        /// </summary>
        public virtual DateTime CreationTime { get; set; } = DateTime.Now;
       /// <summary>
       /// 创建人
       /// </summary>
        public virtual long? CreatorUserId { get; set; }
        /// <summary>
        /// 软删除
        /// </summary>
        public virtual bool IsDeleted { get; set; }
    }
}
