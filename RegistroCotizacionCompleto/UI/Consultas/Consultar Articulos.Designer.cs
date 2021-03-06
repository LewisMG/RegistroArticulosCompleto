﻿namespace RegistroCotizacionCompleto.UI.Consultas
{
    partial class Consultar_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.Criterio_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterio_errorProvider)).BeginInit();
            this.Fechaspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(12, 90);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.Size = new System.Drawing.Size(776, 348);
            this.Consulta_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "ID Articulo",
            "Descripcion",
            "Precio",
            "Existencia",
            "Cantidad Cotizada"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(49, 13);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Filtro_comboBox.TabIndex = 1;
            this.Filtro_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filtro_comboBox_SelectedIndexChanged);
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(234, 13);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(187, 20);
            this.Criterio_textBox.TabIndex = 2;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = global::RegistroCotizacionCompleto.Properties.Resources.icons8_Search_Property_32;
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Consultar.Location = new System.Drawing.Point(696, 12);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(92, 49);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Criterio_errorProvider
            // 
            this.Criterio_errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filtar por Rango de Fecha:";
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechaspanel.Controls.Add(this.Hasta_dateTimePicker);
            this.Fechaspanel.Controls.Add(this.label5);
            this.Fechaspanel.Controls.Add(this.Desde_dateTimePicker);
            this.Fechaspanel.Controls.Add(this.label6);
            this.Fechaspanel.Location = new System.Drawing.Point(154, 55);
            this.Fechaspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(391, 30);
            this.Fechaspanel.TabIndex = 22;
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(247, 6);
            this.Hasta_dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.Hasta_dateTimePicker.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hasta";
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(41, 6);
            this.Desde_dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.Desde_dateTimePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde";
            // 
            // Consultar_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.Filtro_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Name = "Consultar_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Articulos";
            this.Load += new System.EventHandler(this.Consultar_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterio_errorProvider)).EndInit();
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.ErrorProvider Criterio_errorProvider;
        private System.Windows.Forms.Panel Fechaspanel;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}