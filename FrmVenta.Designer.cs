namespace WinFormsApp4
{
    partial class FrmVenta
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
            cboCliente = new ComboBox();
            label2 = new Label();
            cboPartido = new ComboBox();
            label3 = new Label();
            cboZona = new ComboBox();
            label4 = new Label();
            txtSubtotal = new TextBox();
            label5 = new Label();
            txtIVA = new TextBox();
            label6 = new Label();
            txtTotal = new TextBox();
            btnGuardar = new Button();
            btnVerVentas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(12, 55);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(121, 23);
            cboCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 21);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Partido";
            // 
            // cboPartido
            // 
            cboPartido.FormattingEnabled = true;
            cboPartido.Location = new Point(175, 55);
            cboPartido.Name = "cboPartido";
            cboPartido.Size = new Size(121, 23);
            cboPartido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 26);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Zona";
            // 
            // cboZona
            // 
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(342, 54);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(121, 23);
            cboZona.TabIndex = 5;
            cboZona.SelectedIndexChanged += cboZona_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 172);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(29, 205);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 172);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 8;
            label5.Text = "IVA";
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(177, 205);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 23);
            txtIVA.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 172);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(348, 204);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(29, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Registrar Venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerVentas
            // 
            btnVerVentas.Location = new Point(244, 289);
            btnVerVentas.Name = "btnVerVentas";
            btnVerVentas.Size = new Size(75, 23);
            btnVerVentas.TabIndex = 14;
            btnVerVentas.Text = "Ver Ventas";
            btnVerVentas.UseVisualStyleBackColor = true;
            btnVerVentas.Click += btnVerVentas_Click;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerVentas);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(txtIVA);
            Controls.Add(label5);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(cboZona);
            Controls.Add(label3);
            Controls.Add(cboPartido);
            Controls.Add(label2);
            Controls.Add(cboCliente);
            Controls.Add(label1);
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCliente;
        private Label label2;
        private ComboBox cboPartido;
        private Label label3;
        private ComboBox cboZona;
        private Label label4;
        private TextBox txtSubtotal;
        private Label label5;
        private TextBox txtIVA;
        private Label label6;
        private TextBox txtTotal;
        private Button btnGuardar;
        private Button btnVerVentas;
    }
}