﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroCotizacionCompleto.UI;
using RegistroCotizacionCompleto.UI.Registros;

namespace RegistroCotizacionCompleto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void agregarCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizacion view = new RegistroCotizacion();
            view.Show();
        }
    }
}
