namespace WinFormsApp4
{
    partial class FrmCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtRFC = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnVerClientes = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDomicilio = new TextBox();
            txtTelefonoCasa = new TextBox();
            txtFecha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "RFC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(12, 94);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(100, 23);
            txtRFC.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 147);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new Point(12, 323);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(87, 23);
            btnVerClientes.TabIndex = 9;
            btnVerClientes.Text = "Ver Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 22);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 76);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Teléfono Casa:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 129);
            label7.Name = "label7";
            label7.Size = new Size(181, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha Nacimiento(yyyy-mm-dd)";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(278, 46);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(100, 23);
            txtDomicilio.TabIndex = 13;
            // 
            // txtTelefonoCasa
            // 
            txtTelefonoCasa.Location = new Point(282, 102);
            txtTelefonoCasa.Name = "txtTelefonoCasa";
            txtTelefonoCasa.Size = new Size(100, 23);
            txtTelefonoCasa.TabIndex = 14;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(281, 164);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 15;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFecha);
            Controls.Add(txtTelefonoCasa);
            Controls.Add(txtDomicilio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnVerClientes);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtRFC);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtRFC;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnVerClientes;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDomicilio;
        private TextBox txtTelefonoCasa;
        private TextBox txtFecha;
    }

}