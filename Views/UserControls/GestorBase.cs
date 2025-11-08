using AkNotes.Models;
using AkNotes.Views.UserControls.Main;
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
        NotasManager manager;
        public GestorBase(Usuario _Usuario)
        {
            Usuario = _Usuario;
            manager = new NotasManager(Usuario);
            InitializeComponent();
            int i = manager.GetTodasLasNotas().Count();
            UCInicio uCInicio = new UCInicio(i.ToString());
            this.PanelMain.Controls.Add(uCInicio);
        }
        private void EditarNota(Nota _a)
        {
            UCGestorNota uc = new UCGestorNota(UCGestorNotaOpciones.Editar, _a);
            uc.btnAceptarEditarPresionado += (nota) =>
            {
                manager.ModificarNota(nota);
                ListarNotas();
            };
            AgregarControlAMain(uc);
        }
        private void SeccionInicio()
        {
            int i = manager.GetTodasLasNotas().Count();
            UCInicio uCInicio = new UCInicio(i.ToString());
            AgregarControlAMain(uCInicio);
        }
        private void VerNota(Nota a)
        {
            UCGestorNota uc = new UCGestorNota(UCGestorNotaOpciones.Ver, a);
            uc.btnAceptarVolverPresionado += ListarNotas;
            AgregarControlAMain(uc);
        }
        private void CrearNota()
        {
            UCGestorNota uCInicio = new UCGestorNota(UCGestorNotaOpciones.Crear);
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
            };
            AgregarControlAMain(uCInicio);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            SeccionInicio();
        }
        private void AgregarControlAMain(UserControl control)
        {
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(control);
        }

        private void btnCrearNota_Click(object sender, EventArgs e)
        {
            CrearNota();
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
            List<string> tags = uc.ObtenerTags(); 
            bool preferencia = uc.rdbtnImportante.Checked; 
            manager.CrearNota(titulo, contenido, notaTexto, tags, preferencia);

            MessageBox.Show("Tarea creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarNotas();
        }
    }
}
