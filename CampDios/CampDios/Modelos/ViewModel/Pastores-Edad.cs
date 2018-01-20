﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampDios.Modelos
{
    public class Pastores_Edad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pastores_Edad()
        {
            this.DetalleGrupo = new HashSet<DetalleGrupo>();
            this.Iglesia = new HashSet<Iglesia>();
            this.Zona = new HashSet<Zona>();
        }

        public int IdPastor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public int Sexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdProfesion { get; set; }
        public int IdCapacitacion { get; set; }
        public int IdRolPastor { get; set; }
        public int IdCorporativo { get; set; }

        public virtual Capacitaciones Capacitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleGrupo> DetalleGrupo { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iglesia> Iglesia { get; set; }
        public virtual LiderazgoCorporativo LiderazgoCorporativo { get; set; }
        public virtual Profesion Profesion { get; set; }
        public virtual RolesPastor RolesPastor { get; set; }
        public virtual Sexo Sexo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zona> Zona { get; set; }
    }
}