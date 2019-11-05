using System;

namespace Logistics.AppServices
{
    public class EntityDtoBase : EntityDtoBase<Guid>
    {
        //public override Guid Id { get; set; } = Guid.NewGuid();
    }
    public class EntityDtoBase<TPrimaryKey> 
    {
        /// <summary>唯一标识</summary>
        public TPrimaryKey Id { get; set; }
      
     
    }
}
