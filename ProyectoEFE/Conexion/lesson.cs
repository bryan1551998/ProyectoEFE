//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoEFE.Conexion
{
    using System;
    using System.Collections.Generic;
    
    public partial class lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lesson()
        {
            this.exercises = new HashSet<exercis>();
        }
    
        public int id_lessons { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string contents { get; set; }
        public Nullable<int> fk_topics { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exercis> exercises { get; set; }
        public virtual topic topic { get; set; }
    }
}
