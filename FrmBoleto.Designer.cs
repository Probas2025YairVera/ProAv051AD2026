namespace WinFormsApp4
{
    partial class FrmBoleto
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
            cboPartido = new ComboBox();
            label3 = new Label();
            cboAsiento = new ComboBox();
            label4 = new Label();
            txtPrecio = new ComboBox();
            btnGuardar = new Button();
            btnVerBoletos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // cboVenta
            // 
            cboVenta.FormattingEnabled = true;
            cboVenta.Location = new Point(12, 59);
            cboVenta.Name = "cboVenta";
            cboVenta.Size = new Size(121, 23);
            cboVenta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 34);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Partido";
            // 
            // cboPartido
            // 
            cboPartido.FormattingEnabled = true;
            cboPartido.Location = new Point(212, 59);
            cboPartido.Name = "cboPartido";
            cboPartido.Size = new Size(121, 23);
            cboPartido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 34);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Asiento";
            // 
            // cboAsiento
            // 
            cboAsiento.FormattingEnabled = true;
            cboAsiento.Location = new Point(382, 59);
            cboAsiento.Name = "cboAsiento";
            cboAsiento.Size = new Size(121, 23);
            cboAsiento.TabIndex = 5;
            cboAsiento.SelectedIndexChanged += cboAsiento_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 32);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.FormattingEnabled = true;
            txtPrecio.Location = new Point(563, 59);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 224);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Registrar Boleto";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerBoletos
            // 
            btnVerBoletos.Location = new Point(332, 224);
            btnVerBoletos.Name = "btnVerBoletos";
            btnVerBoletos.Size = new Size(75, 23);
            btnVerBoletos.TabIndex = 9;
            btnVerBoletos.Text = "Ver Boletos";
            btnVerBoletos.UseVisualStyleBackColor = true;
            btnVerBoletos.Click += btnVerBoletos_Click;
            // 
            // FrmBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerBoletos);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(cboAsiento);
            Controls.Add(label3);
            Controls.Add(cboPartido);
            Controls.Add(label2);
            Controls.Add(cboVenta);
            Controls.Add(label1);
            Name = "FrmBoleto";
            Text = "FrmBoleto";
            Load += FrmBoleto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboVenta;
        private Label label2;
        private ComboBox cboPartido;
        private Label label3;
        private ComboBox cboAsiento;
        private Label label4;
        private ComboBox txtPrecio;
        private Button btnGuardar;
        private Button btnVerBoletos;
    }
}