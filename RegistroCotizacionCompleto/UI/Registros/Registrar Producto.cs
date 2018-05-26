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
            articulo.Precio = Convert.ToDecimal(Precio_textBox.Text);
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
                errorProvider1.SetError(ArticuloID_numericUpDown1, "Ingrese un ID");
                paso = true;
            }
            if (Negar == 2 && Descripcion_textBox.Text == String.Empty)
            {
                errorProvider2.SetError(Descripcion_textBox, "Ingrese una Descripcion");
                paso = true;
            }
            if (Negar == 2 && Precio_textBox.Text == String.Empty)
            {
                errorProvider3.SetError(Precio_textBox, "Ingrese el Precio");
                paso = true;
            }
            if (Negar == 2 && Existencia_numericUpDown.Value == 0)
            {
                errorProvider4.SetError(Existencia_numericUpDown, "Ingrese Cantidad en Existencia");
                paso = true;
            }
            if (Negar == 2 && CantCotizada_numericUpDown.Value == 0)
            {
                errorProvider5.SetError(CantCotizada_numericUpDown, "Ingrese Cantidad Cotizada");
                paso = true;
            }
            return paso;

        }

        private void LimpiarCampos()
        {
            ArticuloID_numericUpDown1.Value = 0;
            Descripcion_textBox.Clear();
            Precio_textBox.Clear();
            Existencia_numericUpDown.Value = 0;
            CantCotizada_numericUpDown.Value = 0;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Negar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            Articulos articulo = new Articulos();
            bool paso = false;

            if (ArticuloID_numericUpDown1.Value == 0)
                paso = BLL.ArticulosBLL.Guardar(articulo);
            else
                paso = BLL.ArticulosBLL.Modificar(LlenaClase());

            if (paso)
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (paso)
            {
                LimpiarCampos();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
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
    }
}
