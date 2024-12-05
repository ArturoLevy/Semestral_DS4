using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semestral_DS4.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaID { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Ubicacion { get; set; }
    }
}