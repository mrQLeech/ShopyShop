namespace ShopyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LocalUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocalUsers()
        {
            UserPermissions = new HashSet<UserPermissions>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(248)]
        public string Login { get; set; }

        [Required]
        [StringLength(248)]
        public string Password { get; set; }

        [Required]
        [StringLength(1000)]
        public string EMail { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Required]
        [StringLength(1000)]
        public string Adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
