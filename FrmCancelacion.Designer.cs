namespace WinFormsApp4
{
    partial class FrmCancelacion
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
            txtMotivo = new TextBox();
            btnCancelar = new Button();
            btnVerCancelaciones = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // cboVenta
            // 
            cboVenta.FormattingEnabled = true;
            cboVenta.Location = new Point(12, 48);
            cboVenta.Name = "cboVenta";
            cboVenta.Size = new Size(121, 23);
            cboVenta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 123);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(100, 23);
            txtMotivo.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(23, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar Venta";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerCancelaciones
            // 
            btnVerCancelaciones.Location = new Point(23, 256);
            btnVerCancelaciones.Name = "btnVerCancelaciones";
            btnVerCancelaciones.Size = new Size(110, 23);
            btnVerCancelaciones.TabIndex = 5;
            btnVerCancelaciones.Text = "Ver Cancelaciones";
            btnVerCancelaciones.UseVisualStyleBackColor = true;
            btnVerCancelaciones.Click += btnVerCancelaciones_Click;
            // 
            // FrmCancelacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerCancelaciones);
            Controls.Add(btnCancelar);
            Controls.Add(txtMotivo);
            Controls.Add(label2);
            Controls.Add(cboVenta);
            Controls.Add(label1);
            Name = "FrmCancelacion";
            Text = "FrmCancelacion";
            Load += FrmCancelacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboVenta;
        private Label label2;
        private TextBox txtMotivo;
        private Button btnCancelar;
        private Button btnVerCancelaciones;
    }
}