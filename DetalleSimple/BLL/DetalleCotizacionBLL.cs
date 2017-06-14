using DetalleSimple.DAL;
using DetalleSimple.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DetalleSimple.BLL
{
    public class DetalleCotizacionBLL
    {
        public static bool Guardar(DetalleCotizacion detalle)
        {
            bool resultado = false;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    conexion.DetalleCotizacion.Add(detalle);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static DetalleCotizacion Buscar(int? detalleCotizacionId)
        {
            DetalleCotizacion detalle = null;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    detalle = conexion.DetalleCotizacion.Find(detalleCotizacionId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return detalle;
        }
        public static bool Modificar(DetalleCotizacion detalle)
        {
            bool resultado = false;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    conexion.Entry(detalle).State = EntityState.Modified;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static bool Eliminar(DetalleCotizacion detalle)
        {
            bool resultado = false;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    conexion.Entry(detalle).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<DetalleCotizacion> Listar()
        {
            List<DetalleCotizacion> listado = null;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    listado = conexion.DetalleCotizacion.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }

        public static bool Guardar(List<DetalleCotizacion> detalles)
        {
            bool resultado = false;
            try
            {
                foreach (DetalleCotizacion detail in detalles)
                {
                    resultado = Guardar(detail);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public static List<DetalleCotizacion> Listar(int? cotizacionId)
        {
            List<DetalleCotizacion> listado = null;
            using (var conexion = new DetalleDB())
            {
                try
                {
                    listado = conexion.DetalleCotizacion.Where(d => d.CotizacionId == cotizacionId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
        public static bool Eliminar(List<DetalleCotizacion> detalles)
        {
            bool resultado = false;
            try
            {
                foreach (DetalleCotizacion detalle in detalles)
                {
                    var detail = Buscar(detalle.DetalleCotizacionId);
                    if (detail != null)
                    {
                        resultado = Eliminar(detail);
                    }
                    else
                        continue;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public static bool Modificar(List<DetalleCotizacion> detalles)
        {
            bool resultado = false;
            try
            {
                foreach (DetalleCotizacion detalle in detalles)
                {
                    var detail = Buscar(detalle.DetalleCotizacionId);
                    if (detail != null)
                    {
                        resultado = Modificar(detalle);
                    }
                    else
                    {
                        resultado = Guardar(detalle);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
    }
}
