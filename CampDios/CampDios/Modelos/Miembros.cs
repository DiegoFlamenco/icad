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
    
    public partial class Miembros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Miembros()
        {
            this.Comunidad = new HashSet<Comunidad>();
            this.DetalleFamilia = new HashSet<DetalleFamilia>();
            this.DetalleFamilia1 = new HashSet<DetalleFamilia>();
            this.DetalleGrupo = new HashSet<DetalleGrupo>();
            this.Finanzas = new HashSet<Finanzas>();
            this.HistoriaEspiritual = new HashSet<HistoriaEspiritual>();
            this.Iglesia = new HashSet<Iglesia>();
            this.Miembros1 = new HashSet<Miembros>();
            this.Usuarios = new HashSet<Usuarios>();
            this.Zona = new HashSet<Zona>();
        }
    
        public int IdMiembro { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public int Sexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public Nullable<int> IdProfesion { get; set; }
        public Nullable<int> IdCapacitacion { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<int> IdHMayor { get; set; }
        public Nullable<int> IdCorporativo { get; set; }
        public Nullable<int> IdIglesia { get; set; }
    
        public virtual Capacitaciones Capacitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comunidad> Comunidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFamilia> DetalleFamilia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFamilia> DetalleFamilia1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleGrupo> DetalleGrupo { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finanzas> Finanzas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoriaEspiritual> HistoriaEspiritual { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iglesia> Iglesia { get; set; }
        public virtual Iglesia Iglesia1 { get; set; }
        public virtual LiderazgoCorporativo LiderazgoCorporativo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miembros> Miembros1 { get; set; }
        public virtual Miembros Miembros2 { get; set; }
        public virtual Profesion Profesion { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Sexo Sexo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zona> Zona { get; set; }
    }
}
