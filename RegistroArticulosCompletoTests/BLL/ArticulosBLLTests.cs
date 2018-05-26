using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroCotizacionCompleto.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroCotizacionCompleto.Entidades;

namespace RegistroCotizacionCompleto.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloId = 0;
            articulo.Descripcion = "Prueba";
            articulo.Existencia = 0;
            articulo.Precio = 0;
            articulo.CantCotizada = 0;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Articulos articulo = new Articulos();
            articulo.ArticuloId = 8;
            articulo.Descripcion = "klk";
            articulo.Existencia = 1;
            articulo.Precio = 20;
            articulo.CantCotizada = 1;
            paso = ArticulosBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = ArticulosBLL.Eliminar(8);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulos articulos = new Articulos();
            articulos = ArticulosBLL.Buscar(9);
            Assert.IsNotNull(articulos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = ArticulosBLL.GetList(x=>true);
            Assert.IsNotNull(lista);
        }
    }
}