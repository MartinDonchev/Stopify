﻿// ReSharper disable VirtualMemberCallInConstructor
namespace Stopify.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Stopify.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class StopifyUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public StopifyUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
