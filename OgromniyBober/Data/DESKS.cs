//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgromniyBober.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DESKS
    {
        public int ID_DESK { get; set; }
        public string DESK_DESC { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<int> USER_ID { get; set; }
    
        public virtual User User { get; set; }
    }
}