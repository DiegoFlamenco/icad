//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampDios.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Usuarios_Opciones = new HashSet<Usuarios_Opciones>();
        }
    
        public int Usuarios_id { get; set; }
        public string Login { get; set; }
        public string Contraseña { get; set; }
        public Nullable<System.DateTime> Fecha_creacion { get; set; }
        public int Miembro_id { get; set; }
    
        public virtual Miembros Miembros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_Opciones> Usuarios_Opciones { get; set; }
    }
}
