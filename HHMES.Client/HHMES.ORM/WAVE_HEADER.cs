//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class WAVE_HEADER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WAVE_HEADER()
        {
            this.WAVE = new HashSet<WAVE>();
            this.WAVE_DETAIL = new HashSet<WAVE_DETAIL>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public int WAREHOUSEID { get; set; }
        public bool ENABLE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        public virtual WAREHOUSE WAREHOUSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WAVE> WAVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WAVE_DETAIL> WAVE_DETAIL { get; set; }
    }
}
