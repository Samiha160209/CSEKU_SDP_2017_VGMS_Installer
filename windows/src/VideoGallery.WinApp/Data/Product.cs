//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoGallery.WinApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Rented = new HashSet<Rented>();
            this.Sold = new HashSet<Sold>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public double DurationInMin { get; set; }
        public int VideoTypeId { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
        public string Producers { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> StatusEnumId { get; set; }
        public int TotalItem { get; set; }
        public int TotalSold { get; set; }
        public float BuyPrice { get; set; }
        public float SellingPrice { get; set; }
        public int TotalRented { get; set; }
        public int CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rented> Rented { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sold> Sold { get; set; }
    }
}
