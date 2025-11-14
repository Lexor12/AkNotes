namespace AkNotes.Views.UserControls
{
    partial class UCListaNotas
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
            label1 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnRecargar = new Button();
            dataGriedListaNotas = new DataGridView();
            panel1 = new Panel();
            btnVista = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGriedListaNotas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 70F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 47, 60);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(661, 125);
            label1.TabIndex = 0;
            label1.Text = "Lista de notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 47, 60);
            label2.Location = new Point(702, 26);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 2;
            label2.Text = "Buscar y filtrar.";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14F);
            txtBuscar.Location = new Point(702, 50);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Título, Código compartido";
            txtBuscar.ScrollBars = ScrollBars.Horizontal;
            txtBuscar.Size = new Size(329, 35);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(49, 69, 88);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(31, 603);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(233, 49);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(49, 69, 88);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(300, 603);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(233, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = Color.FromArgb(0, 192, 192);
            btnRecargar.Cursor = Cursors.Hand;
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRecargar.ForeColor = Color.White;
            btnRecargar.Location = new Point(918, 603);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(113, 49);
            btnRecargar.TabIndex = 6;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // dataGriedListaNotas
            // 
            dataGriedListaNotas.AllowUserToAddRows = false;
            dataGriedListaNotas.AllowUserToOrderColumns = true;
            dataGriedListaNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGriedListaNotas.BackgroundColor = Color.FromArgb(236, 237, 240);
            dataGriedListaNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriedListaNotas.Location = new Point(0, 0);
            dataGriedListaNotas.MultiSelect = false;
            dataGriedListaNotas.Name = "dataGriedListaNotas";
            dataGriedListaNotas.ReadOnly = true;
            dataGriedListaNotas.RowHeadersVisible = false;
            dataGriedListaNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGriedListaNotas.Size = new Size(1000, 423);
            dataGriedListaNotas.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGriedListaNotas);
            panel1.Location = new Point(31, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 423);
            panel1.TabIndex = 8;
            // 
            // btnVista
            // 
            btnVista.BackColor = Color.FromArgb(49, 69, 88);
            btnVista.Cursor = Cursors.Hand;
            btnVista.FlatAppearance.BorderSize = 0;
            btnVista.FlatStyle = FlatStyle.Flat;
            btnVista.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnVista.ForeColor = Color.White;
            btnVista.Location = new Point(563, 603);
            btnVista.Name = "btnVista";
            btnVista.Size = new Size(233, 49);
            btnVista.TabIndex = 9;
            btnVista.Text = "Ver vista detallada";
            btnVista.UseVisualStyleBackColor = false;
            btnVista.Click += btnVista_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 6.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(879, 91);
            button1.Name = "button1";
            button1.Size = new Size(152, 20);
            button1.TabIndex = 10;
            button1.Text = "Buscar por código compartido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(31, 557);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mostrar mis notas";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(192, 557);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(145, 19);
            radioButton4.TabIndex = 14;
            radioButton4.Text = "Mostrar notas públicas";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(361, 557);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 19);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Mostrar notas compartidas";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // UCListaNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioButton2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(btnVista);
            Controls.Add(panel1);
            Controls.Add(btnRecargar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCListaNotas";
            Size = new Size(1066, 665);
            ((System.ComponentModel.ISupportInitialize)dataGriedListaNotas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnRecargar;
        public DataGridView dataGriedListaNotas;
        private Panel panel1;
        private Button btnVista;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
    }
}
