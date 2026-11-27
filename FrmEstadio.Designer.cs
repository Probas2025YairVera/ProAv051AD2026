namespace WinFormsApp4
{
    partial class FrmEstadio
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
            txtNombre = new TextBox();
            txtCiudad = new TextBox();
            txtCapacidad = new TextBox();
            btnGuardar = new Button();
            btnVerEstadios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 161);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 298);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Capacidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(18, 224);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(100, 23);
            txtCiudad.TabIndex = 4;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(18, 333);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(18, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerEstadios
            // 
            btnVerEstadios.Location = new Point(131, 386);
            btnVerEstadios.Name = "btnVerEstadios";
            btnVerEstadios.Size = new Size(120, 23);
            btnVerEstadios.TabIndex = 7;
            btnVerEstadios.Text = "Ver Estadios";
            btnVerEstadios.UseVisualStyleBackColor = true;
            btnVerEstadios.Click += btnVerEstadios_Click;
            // 
            // FrmEstadio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerEstadios);
            Controls.Add(btnGuardar);
            Controls.Add(txtCapacidad);
            Controls.Add(txtCiudad);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEstadio";
            Text = "FrmEstadio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCiudad;
        private TextBox txtCapacidad;
        private Button btnGuardar;
        private Button btnVerEstadios;
    }
}