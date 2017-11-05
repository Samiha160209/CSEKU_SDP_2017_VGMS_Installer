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
    
    public partial class Rented
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public System.DateTime RentDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public double RentAmount { get; set; }
        public bool IsReturned { get; set; }
        public int Quantity { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
