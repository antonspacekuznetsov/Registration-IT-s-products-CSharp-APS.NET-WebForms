//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegITProducts
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAN
    {
        public TAN()
        {
            this.RegisterDatas = new HashSet<RegisterData>();
        }
    
        public int id { get; set; }
        public string TanCode { get; set; }
        public int ProductId { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ICollection<RegisterData> RegisterDatas { get; set; }
    }
}
