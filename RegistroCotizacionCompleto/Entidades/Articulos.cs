﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCotizacionCompleto.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int CantCotizada { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = String.Empty;
            Precio = 0;
            Existencia = 0;
            CantCotizada = 0;
        }
    }
}
