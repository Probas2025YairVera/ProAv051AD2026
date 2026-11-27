namespace WinFormsApp4
{
    partial class FrmPartido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboEstadio = new ComboBox();
            cboLocal = new ComboBox();
            cboVisitante = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnVerPartidos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cboEstadio
            // 
            cboEstadio.FormattingEnabled = true;
            cboEstadio.Location = new Point(12, 62);
            cboEstadio.Name = "cboEstadio";
            cboEstadio.Size = new Size(121, 23);
            cboEstadio.TabIndex = 0;
            cboEstadio.SelectedIndexChanged += cboEstadio_SelectedIndexChanged;
            // 
            // cboLocal
            // 
            cboLocal.FormattingEnabled = true;
            cboLocal.Location = new Point(176, 62);
            cboLocal.Name = "cboLocal";
            cboLocal.Size = new Size(121, 23);
            cboLocal.TabIndex = 1;
            // 
            // cboVisitante
            // 
            cboVisitante.FormattingEnabled = true;
            cboVisitante.Location = new Point(332, 62);
            cboVisitante.Name = "cboVisitante";
            cboVisitante.Size = new Size(121, 23);
            cboVisitante.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(501, 59);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(176, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerPartidos
            // 
            btnVerPartidos.Location = new Point(449, 202);
            btnVerPartidos.Name = "btnVerPartidos";
            btnVerPartidos.Size = new Size(86, 23);
            btnVerPartidos.TabIndex = 5;
            btnVerPartidos.Text = "Ver Partidos";
            btnVerPartidos.UseVisualStyleBackColor = true;
            btnVerPartidos.Click += btnVerPartidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Estadio\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 34);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Equipo local";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 34);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 8;
            label3.Text = "Equipo visitante";
            // 
            // FrmPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVerPartidos);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(cboVisitante);
            Controls.Add(cboLocal);
            Controls.Add(cboEstadio);
            Name = "FrmPartido";
            Text = "FrmPartido";
            Load += FrmPartido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEstadio;
        private ComboBox cboLocal;
        private ComboBox cboVisitante;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnVerPartidos;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}