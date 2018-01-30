using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public abstract class BaseModificationAuditedEntity : BaseEntity, IBaseModificationAuditedEntity
    {
        public Guid ModifierUserId { get; set; }
        public DateTime ModificationDateTime { get; set; }
    }
}