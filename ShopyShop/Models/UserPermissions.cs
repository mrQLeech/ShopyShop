namespace ShopyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPermissions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PermissionId { get; set; }

        public virtual AccessPermissions AccessPermissions { get; set; }

        public virtual LocalUsers LocalUsers { get; set; }
    }
}
