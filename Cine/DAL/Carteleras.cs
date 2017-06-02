//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carteleras
    {
        public int IdCartelera { get; set; }
        public int IdSede { get; set; }
        public int IdPelicula { get; set; }
        public int HoraInicio { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public int NumeroSala { get; set; }
        public int IdVersion { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public System.DateTime FechaCarga { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual Versiones Versiones { get; set; }
    }
}
