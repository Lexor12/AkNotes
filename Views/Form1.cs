using AkNotes.Models;

namespace AkNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UsuarioDBManager.CrearUsuario("Prueba","12345");
        }
    }
}
