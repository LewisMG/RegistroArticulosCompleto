using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using RegistroCotizacionCompleto.Entidades;

namespace RegistroCotizacionCompleto.UI.Consultas
{
    public partial class Consultar_Articulos : Form
    {
        public Consultar_Articulos()
        {
            InitializeComponent();
        }

        private void Consultar_Productos_Load(object sender, EventArgs e)
        {

        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejm = 0;

            if(error == 1 && int.TryParse(Criterio_textBox.Text, out ejm) == false)
            {
                Criterio_errorProvider.SetError(Criterio_textBox, "Debe Ingresar un Numero");
                paso = true;
            }
            if(error == 2 && int.TryParse(Criterio_textBox.Text, out ejm) == true)
            {
                Criterio_errorProvider.SetError(Criterio_textBox, "Debe Ingresar un Caracter");
                paso = true;
            }
            return paso;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = x => true;

            int id,ex,cc;
            Decimal precio;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0://ID Articulo
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = x => x.ArticuloId == id;
                    break;
                case 1://Descripcion
                    filtro = x => x.Descripcion.Equals(Criterio_textBox.Text);
                    break;
                case 2://Precio
                    precio = Convert.ToDecimal(Criterio_textBox.Text);
                    filtro = x => x.Precio == precio;
                    break;
                case 3://Existencia
                    ex = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = x => x.Existencia == ex;
                    break;
                case 4://Cantidad Cotizada
                    cc = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = x => x.CantCotizada == cc;
                    break;
            }

            Consulta_dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void Consultar_Articulos_Load(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }
    }
}
