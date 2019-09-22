using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics.EF.Core
{
    //
    // 摘要:
    //     Defines common properties for entity based DTOs.
    //
    // 类型参数:
    //   TPrimaryKey:
    public interface IEntityDto<TPrimaryKey>
    {
        //
        // 摘要:
        //     Id of the entity.
        TPrimaryKey Id { get; set; }
    }
}
