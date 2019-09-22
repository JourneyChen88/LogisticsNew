using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics.EF.Core
{   
    public class IdInput<TId>
    {
        public IdInput()
        { }
        public IdInput(TId id)
        {
            Id = id;
        }

        public TId Id { get; set; }
    }
}
