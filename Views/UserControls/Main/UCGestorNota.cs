using AkNotes.Models;
using AkNotes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AkNotes.Views.UserControls.Main
{//Mady by Lexor_12 || kennygamer17 on github
    internal enum UCGestorNotaOpciones
    {
        Crear,
        Editar,
        Ver//Mady by Lexor_12 || kennygamer17 on github
    }
    internal partial class UCGestorNota : UserControl
    {//Mady by Lexor_12 || kennygamer17 on github
        UCGestorNotaOpciones modo;
        private List<string> tagsSeleccionados = new List<string>();
        public event Action<UCGestorNota> btnAceptarPresionado = delegate { };
        public event Action<Nota> btnAceptarEditarPresionado = delegate { };
        public event Action btnAceptarVolverPresionado = delegate { };//Mady by Lexor_12 || kennygamer17 on github
        public Nota _nota;
        public string username;
        public BindingList<string> Usuarios = new BindingList<string>();
        public UCGestorNota(UCGestorNotaOpciones modo, Nota _nota = null,string username = "")
        {
            this.username = username;
            this.modo = modo;
            this._nota = _nota;
            InitializeComponent();
            ConfigurarDataGridView();
            dgListaUsuarios.DataSource = Usuarios;
            if (modo == UCGestorNotaOpciones.Ver) VistaDetalladaModo();
            else if (modo == UCGestorNotaOpciones.Editar) EditarModo();
            lblFechaCreacion.Text = DateTime.Now.ToString();
            lblFechaEdicion.Text = DateTime.Now.ToString();
        }//Mady by Lexor_12 || kennygamer17 on github
        private void VistaDetalladaModo()
        {
            lblTituloUC.Text = "Vista detallada";
            lblTituloUC.Font = new Font("Segoe UI", 54F, FontStyle.Bold);
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
            lblCodigo.Text = _nota.ID;
            lblCodigo.Enabled = true;
            rdbCodigo.Checked = false;
            rdbPrivado.Checked = false;
            rdbPublico.Checked = false;
            rdbLisUsuarios.Checked = false;
            if (_nota.Compartir == Compartir.Publico) rdbPublico.Checked = true;
            else if (_nota.Compartir == Compartir.Privado) rdbPrivado.Checked = true;
            else if (_nota.Compartir == Compartir.Codigo) rdbCodigo.Checked = true;
            else if (_nota.Compartir == Compartir.Compartir)
            {
                rdbLisUsuarios.Checked = true;

                foreach (string a in _nota.UsuariosUsername)
                {
                    Usuarios.Add(a);

                }
                panelUsuario.Visible = true;
                panelUsuario.Enabled = false;
                txtNombreUsuario.Enabled = false;
                dgListaUsuarios.Enabled = true;
                btnAgregarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
            }
            rdbLisUsuarios.Enabled = false;
            rdbCodigo.Enabled = false;
            rdbPrivado.Enabled = false;
            rdbPublico.Enabled = false;

            Usuario usuario = AkNotesBDConnector.GetInstancia().GetUsuarioID(_nota.UsuarioId);
            lblNombreUsuario.Text = usuario.Username;
            panelUsuario.Enabled = true;
            panelUsuario.Enabled = Visible;

        }//Mady by Lexor_12 || kennygamer17 on github
        private void EditarModo()
        {
            lblTituloUC.Text = "Editar nota";
            lblTituloUC.Font = new Font("Segoe UI", 58F, FontStyle.Bold);
            btnAceptar.Text = "Aceptar y editar";//Mady by Lexor_12 || kennygamer17 on github

            txtTitulo.Text = _nota.Titulo;

            txtContenido.Text = _nota.Contenido;

            txtNota.Text = _nota._Nota;//Mady by Lexor_12 || kennygamer17 on github

            rdbtnImportante.Checked = _nota.Preferencia;
            rdbtnNoImportante.Checked = !_nota.Preferencia;

            lblFechaCreacion.Text = _nota.FechaCreacion.ToString();
            lblFechaEdicion.Text = DateTime.Now.ToString();


            // Marcar los tags de la nota
            foreach (string tag in _nota.Tags)//Mady by Lexor_12 || kennygamer17 on github
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
                    //Mady by Lexor_12 || kennygamer17 on github
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
                        break;//Mady by Lexor_12 || kennygamer17 on github

                    default:
                        Console.WriteLine($"Error, tag no encontrado: {tag}");
                        break;
                }
            }
            rdbCodigo.Checked = false;
            rdbPrivado.Checked = false;
            rdbPublico.Checked = false;
            rdbLisUsuarios.Checked = false;
            if (_nota.Compartir == Compartir.Publico) rdbPublico.Checked = true;
            else if (_nota.Compartir == Compartir.Privado) rdbPrivado.Checked = true;
            else if (_nota.Compartir == Compartir.Codigo) rdbCodigo.Checked = true;
            else if (_nota.Compartir == Compartir.Compartir)
            {
                rdbLisUsuarios.Checked = true;

                foreach (string a in _nota.UsuariosUsername)
                {
                    Usuarios.Add(a);

                }
                panelUsuario.Visible = true;
                panelUsuario.Enabled = true;
            }
            rdbLisUsuarios.Enabled = true;
            rdbCodigo.Enabled = true;
            rdbPrivado.Enabled = true;
            rdbPublico.Enabled = true;

            panelUsuario.Enabled = true;
            panelUsuario.Enabled = Visible;
            Usuario usuario = AkNotesBDConnector.GetInstancia().GetUsuarioID(_nota.UsuarioId);
            lblNombreUsuario.Text = usuario.Username;
            lblCodigo.Text = _nota.ID;
            lblCodigo.Enabled = true;
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
                _nota.Titulo = txtTitulo.Text;//Mady by Lexor_12 || kennygamer17 on github
                _nota.Contenido = txtContenido.Text;
                _nota._Nota = txtNota.Text;
                _nota.Tags = ObtenerTags();//Mady by Lexor_12 || kennygamer17 on github
                _nota.Preferencia = rdbtnImportante.Checked;
                _nota.FechaModificacion = DateTime.Now.ToString();
                if (rdbPublico.Checked) _nota.Compartir = Compartir.Publico;
                else if (rdbCodigo.Checked) _nota.Compartir = Compartir.Codigo;
                else if (rdbPrivado.Checked) _nota.Compartir = Compartir.Privado;
                else if (rdbLisUsuarios.Checked)
                {
                    _nota.Compartir = Compartir.Compartir;
                    List<string> strings = new List<string>();
                    foreach (string user in Usuarios)
                    {
                        strings.Add(user);
                    }
                    _nota.UsuariosUsername = strings;
                }
                btnAceptarEditarPresionado.Invoke(_nota);
            }
            if (modo == UCGestorNotaOpciones.Ver) btnAceptarVolverPresionado.Invoke();
        }//Mady by Lexor_12 || kennygamer17 on github
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

        private void lblCodigo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblCodigo.Text);
            MessageBox.Show("Texto copiado al portapapeles", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLisUsuarios.Checked)
            {
                panelUsuario.Enabled = true;
                panelUsuario.Visible = true;
                return;
            }
            panelUsuario.Enabled = false;
            panelUsuario.Visible = false;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!AkNotesBDConnector.GetInstancia().UsuarioExisteNombre(txtNombreUsuario.Text))
            {
                MessageBox.Show("ERROR: Usuario No Encontrado");
            }
            else
            {
                if (Usuarios.Contains(txtNombreUsuario.Text))
                {
                    MessageBox.Show("ERROR: Ese usuario ya esta dentro.");
                    return;
                }
                if (txtNombreUsuario.Text == username)
                {
                    MessageBox.Show("ERROR: No puede agregarte a ti mismo.");
                    return;
                }
                Usuarios.Add(txtNombreUsuario.Text);
            }
        }
        private void ConfigurarDataGridView()
        {
            dgListaUsuarios.Columns.Clear();
            dgListaUsuarios.AutoGenerateColumns = false; // ← Mantener en false

            // Ajustes visuales
            dgListaUsuarios.RowTemplate.Height = 40;
            dgListaUsuarios.ColumnHeadersHeight = 35;
            dgListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListaUsuarios.MultiSelect = false;
            dgListaUsuarios.ReadOnly = true;
            dgListaUsuarios.AllowUserToAddRows = false;
            dgListaUsuarios.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "colUsuario";
            col.HeaderText = "Usuario Compartido";
            // NO pongas DataPropertyName

            dgListaUsuarios.Columns.Add(col);

            // Agregar este evento
            dgListaUsuarios.CellFormatting += DgListaUsuarios_CellFormatting;
        }

        // Agregar este método nuevo
        private void DgListaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Usuarios.Count)
            {
                e.Value = Usuarios[e.RowIndex];
                e.FormattingApplied = true;
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgListaUsuarios.SelectedRows.Count > 0)
            {
                int indice = dgListaUsuarios.SelectedRows[0].Index;

                if (indice >= 0 && indice < Usuarios.Count)
                {
                    Usuarios.RemoveAt(indice); // ← Usar RemoveAt en lugar de Remove
                }
            }

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
