//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropdownBind
{
    using System;
    using System.Collections.Generic;
    
    public partial class City_Master
    {
        public int CityID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string CityName { get; set; }
    
        public virtual State_Master State_Master { get; set; }
    }
}
