using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DetalleSimple.Models
{
    public class DetalleCotizacion
    {
        [Key]

        public int DetalleCotizacionId { get; set; }

        public int CotizacionId { get; set; }

        public string Articulo { get; set; }

        public int Cantidad { get; set; }

        public double PrecioUni { get; set; }

        public double SubTotal { get; set; }

        public DetalleCotizacion()
        {

        }
    }
}