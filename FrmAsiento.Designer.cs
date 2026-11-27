namespace WinFormsApp4
{
    partial class FrmAsiento
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
            cboZona = new ComboBox();
            label2 = new Label();
            txtFila = new TextBox();
            label3 = new Label();
            txtNumeroAsiento = new TextBox();
            btnGuardar = new Button();
            btnVerAsientos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Zona";
            label1.Click += label1_Click;
            // 
            // cboZona
            // 
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(22, 61);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(121, 23);
            cboZona.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 29);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Flia";
            // 
            // txtFila
            // 
            txtFila.Location = new Point(204, 61);
            txtFila.Name = "txtFila";
            txtFila.Size = new Size(100, 23);
            txtFila.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 23);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Numero de Asiento";
            // 
            // txtNumeroAsiento
            // 
            txtNumeroAsiento.Location = new Point(369, 61);
            txtNumeroAsiento.Name = "txtNumeroAsiento";
            txtNumeroAsiento.Size = new Size(100, 23);
            txtNumeroAsiento.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(22, 145);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Asiento";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerAsientos
            // 
            btnVerAsientos.Location = new Point(204, 145);
            btnVerAsientos.Name = "btnVerAsientos";
            btnVerAsientos.Size = new Size(75, 23);
            btnVerAsientos.TabIndex = 7;
            btnVerAsientos.Text = "Ver Asiento";
            btnVerAsientos.UseVisualStyleBackColor = true;
            btnVerAsientos.Click += btnVerAsientos_Click;
            // 
            // FrmAsiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerAsientos);
            Controls.Add(btnGuardar);
            Controls.Add(txtNumeroAsiento);
            Controls.Add(label3);
            Controls.Add(txtFila);
            Controls.Add(label2);
            Controls.Add(cboZona);
            Controls.Add(label1);
            Name = "FrmAsiento";
            Text = "FrmAsiento";
            Load += FrmAsiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboZona;
        private Label label2;
        private TextBox txtFila;
        private Label label3;
        private TextBox txtNumeroAsiento;
        private Button btnGuardar;
        private Button btnVerAsientos;
    }
}