//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipePuppy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorite
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public string Thumbnail { get; set; }
        public int FavUserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
