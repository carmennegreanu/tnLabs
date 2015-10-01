//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GB.tnLabs.Core.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Identity
    {
        public Identity()
        {
            this.SubscriptionIdentityRoles = new HashSet<SubscriptionIdentityRole>();
            this.TemplateVMs = new HashSet<TemplateVM>();
        }
    
        public int IdentityId { get; set; }
        public string NameIdentifier { get; set; }
        [Obsolete("set to string empty")]
        public string IdentityProvider { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Obsolete("Set to string empty")]
        public string DisplayName { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<SubscriptionIdentityRole> SubscriptionIdentityRoles { get; set; }
        public virtual ICollection<TemplateVM> TemplateVMs { get; set; }
    }
}
