using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroCotizacionCompleto.Entidades;
using System.Data.Entity;

namespace RegistroCotizacionCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }

        public Contexto() : base("ConStr")
        {   }
    }
}
