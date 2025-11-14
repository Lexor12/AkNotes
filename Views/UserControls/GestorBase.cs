using AkNotes.Models;
using AkNotes.Views.UserControls.Main;
using Microsoft.VisualBasic;
using System;
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
    internal partial class GestorBase : UserControl
    {
        public event Action CerrarSesionEsPresionado = delegate { };
        public event Action SalirEsPresionado = delegate { };
        private Usuario Usuario;
        NotasManager manager;//Mady by Lexor_12 || kennygamer17 on github
        public GestorBase(Usuario _Usuario)//Mady by Lexor_12 || kennygamer17 on github
        {
            Usuario = _Usuario;
            manager = new NotasManager(Usuario);
            InitializeComponent();
            lblNombreUsuario.Text = Usuario.Username;
            int i = manager.GetTodasLasNotas().Count();
            UCInicio uCInicio = new UCInicio(i.ToString());
            this.PanelMain.Controls.Add(uCInicio);
        }
        private void EditarNota(Nota _a)
        {
            UCGestorNota uc = new UCGestorNota(UCGestorNotaOpciones.Editar, _a);
            uc.btnAceptarEditarPresionado += (nota) =>
            {
                manager.ModificarNota(nota);//Mady by Lexor_12 || kennygamer17 on github
                ListarNotas();
            };
            uc.username = Usuario.Username;
            AgregarControlAMain(uc);
        }
        private void SeccionInicio()//Mady by Lexor_12 || kennygamer17 on github
        {
            int i = manager.GetTodasLasNotas().Count();
            UCInicio uCInicio = new UCInicio(i.ToString());
            AgregarControlAMain(uCInicio);
        }
        private void VerNota(Nota a)
        {
            UCGestorNota uc = new UCGestorNota(UCGestorNotaOpciones.Ver, a);
            uc.username = Usuario.Username;
            uc.btnAceptarVolverPresionado += ListarNotas;
            AgregarControlAMain(uc);//Mady by Lexor_12 || kennygamer17 on github
        }
        private void CrearNota()
        {
            UCGestorNota uCInicio = new UCGestorNota(UCGestorNotaOpciones.Crear);
            uCInicio.username = Usuario.Username;
            uCInicio.btnAceptarPresionado += CrearNota;
            AgregarControlAMain(uCInicio);
        }
        private void ListarNotas()
        {
            UCListaNotas uCInicio = new UCListaNotas(manager);
            uCInicio.EditarNotaPresionado += (a) =>
            {
                EditarNota(a);
            };
            uCInicio.VerNotaPresionado += (a) =>
            {
                VerNota(a);
            };//Mady by Lexor_12 || kennygamer17 on github
            AgregarControlAMain(uCInicio);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            SeccionInicio();//Mady by Lexor_12 || kennygamer17 on github
        }
        private void AgregarControlAMain(UserControl control)
        {
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(control);
        }

        private void btnCrearNota_Click(object sender, EventArgs e)
        {
            CrearNota();//Mady by Lexor_12 || kennygamer17 on github
        }

        private void btnListarNotas_Click(object sender, EventArgs e)
        {
            ListarNotas();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionEsPresionado.Invoke();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SalirEsPresionado.Invoke();
        }
        private void CrearNota(UCGestorNota uc)
        {
            string titulo = uc.txtTitulo.Text;
            string contenido = uc.txtContenido.Text;
            string notaTexto = uc.txtNota.Text;
            List<string> tags = uc.ObtenerTags(); //Mady by Lexor_12 || kennygamer17 on github
            bool preferencia = uc.rdbtnImportante.Checked;
            Compartir compartir = new Compartir();
            List<string> strings = new List<string>();
            if (uc.rdbPublico.Checked) compartir = Compartir.Publico;
            else if (uc.rdbCodigo.Checked) compartir = Compartir.Codigo;
            else if (uc.rdbPrivado.Checked) compartir = Compartir.Privado;
            else if (uc.rdbLisUsuarios.Checked)
            {
                compartir = Compartir.Compartir;
                foreach (string user in uc.Usuarios)
                {
                    strings.Add(user);
                }
            }
            manager.CrearNota(titulo, contenido, notaTexto, tags, preferencia, compartir, strings);

            MessageBox.Show("Tarea creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarNotas();//Mady by Lexor_12 || kennygamer17 on github
        }
    }
}
