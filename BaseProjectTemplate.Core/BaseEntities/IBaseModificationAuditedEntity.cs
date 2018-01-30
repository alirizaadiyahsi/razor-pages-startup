using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public interface IBaseModificationAuditedEntity : IBaseEntity
    {
        Guid ModifierUserId { get; set; }
        DateTime ModificationDateTime { get; set; }
    }
}