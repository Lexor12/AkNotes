namespace AkNotes.Views.UserControls.Main
{
    partial class UCGestorNota
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
            lblTituloUC = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            paneltxtTitulo = new Panel();
            label2 = new Label();
            txtContenido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblFechaCreacion = new Label();
            lblFechaEdicion = new Label();
            btnAceptar = new Button();
            label5 = new Label();
            rdbtnImportante = new RadioButton();
            rdbtnNoImportante = new RadioButton();
            txtNota = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ckbIdea = new CheckBox();
            ckbHogar = new CheckBox();
            ckbPendiente = new CheckBox();
            ckbCompletado = new CheckBox();
            ckbPlanificacion = new CheckBox();
            ckbUrgente = new CheckBox();
            ckbProyecto = new CheckBox();
            ckbTarea = new CheckBox();
            ckbRecordatorio = new CheckBox();
            ckbInspiracion = new CheckBox();
            ckbContacto = new CheckBox();
            ckbTrabajo = new CheckBox();
            label8 = new Label();
            lblCodigo = new Label();
            label9 = new Label();
            label10 = new Label();
            rdbCodigo = new RadioButton();
            rdbPublico = new RadioButton();
            rdbPrivado = new RadioButton();
            rdbLisUsuarios = new RadioButton();
            label11 = new Label();
            txtNombreUsuario = new TextBox();
            dgListaUsuarios = new DataGridView();
            btnAgregarUsuario = new Button();
            btnEliminarUsuario = new Button();
            panelUsuario = new Panel();
            panel1 = new Panel();
            label12 = new Label();
            lblNombreUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgListaUsuarios).BeginInit();
            panelUsuario.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloUC
            // 
            lblTituloUC.AutoSize = true;
            lblTituloUC.Font = new Font("Segoe UI", 65F, FontStyle.Bold);
            lblTituloUC.ForeColor = Color.FromArgb(33, 47, 60);
            lblTituloUC.Location = new Point(3, 0);
            lblTituloUC.Name = "lblTituloUC";
            lblTituloUC.Size = new Size(478, 116);
            lblTituloUC.TabIndex = 0;
            lblTituloUC.Text = "Crear nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 47, 60);
            label1.Location = new Point(28, 136);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Titulo.";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.BackColor = Color.White;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Font = new Font("Segoe UI", 12F);
            txtTitulo.ForeColor = Color.FromArgb(33, 47, 60);
            txtTitulo.Location = new Point(36, 168);
            txtTitulo.Margin = new Padding(4);
            txtTitulo.MaxLength = 64;
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(452, 50);
            txtTitulo.TabIndex = 0;
            // 
            // paneltxtTitulo
            // 
            paneltxtTitulo.AutoSize = true;
            paneltxtTitulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paneltxtTitulo.BackColor = SystemColors.AppWorkspace;
            paneltxtTitulo.Location = new Point(28, 165);
            paneltxtTitulo.Name = "paneltxtTitulo";
            paneltxtTitulo.Size = new Size(0, 0);
            paneltxtTitulo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 47, 60);
            label2.Location = new Point(29, 228);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 4;
            label2.Text = "Contenido.";
            // 
            // txtContenido
            // 
            txtContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContenido.BackColor = Color.White;
            txtContenido.BorderStyle = BorderStyle.None;
            txtContenido.Font = new Font("Segoe UI", 12F);
            txtContenido.ForeColor = Color.FromArgb(33, 47, 60);
            txtContenido.Location = new Point(36, 260);
            txtContenido.Margin = new Padding(4);
            txtContenido.MaxLength = 512;
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(452, 251);
            txtContenido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(33, 47, 60);
            label3.Location = new Point(36, 512);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 6;
            label3.Text = "Fecha de creación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(33, 47, 60);
            label4.Location = new Point(36, 540);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 7;
            label4.Text = "Fecha de edición:";
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFechaCreacion.ForeColor = Color.FromArgb(85, 102, 119);
            lblFechaCreacion.Location = new Point(222, 512);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(266, 28);
            lblFechaCreacion.TabIndex = 8;
            lblFechaCreacion.Text = "11/11/2025 01:44:32 p. m.";
            // 
            // lblFechaEdicion
            // 
            lblFechaEdicion.AutoSize = true;
            lblFechaEdicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFechaEdicion.ForeColor = Color.FromArgb(85, 102, 119);
            lblFechaEdicion.Location = new Point(228, 540);
            lblFechaEdicion.Name = "lblFechaEdicion";
            lblFechaEdicion.Size = new Size(266, 28);
            lblFechaEdicion.TabIndex = 9;
            lblFechaEdicion.Text = "11/11/2025 01:44:32 p. m.";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 124, 200);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(788, 623);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(233, 49);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar y crear";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 47, 60);
            label5.Location = new Point(578, 26);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 11;
            label5.Text = "Preferencia:";
            // 
            // rdbtnImportante
            // 
            rdbtnImportante.AutoSize = true;
            rdbtnImportante.Location = new Point(10, 3);
            rdbtnImportante.Name = "rdbtnImportante";
            rdbtnImportante.Size = new Size(84, 19);
            rdbtnImportante.TabIndex = 2;
            rdbtnImportante.Text = "Importante";
            rdbtnImportante.UseVisualStyleBackColor = true;
            // 
            // rdbtnNoImportante
            // 
            rdbtnNoImportante.AutoSize = true;
            rdbtnNoImportante.Checked = true;
            rdbtnNoImportante.Location = new Point(100, 3);
            rdbtnNoImportante.Name = "rdbtnNoImportante";
            rdbtnNoImportante.Size = new Size(103, 19);
            rdbtnNoImportante.TabIndex = 3;
            rdbtnNoImportante.TabStop = true;
            rdbtnNoImportante.Text = "No importante";
            rdbtnNoImportante.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            txtNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNota.BackColor = Color.White;
            txtNota.BorderStyle = BorderStyle.None;
            txtNota.Font = new Font("Segoe UI", 12F);
            txtNota.ForeColor = Color.FromArgb(33, 47, 60);
            txtNota.Location = new Point(578, 120);
            txtNota.Margin = new Padding(4);
            txtNota.MaxLength = 256;
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(443, 65);
            txtNota.TabIndex = 4;
            txtNota.TextChanged += txtNota_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 47, 60);
            label6.Location = new Point(578, 88);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 14;
            label6.Text = "Nota.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(33, 47, 60);
            label7.Location = new Point(578, 190);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 5;
            label7.Text = "Tags.";
            // 
            // ckbIdea
            // 
            ckbIdea.AutoSize = true;
            ckbIdea.Location = new Point(589, 228);
            ckbIdea.Name = "ckbIdea";
            ckbIdea.Size = new Size(48, 19);
            ckbIdea.TabIndex = 17;
            ckbIdea.Text = "Idea";
            ckbIdea.UseVisualStyleBackColor = true;
            // 
            // ckbHogar
            // 
            ckbHogar.AutoSize = true;
            ckbHogar.Location = new Point(589, 253);
            ckbHogar.Name = "ckbHogar";
            ckbHogar.Size = new Size(59, 19);
            ckbHogar.TabIndex = 18;
            ckbHogar.Text = "Hogar";
            ckbHogar.UseVisualStyleBackColor = true;
            // 
            // ckbPendiente
            // 
            ckbPendiente.AutoSize = true;
            ckbPendiente.Location = new Point(589, 278);
            ckbPendiente.Name = "ckbPendiente";
            ckbPendiente.Size = new Size(79, 19);
            ckbPendiente.TabIndex = 19;
            ckbPendiente.Text = "Pendiente";
            ckbPendiente.UseVisualStyleBackColor = true;
            // 
            // ckbCompletado
            // 
            ckbCompletado.AutoSize = true;
            ckbCompletado.Location = new Point(589, 303);
            ckbCompletado.Name = "ckbCompletado";
            ckbCompletado.Size = new Size(92, 19);
            ckbCompletado.TabIndex = 20;
            ckbCompletado.Text = "Completado";
            ckbCompletado.UseVisualStyleBackColor = true;
            // 
            // ckbPlanificacion
            // 
            ckbPlanificacion.AutoSize = true;
            ckbPlanificacion.Location = new Point(746, 303);
            ckbPlanificacion.Name = "ckbPlanificacion";
            ckbPlanificacion.Size = new Size(94, 19);
            ckbPlanificacion.TabIndex = 24;
            ckbPlanificacion.Text = "Planificación";
            ckbPlanificacion.UseVisualStyleBackColor = true;
            // 
            // ckbUrgente
            // 
            ckbUrgente.AutoSize = true;
            ckbUrgente.Location = new Point(746, 278);
            ckbUrgente.Name = "ckbUrgente";
            ckbUrgente.Size = new Size(68, 19);
            ckbUrgente.TabIndex = 23;
            ckbUrgente.Text = "Urgente";
            ckbUrgente.UseVisualStyleBackColor = true;
            // 
            // ckbProyecto
            // 
            ckbProyecto.AutoSize = true;
            ckbProyecto.Location = new Point(746, 253);
            ckbProyecto.Name = "ckbProyecto";
            ckbProyecto.Size = new Size(73, 19);
            ckbProyecto.TabIndex = 22;
            ckbProyecto.Text = "Proyecto";
            ckbProyecto.UseVisualStyleBackColor = true;
            // 
            // ckbTarea
            // 
            ckbTarea.AutoSize = true;
            ckbTarea.Location = new Point(746, 228);
            ckbTarea.Name = "ckbTarea";
            ckbTarea.Size = new Size(54, 19);
            ckbTarea.TabIndex = 21;
            ckbTarea.Text = "Tarea";
            ckbTarea.UseVisualStyleBackColor = true;
            // 
            // ckbRecordatorio
            // 
            ckbRecordatorio.AutoSize = true;
            ckbRecordatorio.Location = new Point(879, 303);
            ckbRecordatorio.Name = "ckbRecordatorio";
            ckbRecordatorio.Size = new Size(94, 19);
            ckbRecordatorio.TabIndex = 28;
            ckbRecordatorio.Text = "Recordatorio";
            ckbRecordatorio.UseVisualStyleBackColor = true;
            // 
            // ckbInspiracion
            // 
            ckbInspiracion.AutoSize = true;
            ckbInspiracion.Location = new Point(879, 278);
            ckbInspiracion.Name = "ckbInspiracion";
            ckbInspiracion.RightToLeft = RightToLeft.No;
            ckbInspiracion.Size = new Size(84, 19);
            ckbInspiracion.TabIndex = 27;
            ckbInspiracion.Text = "Inspiración";
            ckbInspiracion.UseVisualStyleBackColor = true;
            // 
            // ckbContacto
            // 
            ckbContacto.AutoSize = true;
            ckbContacto.Location = new Point(879, 253);
            ckbContacto.Name = "ckbContacto";
            ckbContacto.Size = new Size(75, 19);
            ckbContacto.TabIndex = 26;
            ckbContacto.Text = "Contacto";
            ckbContacto.UseVisualStyleBackColor = true;
            // 
            // ckbTrabajo
            // 
            ckbTrabajo.AutoSize = true;
            ckbTrabajo.Location = new Point(879, 228);
            ckbTrabajo.Name = "ckbTrabajo";
            ckbTrabajo.Size = new Size(65, 19);
            ckbTrabajo.TabIndex = 25;
            ckbTrabajo.Text = "Trabajo";
            ckbTrabajo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(33, 47, 60);
            label8.Location = new Point(546, 623);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 29;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Enabled = false;
            lblCodigo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(85, 102, 119);
            lblCodigo.Location = new Point(466, 644);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(29, 13);
            lblCodigo.TabIndex = 30;
            lblCodigo.Text = "N/A";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(33, 47, 60);
            label9.Location = new Point(36, 632);
            label9.Name = "label9";
            label9.Size = new Size(413, 28);
            label9.TabIndex = 31;
            label9.Text = "Código para compartir (Clic para guardar):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(33, 47, 60);
            label10.Location = new Point(578, 338);
            label10.Name = "label10";
            label10.Size = new Size(111, 28);
            label10.TabIndex = 32;
            label10.Text = "Compartir.";
            // 
            // rdbCodigo
            // 
            rdbCodigo.AutoSize = true;
            rdbCodigo.Location = new Point(793, 371);
            rdbCodigo.Name = "rdbCodigo";
            rdbCodigo.Size = new Size(87, 19);
            rdbCodigo.TabIndex = 33;
            rdbCodigo.Text = "Con código";
            rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbPublico
            // 
            rdbPublico.AutoSize = true;
            rdbPublico.Location = new Point(628, 371);
            rdbPublico.Name = "rdbPublico";
            rdbPublico.Size = new Size(65, 19);
            rdbPublico.TabIndex = 34;
            rdbPublico.Text = "Público";
            rdbPublico.UseVisualStyleBackColor = true;
            // 
            // rdbPrivado
            // 
            rdbPrivado.AutoSize = true;
            rdbPrivado.Checked = true;
            rdbPrivado.Location = new Point(708, 371);
            rdbPrivado.Name = "rdbPrivado";
            rdbPrivado.Size = new Size(65, 19);
            rdbPrivado.TabIndex = 35;
            rdbPrivado.TabStop = true;
            rdbPrivado.Text = "Privado";
            rdbPrivado.UseVisualStyleBackColor = true;
            // 
            // rdbLisUsuarios
            // 
            rdbLisUsuarios.AutoSize = true;
            rdbLisUsuarios.Location = new Point(899, 371);
            rdbLisUsuarios.Name = "rdbLisUsuarios";
            rdbLisUsuarios.Size = new Size(112, 19);
            rdbLisUsuarios.TabIndex = 36;
            rdbLisUsuarios.Text = "Lista de usuarios";
            rdbLisUsuarios.UseVisualStyleBackColor = true;
            rdbLisUsuarios.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(33, 47, 60);
            label11.Location = new Point(8, 7);
            label11.Name = "label11";
            label11.Size = new Size(148, 20);
            label11.TabIndex = 37;
            label11.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Segoe UI", 11F);
            txtNombreUsuario.ForeColor = Color.FromArgb(33, 47, 60);
            txtNombreUsuario.Location = new Point(166, 7);
            txtNombreUsuario.Margin = new Padding(4);
            txtNombreUsuario.MaxLength = 64;
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ScrollBars = ScrollBars.Horizontal;
            txtNombreUsuario.Size = new Size(208, 21);
            txtNombreUsuario.TabIndex = 38;
            // 
            // dgListaUsuarios
            // 
            dgListaUsuarios.AllowUserToAddRows = false;
            dgListaUsuarios.AllowUserToOrderColumns = true;
            dgListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaUsuarios.BackgroundColor = Color.FromArgb(236, 237, 240);
            dgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaUsuarios.Location = new Point(38, 71);
            dgListaUsuarios.MultiSelect = false;
            dgListaUsuarios.Name = "dgListaUsuarios";
            dgListaUsuarios.ReadOnly = true;
            dgListaUsuarios.RowHeadersVisible = false;
            dgListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListaUsuarios.Size = new Size(343, 78);
            dgListaUsuarios.TabIndex = 39;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAgregarUsuario.ForeColor = Color.White;
            btnAgregarUsuario.Location = new Point(314, 34);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(60, 31);
            btnAgregarUsuario.TabIndex = 40;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.Location = new Point(250, 155);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(131, 28);
            btnEliminarUsuario.TabIndex = 41;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = SystemColors.Control;
            panelUsuario.Controls.Add(dgListaUsuarios);
            panelUsuario.Controls.Add(btnEliminarUsuario);
            panelUsuario.Controls.Add(label11);
            panelUsuario.Controls.Add(btnAgregarUsuario);
            panelUsuario.Controls.Add(txtNombreUsuario);
            panelUsuario.Enabled = false;
            panelUsuario.Location = new Point(622, 396);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(399, 191);
            panelUsuario.TabIndex = 42;
            panelUsuario.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbtnImportante);
            panel1.Controls.Add(rdbtnNoImportante);
            panel1.Location = new Point(589, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 28);
            panel1.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(33, 47, 60);
            label12.Location = new Point(36, 568);
            label12.Name = "label12";
            label12.Size = new Size(122, 28);
            label12.TabIndex = 44;
            label12.Text = "Creado por:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.FromArgb(85, 102, 119);
            lblNombreUsuario.Location = new Point(164, 568);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(66, 28);
            lblNombreUsuario.TabIndex = 45;
            lblNombreUsuario.Text = "Usted";
            // 
            // UCGestorNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNombreUsuario);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(panelUsuario);
            Controls.Add(rdbLisUsuarios);
            Controls.Add(rdbPrivado);
            Controls.Add(rdbPublico);
            Controls.Add(rdbCodigo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblCodigo);
            Controls.Add(label8);
            Controls.Add(ckbRecordatorio);
            Controls.Add(ckbInspiracion);
            Controls.Add(ckbContacto);
            Controls.Add(ckbTrabajo);
            Controls.Add(ckbPlanificacion);
            Controls.Add(ckbUrgente);
            Controls.Add(ckbProyecto);
            Controls.Add(ckbTarea);
            Controls.Add(ckbCompletado);
            Controls.Add(ckbPendiente);
            Controls.Add(ckbHogar);
            Controls.Add(ckbIdea);
            Controls.Add(label7);
            Controls.Add(txtNota);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAceptar);
            Controls.Add(lblFechaEdicion);
            Controls.Add(lblFechaCreacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtContenido);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(paneltxtTitulo);
            Controls.Add(label1);
            Controls.Add(lblTituloUC);
            Name = "UCGestorNota";
            Size = new Size(1062, 700);
            ((System.ComponentModel.ISupportInitialize)dgListaUsuarios).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloUC;
        private Label label1;
        public TextBox txtTitulo;
        private Panel paneltxtTitulo;
        private Label label2;
        public TextBox txtContenido;
        private Label label3;
        private Label label4;
        private Label lblFechaCreacion;
        private Label lblFechaEdicion;
        private Button btnAceptar;
        private Label label5;
        public RadioButton rdbtnImportante;
        public RadioButton rdbtnNoImportante;
        public TextBox txtNota;
        private Label label6;
        private Label label7;
        public CheckBox ckbIdea;
        public CheckBox ckbHogar;
        private CheckBox ckbPendiente;
        private CheckBox ckbCompletado;
        private CheckBox ckbPlanificacion;
        private CheckBox ckbUrgente;
        private CheckBox ckbProyecto;
        private CheckBox ckbTarea;
        private CheckBox ckbRecordatorio;
        private CheckBox ckbInspiracion;
        private CheckBox ckbContacto;
        private CheckBox ckbTrabajo;
        private Label label8;
        private Label lblCodigo;
        private Label label9;
        private Label label10;
        public RadioButton rdbCodigo;
        public RadioButton rdbPublico;
        public RadioButton rdbPrivado;
        public RadioButton rdbLisUsuarios;
        private Label label11;
        public TextBox txtNombreUsuario;
        public DataGridView dgListaUsuarios;
        private Button btnAgregarUsuario;
        private Button btnEliminarUsuario;
        private Panel panelUsuario;
        private Panel panel1;
        private Label label12;
        private Label lblNombreUsuario;
    }
}
