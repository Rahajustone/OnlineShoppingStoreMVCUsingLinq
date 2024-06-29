//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingStoreMVCUsingLinq
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubCategory
    {
        public SubCategory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int PKSubCategoryId { get; set; }
        public int FKCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int FKCreatedByUserId { get; set; }
        public Nullable<int> FKUpdatedByUserId { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfile UserProfile1 { get; set; }
    }
}
