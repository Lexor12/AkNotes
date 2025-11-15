using AkNotes.Models;
using AkNotes.Services;
using AkNotes.Views.UserControls;

namespace AkNotes
{
    public partial class MainForm : Form
    {
        public MainForm()//Mady by Lexor_12 || kennygamer17 on github
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
        }//Mady by Lexor_12 || kennygamer17 on github
        private void MostrarPantallaRegistro()
        {
            UCIniciarSesionCrearUsuario uc = new UCIniciarSesionCrearUsuario(UIUCIniciarSesionCrearUsuarioOpciones.Registro);//Mady by Lexor_12 || kennygamer17 on github
            uc.Dock = DockStyle.Fill;

            uc.BotonAceptarPresionado += OnRegistrarAceptar;
            uc.BotonCambiarAOtroFormPresionado += OnCambiarPantalla;
            CargarControl(uc);
        }
        private void OnLoginAceptar(UCIniciarSesionCrearUsuario modo)
        {
            try
            {
                if (!esIngresoUsername(modo.txtUsuario.Text))
                {
                    MessageBox.Show("Error, el nombre de ususario debe ser mayor a 5 caracteres y solo puede contener letras,números, '@' o '_'.");
                    return;
                }
                if (!esIngresoContraseña(modo.txtContrasena.Text))
                {
                    MessageBox.Show("Error, la contraseña debe ser mayor a 8 caracteres y estos deben ser números, letras, '@' o '_'.");
                    return;
                }
                if (UsuarioDBManager.UsuarioYaExisteNombre(modo.txtUsuario.Text))//Mady by Lexor_12 || kennygamer17 on github
                {
                    if (UsuarioDBManager.UsuarioYaExiste(modo.txtUsuario.Text, modo.txtContrasena.Text))
                    {
                        Usuario usuario = UsuarioDBManager.IniciarSesion(modo.txtUsuario.Text, modo.txtContrasena.Text);
                        GestorBase uc = new GestorBase(usuario);
                        uc.CerrarSesionEsPresionado += MostrarPantallaLogin;//Mady by Lexor_12 || kennygamer17 on github
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
                        return;//Mady by Lexor_12 || kennygamer17 on github
                    }
                }
                else
                {
                    MessageBox.Show("Error, usuario no encontrado.");
                    return;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Un error inesperado ha ocurrido, vuelve a intentarlo mas tarde.");
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
        private bool esIngresoUsername(string ingreso)
        {
            if (ingreso.Length < 5)
            {
                return false;
            }
            foreach (var usuario in ingreso)
            {
                if (!Char.IsLetter(usuario) && !Char.IsNumber(usuario) && usuario != '_') return false;
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
            try
            {
                if (!esIngresoUsername(modo.txtUsuario.Text))
                {
                    MessageBox.Show("Error, el nombre de ususario debe ser mayor a 5 caracteres y solo puede contener letras,números, '@' o '_'.");
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
                if(modo.txtContrasena.Text != modo.txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Error, la contraseña no es igual en ambos campos de contraseña.");
                }
                else
                {
                    UsuarioDBManager.CrearUsuario(modo.txtUsuario.Text, modo.txtContrasena.Text);
                    MostrarPantallaLogin();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un error inesperado ha ocurrido, vuelve a intentarlo mas tarde.");
            }
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
            this.Controls.Add(control);//Mady by Lexor_12 || kennygamer17 on github
            this.ResumeLayout(true);
            this.Refresh();//Mady by Lexor_12 || kennygamer17 on github
        }
    }
}
