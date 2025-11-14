namespace AkNotes.Views.UserControls
{
    partial class UCInicio
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
            label3 = new Label();
            circlePanel = new Panel();
            label4 = new Label();
            lblNotasTotalCreadas = new Label();
            label5 = new Label();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 47, 60);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(885, 106);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido de vuelta!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 47, 60);
            label2.Location = new Point(16, 134);
            label2.Name = "label2";
            label2.Size = new Size(115, 37);
            label2.TabIndex = 1;
            label2.Text = "Estatus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(85, 102, 119);
            label3.Location = new Point(112, 174);
            label3.Name = "label3";
            label3.Size = new Size(227, 37);
            label3.TabIndex = 2;
            label3.Text = "Conexión con BD";
            // 
            // circlePanel
            // 
            circlePanel.BackColor = Color.ForestGreen;
            circlePanel.BackgroundImageLayout = ImageLayout.None;
            circlePanel.ForeColor = Color.Teal;
            circlePanel.Location = new Point(66, 174);
            circlePanel.Name = "circlePanel";
            circlePanel.Size = new Size(40, 40);
            circlePanel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(33, 47, 60);
            label4.Location = new Point(16, 247);
            label4.Name = "label4";
            label4.Size = new Size(311, 37);
            label4.TabIndex = 4;
            label4.Text = "Total de notas creadas:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNotasTotalCreadas
            // 
            lblNotasTotalCreadas.AutoSize = true;
            lblNotasTotalCreadas.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotasTotalCreadas.ForeColor = Color.FromArgb(85, 102, 119);
            lblNotasTotalCreadas.Location = new Point(88, 305);
            lblNotasTotalCreadas.Name = "lblNotasTotalCreadas";
            lblNotasTotalCreadas.Size = new Size(28, 37);
            lblNotasTotalCreadas.TabIndex = 5;
            lblNotasTotalCreadas.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 47, 60);
            label5.Location = new Point(16, 380);
            label5.Name = "label5";
            label5.Size = new Size(258, 37);
            label5.TabIndex = 6;
            label5.Text = "Fecha/Hora actual:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(85, 102, 119);
            lblFecha.Location = new Point(88, 452);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(318, 37);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "11/11/2025 01:34:27 p. m.";
            // 
            // UCInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFecha);
            Controls.Add(label5);
            Controls.Add(lblNotasTotalCreadas);
            Controls.Add(label4);
            Controls.Add(circlePanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCInicio";
            Size = new Size(1062, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel circlePanel;
        private Label label4;
        private Label lblNotasTotalCreadas;
        private Label label5;
        private Label lblFecha;
    }
}
