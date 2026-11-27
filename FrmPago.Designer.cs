namespace WinFormsApp4
{
    partial class FrmPago
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
            cboVenta = new ComboBox();
            label2 = new Label();
            cboMetodo = new ComboBox();
            label3 = new Label();
            txtMonto = new TextBox();
            label4 = new Label();
            txtTitular = new TextBox();
            label5 = new Label();
            txtDigitos = new TextBox();
            label6 = new Label();
            dtpExpiracion = new DateTimePicker();
            btnGuardar = new Button();
            btnVerPagos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // cboVenta
            // 
            cboVenta.FormattingEnabled = true;
            cboVenta.Location = new Point(27, 60);
            cboVenta.Name = "cboVenta";
            cboVenta.Size = new Size(121, 23);
            cboVenta.TabIndex = 1;
            cboVenta.SelectedIndexChanged += cboVenta_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 32);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Metodo de pago";
            // 
            // cboMetodo
            // 
            cboMetodo.FormattingEnabled = true;
            cboMetodo.Location = new Point(230, 60);
            cboMetodo.Name = "cboMetodo";
            cboMetodo.Size = new Size(121, 23);
            cboMetodo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 31);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(437, 60);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 39);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre del Titular";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(600, 57);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(100, 23);
            txtTitular.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 130);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 8;
            label5.Text = "Ultimos 4 Digitos";
            // 
            // txtDigitos
            // 
            txtDigitos.Location = new Point(27, 164);
            txtDigitos.Name = "txtDigitos";
            txtDigitos.Size = new Size(100, 23);
            txtDigitos.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 130);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 10;
            label6.Text = "Fecha de Expiración";
            // 
            // dtpExpiracion
            // 
            dtpExpiracion.Location = new Point(270, 164);
            dtpExpiracion.Name = "dtpExpiracion";
            dtpExpiracion.Size = new Size(200, 23);
            dtpExpiracion.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(36, 243);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar Pago";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerPagos
            // 
            btnVerPagos.Location = new Point(284, 243);
            btnVerPagos.Name = "btnVerPagos";
            btnVerPagos.Size = new Size(75, 23);
            btnVerPagos.TabIndex = 13;
            btnVerPagos.Text = "Ver Pagos";
            btnVerPagos.UseVisualStyleBackColor = true;
            btnVerPagos.Click += btnVerPagos_Click;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerPagos);
            Controls.Add(btnGuardar);
            Controls.Add(dtpExpiracion);
            Controls.Add(label6);
            Controls.Add(txtDigitos);
            Controls.Add(label5);
            Controls.Add(txtTitular);
            Controls.Add(label4);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(cboMetodo);
            Controls.Add(label2);
            Controls.Add(cboVenta);
            Controls.Add(label1);
            Name = "FrmPago";
            Text = "FrmPago";
            Load += FrmPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboVenta;
        private Label label2;
        private ComboBox cboMetodo;
        private Label label3;
        private TextBox txtMonto;
        private Label label4;
        private TextBox txtTitular;
        private Label label5;
        private TextBox txtDigitos;
        private Label label6;
        private DateTimePicker dtpExpiracion;
        private Button btnGuardar;
        private Button btnVerPagos;
    }
}