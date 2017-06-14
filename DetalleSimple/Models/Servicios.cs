using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DetalleSimple.Models
{
    public class Servicios
    {
        [Key]
        public int ServicioId { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public int Duracion { get; set; }
    }
}