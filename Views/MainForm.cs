using AkNotes.Models;
using AkNotes.Views.UserControls;

namespace AkNotes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MostrarPantallaLogin();
        }
        private void MostrarPantallaLogin()
        {
            UCIniciarSesionCrearUsuario uc = new UCIniciarSesionCrearUsuario(UIUCIniciarSesionCrearUsuarioOpciones.IniciarSesion);
            uc.Dock = DockStyle.Fill;

            uc.BotonAceptarPresionado += OnLoginAceptar;
            uc.BotonCambiarAOtroFormPresionado += OnCambiarPantalla;

            CargarControl(uc);
        }
        private void MostrarPantallaRegistro()
        {
            UCIniciarSesionCrearUsuario uc = new UCIniciarSesionCrearUsuario(UIUCIniciarSesionCrearUsuarioOpciones.Registro);
            uc.Dock = DockStyle.Fill;

            uc.BotonAceptarPresionado += OnRegistrarAceptar;
            uc.BotonCambiarAOtroFormPresionado += OnCambiarPantalla;
            CargarControl(uc);
        }
        private void OnLoginAceptar(UCIniciarSesionCrearUsuario modo)
        {
            if (UsuarioDBManager.UsuarioYaExisteNombre(modo.txtUsuario.Text))
            {
                if (UsuarioDBManager.UsuarioYaExiste(modo.txtUsuario.Text, modo.txtContrasena.Text))
                {
                    Usuario usuario = UsuarioDBManager.IniciarSesion(modo.txtUsuario.Text, modo.txtContrasena.Text);
                    GestorBase uc = new GestorBase(usuario);
                    uc.CerrarSesionEsPresionado += MostrarPantallaLogin;
                    uc.SalirEsPresionado += () =>
                    {
                        this.Close();
                    };
                    uc.Dock = DockStyle.Fill;
                    CargarControl(uc);
                }
                else
                {
                    MessageBox.Show("Error, usuario no encontrado.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error, usuario no encontrado.");
                return;
            }
        }
        private bool esIngresoCaracter(string ingreso)
        {
            if (ingreso.Length < 5)
            {
                return false;
            }
            foreach (var usuario in ingreso)
            {
                if(!Char.IsLetter(usuario))return false;
            }
            return true;
        }
        private bool esIngresoContraseña(string ingreso)
        {
            if (ingreso.Length < 8)
            {
                return false;
            }
            foreach (var usuario in ingreso)
            {
                if (!Char.IsLetter(usuario) && !Char.IsNumber(usuario)&&usuario!='_' && usuario != '@') return false;
            }
            return true;
        }
        private void OnRegistrarAceptar(UCIniciarSesionCrearUsuario modo)
        {
            if (!esIngresoCaracter(modo.txtUsuario.Text))
            {
                MessageBox.Show("Error, el nombre de ususario debe ser mayor a 5 caracteres y solo puede contener letras.");
                return;
            }
            if (!esIngresoContraseña(modo.txtContrasena.Text))
            {
                MessageBox.Show("Error, la contraseña debe ser mayor a 8 caracteres y estos deben ser números, letras, '@' o '_'.");
                return;
            }
            if (UsuarioDBManager.UsuarioYaExisteNombre(modo.txtUsuario.Text))
            {
                MessageBox.Show("Error, ese nombré de usuario ya existe.");
                return;
            }
            else
            {
                UsuarioDBManager.CrearUsuario(modo.txtUsuario.Text, modo.txtContrasena.Text);
            }
            MostrarPantallaLogin();
        }
        private void OnCambiarPantalla(UCIniciarSesionCrearUsuario modo)
        {
            if (UIUCIniciarSesionCrearUsuarioOpciones.IniciarSesion == modo.modoActual) MostrarPantallaRegistro();
            else if (modo.modoActual == UIUCIniciarSesionCrearUsuarioOpciones.Registro)MostrarPantallaLogin();
        }
        private void CargarControl(UserControl control)
        {
            this.SuspendLayout();
            this.Controls.Clear();
            this.Controls.Add(control);
            this.ResumeLayout(true);
            this.Refresh();
        }
    }
}
