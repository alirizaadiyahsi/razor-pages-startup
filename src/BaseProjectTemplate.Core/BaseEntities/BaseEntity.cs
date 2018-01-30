using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public abstract class BaseEntity:IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
