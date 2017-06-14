using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DetalleSimple.Models
{
    public class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }

        public string Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public double Monto { get; set; }

        public Cotizaciones()
        {

        }
    }
}