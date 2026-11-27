namespace WinFormsApp4
{
    partial class FrmEquipos
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
            txtNombreEquipo = new TextBox();
            btnGuardar = new Button();
            btnVerEquipos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del equipo:";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(12, 65);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(100, 23);
            txtNombreEquipo.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 122);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerEquipos
            // 
            btnVerEquipos.Location = new Point(12, 165);
            btnVerEquipos.Name = "btnVerEquipos";
            btnVerEquipos.Size = new Size(88, 23);
            btnVerEquipos.TabIndex = 3;
            btnVerEquipos.Text = "Ver Equipos";
            btnVerEquipos.UseVisualStyleBackColor = true;
            btnVerEquipos.Click += btnVerEquipos_Click;
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerEquipos);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label1);
            Name = "FrmEquipos";
            Text = "FrmEquipos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreEquipo;
        private Button btnGuardar;
        private Button btnVerEquipos;
    }
}