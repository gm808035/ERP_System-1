//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstelaVidaShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Composition
    {
        public int ID { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<int> Material { get; set; }
        public decimal Count { get; set; }
    
        public virtual Material Material1 { get; set; }
        public virtual Product Product1 { get; set; }
    }
}