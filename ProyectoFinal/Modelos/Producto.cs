using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Producto
    {
        public long Id { get; set; }

        [MaxLength(150)]
        public string? Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public double Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto() { }

        public Producto(string descripciones)
        {

            Descripciones = descripciones;

        }
    }

}

