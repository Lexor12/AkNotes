using AkNotes.Models;
using AkNotes.Services;
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
//Mady by Lexor_12 || kennygamer17 on github
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
            if (radioButton1.Checked)
            {
                var notas = manager.GetTodasLasNotas();
                RecargarNotas(notas);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            if (radioButton2.Checked)
            {
                var notas = manager.GetTodasLasNotasCompartidas();
                RecargarNotas(notas);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            if (radioButton4.Checked)
            {
                RecargarNotas(AkNotesBDConnector.GetInstancia().GetListaDeNotasPublicas());
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private void RecargarNotas(List<Nota> lista)
        {//Mady by Lexor_12 || kennygamer17 on github
            notas.Clear();
            dataGriedListaNotas.Controls.Clear();
            foreach (var nota in lista)
            {
                notas.Add(nota);
            }
            dataGriedListaNotas.DataSource = notas;//Mady by Lexor_12 || kennygamer17 on github
        }
        private void ConfigurarDataGridView()
        {
            dataGriedListaNotas.Columns.Clear();//Mady by Lexor_12 || kennygamer17 on github
            dataGriedListaNotas.AutoGenerateColumns = false;
            dataGriedListaNotas.RowTemplate.Height = 55;
            dataGriedListaNotas.ColumnHeadersHeight = 40;
            dataGriedListaNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "colTitulo";//Mady by Lexor_12 || kennygamer17 on github
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
            dataGriedListaNotas.Columns.Add(colFecha);//Mady by Lexor_12 || kennygamer17 on github
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGriedListaNotas.SelectedRows.Count > 0)//Mady by Lexor_12 || kennygamer17 on github
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                manager.EliminarNota(notaSeleccionada);
                btnRecargar_Click(sender,e);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {//Mady by Lexor_12 || kennygamer17 on github
            if (dataGriedListaNotas.SelectedRows.Count > 0)
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                EditarNotaPresionado.Invoke(notaSeleccionada);
                btnRecargar_Click(sender, e);
            }
        }

        private void btnVista_Click(object sender, EventArgs e)
        {//Mady by Lexor_12 || kennygamer17 on github
            if (dataGriedListaNotas.SelectedRows.Count > 0)
            {
                Nota notaSeleccionada = (Nota)dataGriedListaNotas.SelectedRows[0].DataBoundItem;
                VerNotaPresionado.Invoke(notaSeleccionada);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Nota> listaFiltrada = new List<Nota>() ;
            if (radioButton1.Checked)
            {
                var notasA = manager.GetTodasLasNotas();
                 listaFiltrada = notasA.Where(n => n.Titulo.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
            }
            if (radioButton2.Checked)
            {
                var notasA = manager.GetTodasLasNotasCompartidas();
                 listaFiltrada = notasA.Where(n => n.Titulo.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
            }
            if (radioButton4.Checked)
            {
                var notasA = AkNotesBDConnector.GetInstancia().GetListaDeNotasPublicas();
                listaFiltrada = notasA.Where(n => n.Titulo.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
            }
            RecargarNotas(listaFiltrada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length != 24)
            {
                MessageBox.Show("Código incorrecto.");
            }
            else
            {
                Nota nota = AkNotesBDConnector.GetInstancia().GetNotaPorIDNota(txtBuscar.Text);
                if (nota != null)
                {
                    VerNotaPresionado.Invoke(nota);
                }
                else
                {
                    MessageBox.Show("Nota no encontrada.");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var notas = manager.GetTodasLasNotas();
                RecargarNotas(notas);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                RecargarNotas(AkNotesBDConnector.GetInstancia().GetListaDeNotasPublicas());
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;    
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var notas = manager.GetTodasLasNotasCompartidas();
                RecargarNotas(notas);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = false;
            }
        }
    }
}
