//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmileSunshineToy
{
    using System;
    using System.Collections.Generic;
    
    public partial class workorder
    {
        public int WorkOrderID { get; set; }
        public Nullable<int> productionPlanID { get; set; }
        public string Stutas { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual productionplan productionplan { get; set; }
    }
}
