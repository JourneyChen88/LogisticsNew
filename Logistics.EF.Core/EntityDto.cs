using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics.EF.Core
{
    //
    // 摘要:
    //     Implements common properties for entity based DTOs.
    //
    // 类型参数:
    //   TPrimaryKey:
    //     Type of the primary key
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        //
        // 摘要:
        //     Creates a new Abp.Application.Services.Dto.EntityDto`1 object.
        public EntityDto();
        //
        // 摘要:
        //     Creates a new Abp.Application.Services.Dto.EntityDto`1 object.
        //
        // 参数:
        //   id:
        //     Id of the entity
        public EntityDto(TPrimaryKey id);

        //
        // 摘要:
        //     Id of the entity.
        public TPrimaryKey Id { get; set; }
    }
}
