namespace AkNotes.Views.UserControls
{
    partial class GestorBase
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PanelLateralIzquierdo = new Panel();
            PanelLateralContenedorDeBotonesYMas = new Panel();
            PanelLateralBotones = new Panel();
            btnSalir = new Button();
            btnListarNotas = new Button();
            btnCrearNota = new Button();
            btnInicio = new Button();
            PanelLateralSeccionAbajo = new Panel();
            label1 = new Label();
            btnCerrarSesion = new Button();
            PanelLateralTitulo = new Panel();
            LabelTitulo = new Label();
            PanelMain = new Panel();
            lblNombreUsuario = new Label();
            label2 = new Label();
            PanelLateralIzquierdo.SuspendLayout();
            PanelLateralContenedorDeBotonesYMas.SuspendLayout();
            PanelLateralBotones.SuspendLayout();
            PanelLateralSeccionAbajo.SuspendLayout();
            PanelLateralTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLateralIzquierdo
            // 
            PanelLateralIzquierdo.BackColor = Color.FromArgb(49, 69, 88);
            PanelLateralIzquierdo.Controls.Add(PanelLateralContenedorDeBotonesYMas);
            PanelLateralIzquierdo.Controls.Add(PanelLateralSeccionAbajo);
            PanelLateralIzquierdo.Controls.Add(PanelLateralTitulo);
            PanelLateralIzquierdo.Dock = DockStyle.Left;
            PanelLateralIzquierdo.Location = new Point(0, 0);
            PanelLateralIzquierdo.Name = "PanelLateralIzquierdo";
            PanelLateralIzquierdo.Size = new Size(220, 720);
            PanelLateralIzquierdo.TabIndex = 0;
            // 
            // PanelLateralContenedorDeBotonesYMas
            // 
            PanelLateralContenedorDeBotonesYMas.BackColor = Color.FromArgb(49, 69, 88);
            PanelLateralContenedorDeBotonesYMas.Controls.Add(PanelLateralBotones);
            PanelLateralContenedorDeBotonesYMas.Dock = DockStyle.Fill;
            PanelLateralContenedorDeBotonesYMas.Location = new Point(0, 126);
            PanelLateralContenedorDeBotonesYMas.Name = "PanelLateralContenedorDeBotonesYMas";
            PanelLateralContenedorDeBotonesYMas.Size = new Size(220, 418);
            PanelLateralContenedorDeBotonesYMas.TabIndex = 3;
            // 
            // PanelLateralBotones
            // 
            PanelLateralBotones.AutoSize = true;
            PanelLateralBotones.BackColor = Color.FromArgb(175, 191, 211);
            PanelLateralBotones.Controls.Add(btnSalir);
            PanelLateralBotones.Controls.Add(btnListarNotas);
            PanelLateralBotones.Controls.Add(btnCrearNota);
            PanelLateralBotones.Controls.Add(btnInicio);
            PanelLateralBotones.Dock = DockStyle.Top;
            PanelLateralBotones.Location = new Point(0, 0);
            PanelLateralBotones.Name = "PanelLateralBotones";
            PanelLateralBotones.Size = new Size(220, 280);
            PanelLateralBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(175, 191, 211);
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(33, 47, 60);
            btnSalir.Location = new Point(0, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 70);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnListarNotas
            // 
            btnListarNotas.BackColor = Color.FromArgb(175, 191, 211);
            btnListarNotas.Dock = DockStyle.Top;
            btnListarNotas.FlatStyle = FlatStyle.Popup;
            btnListarNotas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnListarNotas.ForeColor = Color.FromArgb(33, 47, 60);
            btnListarNotas.Location = new Point(0, 140);
            btnListarNotas.Name = "btnListarNotas";
            btnListarNotas.Size = new Size(220, 70);
            btnListarNotas.TabIndex = 2;
            btnListarNotas.Text = "Listar Notas";
            btnListarNotas.UseVisualStyleBackColor = false;
            btnListarNotas.Click += btnListarNotas_Click;
            // 
            // btnCrearNota
            // 
            btnCrearNota.BackColor = Color.FromArgb(175, 191, 211);
            btnCrearNota.Dock = DockStyle.Top;
            btnCrearNota.FlatStyle = FlatStyle.Popup;
            btnCrearNota.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCrearNota.ForeColor = Color.FromArgb(33, 47, 60);
            btnCrearNota.Location = new Point(0, 70);
            btnCrearNota.Name = "btnCrearNota";
            btnCrearNota.Size = new Size(220, 70);
            btnCrearNota.TabIndex = 1;
            btnCrearNota.Text = "Crear Nota";
            btnCrearNota.UseVisualStyleBackColor = false;
            btnCrearNota.Click += btnCrearNota_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(175, 191, 211);
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnInicio.ForeColor = Color.FromArgb(33, 47, 60);
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(220, 70);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // PanelLateralSeccionAbajo
            // 
            PanelLateralSeccionAbajo.BackColor = Color.FromArgb(49, 69, 88);
            PanelLateralSeccionAbajo.Controls.Add(label2);
            PanelLateralSeccionAbajo.Controls.Add(lblNombreUsuario);
            PanelLateralSeccionAbajo.Controls.Add(btnCerrarSesion);
            PanelLateralSeccionAbajo.Dock = DockStyle.Bottom;
            PanelLateralSeccionAbajo.Location = new Point(0, 544);
            PanelLateralSeccionAbajo.Name = "PanelLateralSeccionAbajo";
            PanelLateralSeccionAbajo.Size = new Size(220, 176);
            PanelLateralSeccionAbajo.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 82);
            label1.Name = "label1";
            label1.Size = new Size(92, 11);
            label1.TabIndex = 1;
            label1.Text = "Elaborado por Lexor_12";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(175, 191, 211);
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(33, 47, 60);
            btnCerrarSesion.Location = new Point(0, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(220, 70);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // PanelLateralTitulo
            // 
            PanelLateralTitulo.BackColor = Color.FromArgb(49, 69, 88);
            PanelLateralTitulo.Controls.Add(LabelTitulo);
            PanelLateralTitulo.Controls.Add(label1);
            PanelLateralTitulo.Dock = DockStyle.Top;
            PanelLateralTitulo.Location = new Point(0, 0);
            PanelLateralTitulo.Name = "PanelLateralTitulo";
            PanelLateralTitulo.Size = new Size(220, 126);
            PanelLateralTitulo.TabIndex = 0;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitulo.ForeColor = Color.White;
            LabelTitulo.Location = new Point(43, 42);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(134, 40);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "AkNotes";
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(220, 0);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1060, 720);
            PanelMain.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(82, 128);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(44, 17);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "Pedro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 95);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // GestorBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMain);
            Controls.Add(PanelLateralIzquierdo);
            Name = "GestorBase";
            Size = new Size(1280, 720);
            PanelLateralIzquierdo.ResumeLayout(false);
            PanelLateralContenedorDeBotonesYMas.ResumeLayout(false);
            PanelLateralContenedorDeBotonesYMas.PerformLayout();
            PanelLateralBotones.ResumeLayout(false);
            PanelLateralSeccionAbajo.ResumeLayout(false);
            PanelLateralSeccionAbajo.PerformLayout();
            PanelLateralTitulo.ResumeLayout(false);
            PanelLateralTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLateralIzquierdo;
        private Panel PanelMain;
        private Panel PanelLateralTitulo;
        private Panel PanelLateralBotones;
        private Panel PanelLateralContenedorDeBotonesYMas;
        private Panel PanelLateralSeccionAbajo;
        private Button btnSalir;
        private Button btnListarNotas;
        private Button btnCrearNota;
        private Button btnInicio;
        private Label LabelTitulo;
        private Button btnCerrarSesion;
        private Label label1;
        private Label label2;
        private Label lblNombreUsuario;
    }
}
