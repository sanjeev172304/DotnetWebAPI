//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecpMgmtWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccessTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessTbl()
        {
            this.RoleAccessPermissionTbls = new HashSet<RoleAccessPermissionTbl>();
            this.AccessPermissionTbls = new HashSet<AccessPermissionTbl>();
        }
    
        public int AccessId { get; set; }
        public string AccessName { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleAccessPermissionTbl> RoleAccessPermissionTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessPermissionTbl> AccessPermissionTbls { get; set; }
    }
}
