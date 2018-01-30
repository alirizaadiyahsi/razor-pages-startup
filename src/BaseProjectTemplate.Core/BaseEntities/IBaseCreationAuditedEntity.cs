using System;

namespace BaseProjectTemplate.Core.BaseEntities
{
    public interface IBaseCreationAuditedEntity : IBaseEntity
    {
        Guid CreatorUserId { get; set; }
        DateTime CreationDateTime { get; set; }
    }
}