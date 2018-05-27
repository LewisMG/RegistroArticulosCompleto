using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroCotizacionCompleto.Entidades;

namespace RegistroCotizacionCompleto.UI.Registros
{
    public partial class RegistroCotizacion : Form
    {
        public RegistroCotizacion()
        {
            InitializeComponent();
        }

        private Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(ArticuloID_numericUpDown1.Value);
            articulo.Descripcion = Descripcion_textBox.Text;
            articulo.Precio = PrecionumericUpDown.Value;
            articulo.Existencia = Convert.ToInt32(Existencia_numericUpDown.Value);
            articulo.CantCotizada = Convert.ToInt32(CantCotizada_numericUpDown.Value);
            articulo.FechaVencimiento = FechaVenc_dateTime.Value;

            return articulo;
        }

        private bool Negar(int Negar)
        {
            bool paso = false;
            if (Negar == 1 && ArticuloID_numericUpDown1.Value == 0)
            {
                General_errorprovider.SetError(ArticuloID_numericUpDown1, "Ingrese un ID");
                paso = true;
            }
            if (Negar == 2 && Descripcion_textBox.Text == String.Empty)
            {
                General_errorprovider.SetError(Descripcion_textBox, "Ingrese una Descripcion");
                paso = true;
            }
            if (Negar == 2 && PrecionumericUpDown.Value == 0)
            {
                General_errorprovider.SetError(PrecionumericUpDown, "Ingrese el Precio");
                paso = true;
            }
            if (Negar == 2 && Existencia_numericUpDown.Value == 0)
            {
                General_errorprovider.SetError(Existencia_numericUpDown, "Ingrese Cantidad en Existencia");
                paso = true;
            }
            if (Negar == 2 && CantCotizada_numericUpDown.Value == 0)
            {
                General_errorprovider.SetError(CantCotizada_numericUpDown, "Ingrese Cantidad Cotizada");
                paso = true;
            }
            return paso;

        }

        private void LimpiarCampos()
        {
            ArticuloID_numericUpDown1.Value = 0;
            Descripcion_textBox.Clear();
            PrecionumericUpDown.Value = 0;
            Existencia_numericUpDown.Value = 0;
            CantCotizada_numericUpDown.Value = 0;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            General_errorprovider.Clear();
            LimpiarCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {            
            if (Negar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            General_errorprovider.Clear();


            if (ArticuloID_numericUpDown1.Value == 0)
            {
                if (BLL.ArticulosBLL.Guardar(LlenaClase()))
                {

                    LimpiarCampos();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (BLL.ArticulosBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            General_errorprovider.Clear();

            if (Negar(1))
            {
                MessageBox.Show("Ingresar un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloID_numericUpDown1.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroCotizacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            General_errorprovider.Clear();
            if (Negar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }
            int id = Convert.ToInt32(ArticuloID_numericUpDown1.Value);
            Articulos articulo = BLL.ArticulosBLL.Buscar(id);

            if (articulo != null)
            {
                ArticuloID_numericUpDown1.Value = articulo.ArticuloId;
                Descripcion_textBox.Text = articulo.Descripcion;
                PrecionumericUpDown.Value = articulo.Precio;
                Existencia_numericUpDown.Value = articulo.Existencia;
                CantCotizada_numericUpDown.Value = articulo.CantCotizada;

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
