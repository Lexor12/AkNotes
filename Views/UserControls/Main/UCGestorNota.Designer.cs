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
            label2.Location = new Point(28, 240);
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
            txtContenido.Location = new Point(36, 272);
            txtContenido.Margin = new Padding(4);
            txtContenido.MaxLength = 512;
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(452, 263);
            txtContenido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(33, 47, 60);
            label3.Location = new Point(29, 559);
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
            label4.Location = new Point(29, 606);
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
            lblFechaCreacion.Location = new Point(221, 559);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(265, 28);
            lblFechaCreacion.TabIndex = 8;
            lblFechaCreacion.Text = DateTime.Now.ToString();
            // 
            // lblFechaEdicion
            // 
            lblFechaEdicion.AutoSize = true;
            lblFechaEdicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFechaEdicion.ForeColor = Color.FromArgb(85, 102, 119);
            lblFechaEdicion.Location = new Point(221, 606);
            lblFechaEdicion.Name = "lblFechaEdicion";
            lblFechaEdicion.Size = new Size(265, 28);
            lblFechaEdicion.TabIndex = 9;
            lblFechaEdicion.Text = DateTime.Now.ToString();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 124, 200);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(788, 559);
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
            label5.Location = new Point(588, 156);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 11;
            label5.Text = "Preferencia:";
            // 
            // rdbtnImportante
            // 
            rdbtnImportante.AutoSize = true;
            rdbtnImportante.Location = new Point(619, 191);
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
            rdbtnNoImportante.Location = new Point(787, 191);
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
            txtNota.Location = new Point(588, 272);
            txtNota.Margin = new Padding(4);
            txtNota.MaxLength = 256;
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(443, 65);
            txtNota.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 47, 60);
            label6.Location = new Point(588, 240);
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
            label7.Location = new Point(588, 382);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 5;
            label7.Text = "Tags.";
            // 
            // ckbIdea
            // 
            ckbIdea.AutoSize = true;
            ckbIdea.Location = new Point(599, 420);
            ckbIdea.Name = "ckbIdea";
            ckbIdea.Size = new Size(48, 19);
            ckbIdea.TabIndex = 17;
            ckbIdea.Text = "Idea";
            ckbIdea.UseVisualStyleBackColor = true;
            // 
            // ckbHogar
            // 
            ckbHogar.AutoSize = true;
            ckbHogar.Location = new Point(599, 445);
            ckbHogar.Name = "ckbHogar";
            ckbHogar.Size = new Size(59, 19);
            ckbHogar.TabIndex = 18;
            ckbHogar.Text = "Hogar";
            ckbHogar.UseVisualStyleBackColor = true;
            // 
            // ckbPendiente
            // 
            ckbPendiente.AutoSize = true;
            ckbPendiente.Location = new Point(599, 470);
            ckbPendiente.Name = "ckbPendiente";
            ckbPendiente.Size = new Size(79, 19);
            ckbPendiente.TabIndex = 19;
            ckbPendiente.Text = "Pendiente";
            ckbPendiente.UseVisualStyleBackColor = true;
            // 
            // ckbCompletado
            // 
            ckbCompletado.AutoSize = true;
            ckbCompletado.Location = new Point(599, 495);
            ckbCompletado.Name = "ckbCompletado";
            ckbCompletado.Size = new Size(92, 19);
            ckbCompletado.TabIndex = 20;
            ckbCompletado.Text = "Completado";
            ckbCompletado.UseVisualStyleBackColor = true;
            // 
            // ckbPlanificacion
            // 
            ckbPlanificacion.AutoSize = true;
            ckbPlanificacion.Location = new Point(756, 495);
            ckbPlanificacion.Name = "ckbPlanificacion";
            ckbPlanificacion.Size = new Size(94, 19);
            ckbPlanificacion.TabIndex = 24;
            ckbPlanificacion.Text = "Planificación";
            ckbPlanificacion.UseVisualStyleBackColor = true;
            // 
            // ckbUrgente
            // 
            ckbUrgente.AutoSize = true;
            ckbUrgente.Location = new Point(756, 470);
            ckbUrgente.Name = "ckbUrgente";
            ckbUrgente.Size = new Size(68, 19);
            ckbUrgente.TabIndex = 23;
            ckbUrgente.Text = "Urgente";
            ckbUrgente.UseVisualStyleBackColor = true;
            // 
            // ckbProyecto
            // 
            ckbProyecto.AutoSize = true;
            ckbProyecto.Location = new Point(756, 445);
            ckbProyecto.Name = "ckbProyecto";
            ckbProyecto.Size = new Size(73, 19);
            ckbProyecto.TabIndex = 22;
            ckbProyecto.Text = "Proyecto";
            ckbProyecto.UseVisualStyleBackColor = true;
            // 
            // ckbTarea
            // 
            ckbTarea.AutoSize = true;
            ckbTarea.Location = new Point(756, 420);
            ckbTarea.Name = "ckbTarea";
            ckbTarea.Size = new Size(54, 19);
            ckbTarea.TabIndex = 21;
            ckbTarea.Text = "Tarea";
            ckbTarea.UseVisualStyleBackColor = true;
            // 
            // ckbRecordatorio
            // 
            ckbRecordatorio.AutoSize = true;
            ckbRecordatorio.Location = new Point(889, 495);
            ckbRecordatorio.Name = "ckbRecordatorio";
            ckbRecordatorio.Size = new Size(94, 19);
            ckbRecordatorio.TabIndex = 28;
            ckbRecordatorio.Text = "Recordatorio";
            ckbRecordatorio.UseVisualStyleBackColor = true;
            // 
            // ckbInspiracion
            // 
            ckbInspiracion.AutoSize = true;
            ckbInspiracion.Location = new Point(889, 470);
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
            ckbContacto.Location = new Point(889, 445);
            ckbContacto.Name = "ckbContacto";
            ckbContacto.Size = new Size(75, 19);
            ckbContacto.TabIndex = 26;
            ckbContacto.Text = "Contacto";
            ckbContacto.UseVisualStyleBackColor = true;
            // 
            // ckbTrabajo
            // 
            ckbTrabajo.AutoSize = true;
            ckbTrabajo.Location = new Point(889, 420);
            ckbTrabajo.Name = "ckbTrabajo";
            ckbTrabajo.Size = new Size(65, 19);
            ckbTrabajo.TabIndex = 25;
            ckbTrabajo.Text = "Trabajo";
            ckbTrabajo.UseVisualStyleBackColor = true;
            // 
            // UCGestorNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(rdbtnNoImportante);
            Controls.Add(rdbtnImportante);
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
    }
}
