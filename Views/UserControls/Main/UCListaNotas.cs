using AkNotes.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkNotes.Views.UserControls
{
    internal partial class UCListaNotas : UserControl
    {

        private BindingList<Nota> notas = new BindingList<Nota>();
        NotasManager manager;
        public event Action<Nota> EditarNotaPresionado = delegate { };
        public event Action<Nota> VerNotaPresionado = delegate { };
        public UCListaNotas(NotasManager manager)
        {
            this.manager = manager;
            InitializeComponent();
            ConfigurarDataGridView();
            RecargarNotas(manager.GetTodasLasNotas());
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            List<Nota> list = manager.GetTodasLasNotas();
            RecargarNotas(list);
        }
        private void RecargarNotas(List<Nota> lista)
        {
            notas.Clear();
            dataGriedListaNotas.Controls.Clear();
            foreach (var nota in lista)
            {
                notas.Add(nota);
            }
            dataGriedListaNotas.DataSource = notas;
        }
        private void ConfigurarDataGridView()
        {
            dataGriedListaNotas.Columns.Clear();
            dataGriedListaNotas.AutoGenerateColumns = false;
            dataGriedListaNotas.RowTemplate.Height = 55;
            dataGriedListaNotas.ColumnHeadersHeight = 40;
            dataGriedListaNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "colTitulo";
            colTitulo.HeaderText = "Titulo:";
            colTitulo.DataPropertyName = "Titulo";
            colTitulo.FillWeight = 70;
            dataGriedListaNotas.Columns.Add(colTitulo);
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "colFecha";
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "FechaCreacion";
            colFecha.FillWeight = 30;
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            colFecha.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGriedListaNotas.Columns.Add(colFecha);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGriedListaNotas.SelectedRows.Count > 0)
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                manager.EliminarNota(notaSeleccionada);
                RecargarNotas(manager.GetTodasLasNotas());

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGriedListaNotas.SelectedRows.Count > 0)
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                EditarNotaPresionado.Invoke(notaSeleccionada);
            }
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            if (dataGriedListaNotas.SelectedRows.Count > 0)
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                VerNotaPresionado.Invoke(notaSeleccionada);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string buscadorTexto = txtBuscar.Text;
            var notas = manager.GetTodasLasNotas();
            List<Nota> lista = new List<Nota>();
            foreach (Nota nota in notas) 
            {
                if (nota.Titulo.ToLower().Contains(buscadorTexto.ToLower())) lista.Add(nota);
            }
            RecargarNotas(lista);
        }
    }
}
