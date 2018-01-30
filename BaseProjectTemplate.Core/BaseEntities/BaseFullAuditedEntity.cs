using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public abstract class BaseFullAuditedEntity : BaseEntity, IBaseCreationAuditedEntity, IBaseModificationAuditedEntity
    {
        public Guid CreatorUserId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public Guid ModifierUserId { get; set; }
        public DateTime ModificationDateTime { get; set; }
    }
}