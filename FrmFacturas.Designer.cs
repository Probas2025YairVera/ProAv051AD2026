namespace WinFormsApp4
{
    partial class FrmFacturas
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
            txtNombre = new TextBox();
            label3 = new Label();
            txtRFC = new TextBox();
            label4 = new Label();
            txtDomicilio = new TextBox();
            btnGuardar = new Button();
            btnVerFacturas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // cboVenta
            // 
            cboVenta.FormattingEnabled = true;
            cboVenta.Location = new Point(31, 57);
            cboVenta.Name = "cboVenta";
            cboVenta.Size = new Size(121, 23);
            cboVenta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 26);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Receptor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(253, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 33);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "RFC";
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(409, 58);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(100, 23);
            txtRFC.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 37);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(565, 62);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(100, 23);
            txtDomicilio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(99, 192);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Generar Factura";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnVerFacturas
            // 
            btnVerFacturas.Location = new Point(341, 192);
            btnVerFacturas.Name = "btnVerFacturas";
            btnVerFacturas.Size = new Size(105, 23);
            btnVerFacturas.TabIndex = 9;
            btnVerFacturas.Text = "Ver Facturas";
            btnVerFacturas.UseVisualStyleBackColor = true;
            btnVerFacturas.Click += btnVerFacturas_Click;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerFacturas);
            Controls.Add(btnGuardar);
            Controls.Add(txtDomicilio);
            Controls.Add(label4);
            Controls.Add(txtRFC);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(cboVenta);
            Controls.Add(label1);
            Name = "FrmFacturas";
            Text = "FrmFacturas";
            Load += FrmFacturas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboVenta;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtRFC;
        private Label label4;
        private TextBox txtDomicilio;
        private Button btnGuardar;
        private Button btnVerFacturas;
    }
}