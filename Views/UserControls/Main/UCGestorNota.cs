using AkNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkNotes.Views.UserControls.Main
{
    internal enum UCGestorNotaOpciones
    {
        Crear,
        Editar,
        Ver
    }
    internal partial class UCGestorNota : UserControl
    {
        UCGestorNotaOpciones modo;
        private List<string> tagsSeleccionados = new List<string>();
        public event Action<UCGestorNota> btnAceptarPresionado = delegate { };
        public event Action<Nota> btnAceptarEditarPresionado = delegate { };
        public event Action btnAceptarVolverPresionado = delegate { };
        Nota _nota;
        public UCGestorNota(UCGestorNotaOpciones modo, Nota _nota = null)
        {
            this.modo = modo;
            this._nota = _nota;
            InitializeComponent();
            if (modo == UCGestorNotaOpciones.Ver) VistaDetalladaModo();
            else if (modo == UCGestorNotaOpciones.Editar) EditarModo();
        }
        private void VistaDetalladaModo()
        {
            lblTituloUC.Text = "Vista detallada";
            txtTitulo.Enabled = false;
            txtTitulo.Text = _nota.Titulo;

            txtContenido.Enabled = false;
            txtContenido.Text = _nota.Contenido;

            txtNota.Enabled = false;
            txtNota.Text = _nota._Nota;

            rdbtnImportante.Checked = _nota.Preferencia;
            rdbtnImportante.Enabled = false;
            rdbtnNoImportante.Checked = !_nota.Preferencia;
            rdbtnNoImportante.Enabled = false;

            lblFechaCreacion.Text = _nota.FechaCreacion.ToString();
            lblFechaEdicion.Text = _nota.FechaModificacion.ToString();
            foreach (string tag in _nota.Tags)
            {
                switch (tag.ToLower())
                {
                    case "idea":
                        ckbIdea.Checked = true;
                        break;

                    case "hogar":
                        ckbHogar.Checked = true;
                        break;

                    case "pendiente":
                        ckbPendiente.Checked = true;
                        break;

                    case "completado":
                        ckbCompletado.Checked = true;
                        break;

                    case "planificación":
                        ckbPlanificacion.Checked = true;
                        break;

                    case "proyecto":
                        ckbProyecto.Checked = true;
                        break;

                    case "urgente":
                        ckbUrgente.Checked = true;
                        break;

                    case "tarea":
                        ckbTarea.Checked = true;
                        break;

                    case "recordatorio":
                        ckbRecordatorio.Checked = true;
                        break;

                    case "contacto":
                        ckbContacto.Checked = true;
                        break;

                    case "inspiración":
                        ckbInspiracion.Checked = true;
                        break;

                    case "trabajo":
                        ckbTrabajo.Checked = true;
                        break;

                    default:
                        Console.WriteLine($"Tag desconocido: {tag}");
                        break;
                }
            }
            ckbIdea.Enabled = false;
            ckbHogar.Enabled = false;
            ckbPendiente.Enabled = false;
            ckbCompletado.Enabled = false;
            ckbPlanificacion.Enabled = false;
            ckbProyecto.Enabled = false;
            ckbUrgente.Enabled = false;
            ckbTarea.Enabled = false;
            ckbRecordatorio.Enabled = false;
            ckbContacto.Enabled = false;
            ckbInspiracion.Enabled = false;
            ckbTrabajo.Enabled = false;
            btnAceptar.Text = "Volver";

        }
        private void EditarModo()
        {
            lblTituloUC.Text = "Editar nota";
            btnAceptar.Text = "Aceptar y editar";

            txtTitulo.Text = _nota.Titulo;

            txtContenido.Text = _nota.Contenido;

            txtNota.Text = _nota._Nota;

            rdbtnImportante.Checked = _nota.Preferencia;
            rdbtnNoImportante.Checked = !_nota.Preferencia;

            lblFechaCreacion.Text = _nota.FechaCreacion.ToString();
            lblFechaEdicion.Text = DateTime.Now.ToString();


            // Marcar los tags de la nota
            foreach (string tag in _nota.Tags)
            {
                switch (tag.ToLower())
                {
                    case "idea":
                        ckbIdea.Checked = true;
                        break;

                    case "hogar":
                        ckbHogar.Checked = true;
                        break;

                    case "pendiente":
                        ckbPendiente.Checked = true;
                        break;

                    case "completado":
                        ckbCompletado.Checked = true;
                        break;

                    case "planificación":
                        ckbPlanificacion.Checked = true;
                        break;

                    case "proyecto":
                        ckbProyecto.Checked = true;
                        break;

                    case "urgente":
                        ckbUrgente.Checked = true;
                        break;

                    case "tarea":
                        ckbTarea.Checked = true;
                        break;

                    case "recordatorio":
                        ckbRecordatorio.Checked = true;
                        break;

                    case "contacto":
                        ckbContacto.Checked = true;
                        break;

                    case "inspiración":
                        ckbInspiracion.Checked = true;
                        break;

                    case "trabajo":
                        ckbTrabajo.Checked = true;
                        break;

                    default:
                        Console.WriteLine($"Error, tag no encontrado: {tag}");
                        break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == string.Empty || txtContenido.Text == string.Empty)
            {
                MessageBox.Show("Debes llenar el campo de Titulo y contenido");
                return;
            }
            btnAceptarPresionado.Invoke(this);
            if (modo == UCGestorNotaOpciones.Editar)
            {
                _nota.Titulo = txtTitulo.Text;
                _nota.Contenido = txtContenido.Text;
                _nota._Nota = txtNota.Text;
                _nota.Tags =ObtenerTags();
                _nota.Preferencia = rdbtnImportante.Checked;
                _nota.FechaModificacion = DateTime.Now.ToString();
                btnAceptarEditarPresionado.Invoke(_nota);
            }
            if (modo == UCGestorNotaOpciones.Ver) btnAceptarVolverPresionado.Invoke();
        }
        public List<string> ObtenerTags()
        {
            List<string> tagsSeleccionados = new List<string>();

            if (ckbIdea.Checked)
                tagsSeleccionados.Add("Idea");

            if (ckbHogar.Checked)
                tagsSeleccionados.Add("Hogar");

            if (ckbPendiente.Checked)
                tagsSeleccionados.Add("Pendiente");

            if (ckbCompletado.Checked)
                tagsSeleccionados.Add("Completado");

            if (ckbPlanificacion.Checked)
                tagsSeleccionados.Add("Planificación");

            if (ckbProyecto.Checked)
                tagsSeleccionados.Add("Proyecto");

            if (ckbUrgente.Checked)
                tagsSeleccionados.Add("Urgente");

            if (ckbTarea.Checked)
                tagsSeleccionados.Add("Tarea");

            if (ckbRecordatorio.Checked)
                tagsSeleccionados.Add("Recordatorio");

            if (ckbContacto.Checked)
                tagsSeleccionados.Add("Contacto");

            if (ckbInspiracion.Checked)
                tagsSeleccionados.Add("Inspiración");

            if (ckbTrabajo.Checked)
                tagsSeleccionados.Add("Trabajo");
            return tagsSeleccionados;
        }

    }
}
