﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Venta
    {
        public long Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public Venta() { }

    }
}
