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
    public enum UIUCIniciarSesionCrearUsuarioOpciones
    {
        IniciarSesion,
        Registro
    }
    public partial class UCIniciarSesionCrearUsuario : UserControl
    {
        //Atributos / Componentes//Mady by Lexor_12 || kennygamer17 on github
        public event Action<UCIniciarSesionCrearUsuario> BotonAceptarPresionado = delegate { };
        public event Action<UCIniciarSesionCrearUsuario> BotonCambiarAOtroFormPresionado = delegate { };
        private Panel panelIzquierdo;
        private Panel panelDerecho;
        private Label lblTituloPrincipal;
        private Label lblDescripcion;
        private Button btnCambiarVentana;
        private Label lblInvitacionCambio;
        private Label lblUsuario;
        private Label lblTituloFormulario;
        public TextBox txtContrasena;
        public TextBox txtUsuario;
        private Label lblContrasena;
        private Button btnAceptar;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        public UIUCIniciarSesionCrearUsuarioOpciones modoActual;
        public UCIniciarSesionCrearUsuario(UIUCIniciarSesionCrearUsuarioOpciones modo)
        {
            modoActual = modo;//Mady by Lexor_12 || kennygamer17 on github
            if (modo == UIUCIniciarSesionCrearUsuarioOpciones.IniciarSesion) IniciarSesion();
            else RegistrarUsuario();
        }
        private void IniciarSesion()
        {
            panelIzquierdo = new Panel();
            btnCambiarVentana = new Button();
            lblInvitacionCambio = new Label();
            lblDescripcion = new Label();
            lblTituloPrincipal = new Label();
            panelDerecho = new Panel();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblTituloFormulario = new Label();
            btnAceptar = new Button();//Mady by Lexor_12 || kennygamer17 on github
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(193, 203, 214);
            panelIzquierdo.Controls.Add(btnCambiarVentana);
            panelIzquierdo.Controls.Add(lblInvitacionCambio);//Mady by Lexor_12 || kennygamer17 on github
            panelIzquierdo.Controls.Add(lblDescripcion);
            panelIzquierdo.Controls.Add(lblTituloPrincipal);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(692, 720);
            panelIzquierdo.TabIndex = 0;
            // 
            // btnCambiarVentana
            // 
            btnCambiarVentana.BackColor = Color.FromArgb(43, 124, 200);
            btnCambiarVentana.Cursor = Cursors.Hand;
            btnCambiarVentana.FlatAppearance.BorderSize = 0;
            btnCambiarVentana.FlatStyle = FlatStyle.Flat;
            btnCambiarVentana.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCambiarVentana.ForeColor = Color.White;
            btnCambiarVentana.Location = new Point(25, 451);
            btnCambiarVentana.Name = "btnCambiarVentana";
            btnCambiarVentana.Size = new Size(252, 64);
            btnCambiarVentana.TabIndex = 3;
            btnCambiarVentana.Text = "Registrarse";
            btnCambiarVentana.UseVisualStyleBackColor = false;
            btnCambiarVentana.Click += PresionoBotonCambiarForm;
            // 
            // lblInvitacionCambio
            // 
            lblInvitacionCambio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvitacionCambio.ForeColor = Color.FromArgb(74, 85, 97);
            lblInvitacionCambio.Location = new Point(25, 375);
            lblInvitacionCambio.MaximumSize = new Size(600, 0);
            lblInvitacionCambio.Name = "lblInvitacionCambio";
            lblInvitacionCambio.Size = new Size(555, 95);
            lblInvitacionCambio.TabIndex = 1;
            lblInvitacionCambio.Text = "No hay creado una cuenta? Pues empieza desde ahora, da clic aquí abajo.";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.FromArgb(74, 85, 97);
            lblDescripcion.Location = new Point(25, 155);
            lblDescripcion.MaximumSize = new Size(600, 0);
            lblDescripcion.Name = "lblDescripcion";//Mady by Lexor_12 || kennygamer17 on github
            lblDescripcion.Size = new Size(555, 95);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "La aplicación para gestionar tus notas mejor valorada en la mente de Lexor_12.";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 90F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.FromArgb(38, 55, 69);
            lblTituloPrincipal.Location = new Point(3, 14);
            lblTituloPrincipal.Name = "lblTituloPrincipal";//Mady by Lexor_12 || kennygamer17 on github
            lblTituloPrincipal.Size = new Size(551, 159);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "AkNotes";
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(230, 235, 239);
            panelDerecho.Controls.Add(btnAceptar);
            panelDerecho.Controls.Add(txtUsuario);
            panelDerecho.Controls.Add(lblContrasena);
            panelDerecho.Controls.Add(txtContrasena);
            panelDerecho.Controls.Add(lblUsuario);
            panelDerecho.Controls.Add(lblTituloFormulario);
            panelDerecho.Dock = DockStyle.Right;
            panelDerecho.Location = new Point(689, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(591, 720);
            panelDerecho.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 124, 200);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(185, 468);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 47);//Mady by Lexor_12 || kennygamer17 on github
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += PresionoAceptar;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 20F);
            txtUsuario.Location = new Point(114, 220);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(350, 43);
            txtUsuario.TabIndex = 0;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(38, 55, 69);
            lblContrasena.Location = new Point(54, 298);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.RightToLeft = RightToLeft.No;
            lblContrasena.Size = new Size(169, 37);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 20F);
            txtContrasena.Location = new Point(114, 362);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(350, 43);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(38, 55, 69);
            lblUsuario.Location = new Point(54, 155);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.RightToLeft = RightToLeft.No;
            lblUsuario.Size = new Size(123, 37);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.AutoSize = true;
            lblTituloFormulario.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            lblTituloFormulario.ForeColor = Color.FromArgb(38, 55, 69);
            lblTituloFormulario.Location = new Point(9, 30);
            lblTituloFormulario.Name = "lblTituloFormulario";
            lblTituloFormulario.Size = new Size(455, 89);
            lblTituloFormulario.TabIndex = 2;
            lblTituloFormulario.Text = "Iniciar Sesion";

            // 
            // UCIniciarSesionCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Name = "UCIniciarSesionCrearUsuario";
            Size = new Size(1280, 720);
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            ResumeLayout(false);

        }
        private void RegistrarUsuario()
        {
            panelIzquierdo = new Panel();
            btnCambiarVentana = new Button();
            lblInvitacionCambio = new Label();
            lblDescripcion = new Label();
            lblTituloPrincipal = new Label();
            panelDerecho = new Panel();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblTituloFormulario = new Label();
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(193, 203, 214);
            panelIzquierdo.Controls.Add(btnCambiarVentana);
            panelIzquierdo.Controls.Add(lblInvitacionCambio);
            panelIzquierdo.Controls.Add(lblDescripcion);
            panelIzquierdo.Controls.Add(lblTituloPrincipal);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(692, 720);
            panelIzquierdo.TabIndex = 0;
            // 
            // btnCambiarVentana
            // 
            btnCambiarVentana.BackColor = Color.FromArgb(43, 124, 200);
            btnCambiarVentana.Cursor = Cursors.Hand;
            btnCambiarVentana.FlatAppearance.BorderSize = 0;
            btnCambiarVentana.FlatStyle = FlatStyle.Flat;
            btnCambiarVentana.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCambiarVentana.ForeColor = Color.White;
            btnCambiarVentana.Location = new Point(25, 451);
            btnCambiarVentana.Name = "btnCambiarVentana";
            btnCambiarVentana.Size = new Size(252, 64);
            btnCambiarVentana.TabIndex = 3;
            btnCambiarVentana.Text = "Iniciar sesion";
            btnCambiarVentana.UseVisualStyleBackColor = false;
            btnCambiarVentana.Click += PresionoBotonCambiarForm;
            // 
            // lblInvitacionCambio
            // 
            lblInvitacionCambio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvitacionCambio.ForeColor = Color.FromArgb(74, 85, 97);
            lblInvitacionCambio.Location = new Point(25, 375);
            lblInvitacionCambio.MaximumSize = new Size(600, 0);
            lblInvitacionCambio.Name = "lblInvitacionCambio";
            lblInvitacionCambio.Size = new Size(555, 95);
            lblInvitacionCambio.TabIndex = 1;
            lblInvitacionCambio.Text = "Ya tienes una cuenta creada? Pues inicia sesión ahora mismo, da clic aquí abajo.";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.FromArgb(74, 85, 97);
            lblDescripcion.Location = new Point(25, 155);
            lblDescripcion.MaximumSize = new Size(600, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(555, 95);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "La aplicación para gestionar tus notas mejor valorada en la mente de Lexor_12.";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 90F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.FromArgb(38, 55, 69);
            lblTituloPrincipal.Location = new Point(3, 14);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(551, 159);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "AkNotes";
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(230, 235, 239);
            panelDerecho.Controls.Add(lblConfirmarContrasena);
            panelDerecho.Controls.Add(txtConfirmarContrasena);
            panelDerecho.Controls.Add(btnAceptar);
            panelDerecho.Controls.Add(txtUsuario);
            panelDerecho.Controls.Add(lblContrasena);
            panelDerecho.Controls.Add(txtContrasena);
            panelDerecho.Controls.Add(lblUsuario);
            panelDerecho.Controls.Add(lblTituloFormulario);
            panelDerecho.Dock = DockStyle.Right;
            panelDerecho.Location = new Point(689, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(591, 720);
            panelDerecho.TabIndex = 1;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblConfirmarContrasena.ForeColor = Color.FromArgb(38, 55, 69);
            lblConfirmarContrasena.Location = new Point(54, 451);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.RightToLeft = RightToLeft.No;
            lblConfirmarContrasena.Size = new Size(303, 37);
            lblConfirmarContrasena.TabIndex = 7;
            lblConfirmarContrasena.Text = "Contraseña (Otra vez):";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Segoe UI", 20F);
            txtConfirmarContrasena.Location = new Point(114, 515);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(350, 43);
            txtConfirmarContrasena.TabIndex = 2;
            txtConfirmarContrasena.UseSystemPasswordChar = true;

            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 124, 200);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(184, 613);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(211, 57);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += PresionoAceptar;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 20F);
            txtUsuario.Location = new Point(114, 221);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(350, 43);
            txtUsuario.TabIndex = 0;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(38, 55, 69);
            lblContrasena.Location = new Point(54, 298);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.RightToLeft = RightToLeft.No;
            lblContrasena.Size = new Size(169, 37);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 20F);
            txtContrasena.Location = new Point(114, 362);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(350, 43);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(38, 55, 69);
            lblUsuario.Location = new Point(54, 155);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.RightToLeft = RightToLeft.No;
            lblUsuario.Size = new Size(123, 37);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.AutoSize = true;
            lblTituloFormulario.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            lblTituloFormulario.ForeColor = Color.FromArgb(38, 55, 69);
            lblTituloFormulario.Location = new Point(9, 30);
            lblTituloFormulario.Name = "lblTituloFormulario";
            lblTituloFormulario.Size = new Size(580, 89);
            lblTituloFormulario.TabIndex = 2;
            lblTituloFormulario.Text = "Registrar Usuario";
            // 
            // UCIniciarSesionCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Name = "UCIniciarSesionCrearUsuario";
            Size = new Size(1280, 720);
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            ResumeLayout(false);

        }
        private void PresionoAceptar(object sender, EventArgs e)
        {
            BotonAceptarPresionado.Invoke(this);
        }//Mady by Lexor_12 || kennygamer17 on github
        private void PresionoBotonCambiarForm(object sender, EventArgs e)
        {
            BotonCambiarAOtroFormPresionado.Invoke(this);
        }//Mady by Lexor_12 || kennygamer17 on github
    }
}