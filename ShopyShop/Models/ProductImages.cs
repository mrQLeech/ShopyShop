namespace ShopyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductImages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Required]
        public byte[] Photo { get; set; }

        [Required]
        [StringLength(1000)]
        public string LargePhotoFile { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool PrimaryPhoto { get; set; }

        public int Ord { get; set; }

        public virtual Products Products { get; set; }
    }
}
