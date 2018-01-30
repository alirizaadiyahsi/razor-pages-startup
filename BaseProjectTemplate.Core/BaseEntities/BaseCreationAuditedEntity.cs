using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public abstract class BaseCreationAuditedEntity : BaseEntity, IBaseCreationAuditedEntity
    {
        public Guid CreatorUserId { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}