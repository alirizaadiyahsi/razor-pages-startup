using System;
using BaseProjectTemplate.Core.BaseEntities;
using Microsoft.AspNetCore.Identity;

namespace BaseProjectTemplate.Core.Authorization
{
    public class ApplicationUser : IdentityUser<Guid>, IBaseFullAuditedEntity
    {
        public Guid CreatorUserId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public Guid ModifierUserId { get; set; }
        public DateTime ModificationDateTime { get; set; }
    }
}
