//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SummoningBell
{
    using System;
    using System.Collections.Generic;
    
    public partial class RetainerLog
    {
        public long Id { get; set; }
        public int RetainerId { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual Retainer Retainer { get; set; }
    }
}
