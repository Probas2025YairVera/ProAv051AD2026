namespace WinFormsApp4
{
    partial class FrmZona
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
            label1 = new Label();
            cboEstadio = new ComboBox();
            label2 = new Label();
            txtNombreZona = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtCupo = new TextBox();
            btnGuardar = new Button();
            btnVerZonas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Estadio:\r\n";
            label1.Click += label1_Click;
            // 
            // cboEstadio
            // 
            cboEstadio.FormattingEnabled = true;
            cboEstadio.Location = new Point(21, 61);
            cboEstadio.Name = "cboEstadio";
            cboEstadio.Size = new Size(121, 23);
            cboEstadio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 29);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Zona:";
            // 
            // txtNombreZona
            // 
            txtNombreZona.Location = new Point(225, 61);
            txtNombreZona.Name = "txtNombreZona";
            txtNombreZona.Size = new Size(100, 23);
            txtNombreZona.TabIndex = 3;
            txtNombreZona.TextChanged += txtNombreZona_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 29);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio Base:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(435, 61);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 29);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Cupo:";
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(603, 61);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(100, 23);
            txtCupo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(225, 163);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Zona";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerZonas
            // 
            btnVerZonas.Location = new Point(435, 163);
            btnVerZonas.Name = "btnVerZonas";
            btnVerZonas.Size = new Size(75, 23);
            btnVerZonas.TabIndex = 9;
            btnVerZonas.Text = "Ver Zonas";
            btnVerZonas.UseVisualStyleBackColor = true;
            btnVerZonas.Click += btnVerZonas_Click;
            // 
            // FrmZona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerZonas);
            Controls.Add(btnGuardar);
            Controls.Add(txtCupo);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombreZona);
            Controls.Add(label2);
            Controls.Add(cboEstadio);
            Controls.Add(label1);
            Name = "FrmZona";
            Text = "FrmZona";
            Load += FrmZona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboEstadio;
        private Label label2;
        private TextBox txtNombreZona;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtCupo;
        private Button btnGuardar;
        private Button btnVerZonas;
    }
}