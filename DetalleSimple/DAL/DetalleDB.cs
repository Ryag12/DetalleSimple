using DetalleSimple.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DetalleSimple.DAL
{
    public class DetalleDB : DbContext
    {
        public DetalleDB(): base("Constr")
        {

        }

        public DbSet <Cotizaciones> Cotizacion { get; set; }

        public DbSet <DetalleCotizacion> DetalleCotizacion{ get; set; }

        public DbSet<Articulos> Articulo { get; set; }

        public DbSet<Servicios> Servicio { get; set; }
    }
}