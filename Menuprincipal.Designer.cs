namespace WinFormsApp4
{
    partial class Menuprincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnEquipos = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnZonas = new Button();
            btnAsientos = new Button();
            btnBoletos = new Button();
            btnPagos = new Button();
            tnFacturas = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(23, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "Estadios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Location = new Point(23, 136);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(75, 23);
            btnEquipos.TabIndex = 1;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 165);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Partidos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnPartidos_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 200);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Clientes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnClientes_Click;
            // 
            // button5
            // 
            button5.Location = new Point(23, 229);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Ventas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(23, 415);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.btnSalir_Click;
            // 
            // btnZonas
            // 
            btnZonas.Location = new Point(23, 107);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(75, 23);
            btnZonas.TabIndex = 7;
            btnZonas.Text = "Zonas\r\n";
            btnZonas.UseVisualStyleBackColor = true;
            btnZonas.Click += btnZonas_Click;
            // 
            // btnAsientos
            // 
            btnAsientos.Location = new Point(23, 258);
            btnAsientos.Name = "btnAsientos";
            btnAsientos.Size = new Size(75, 23);
            btnAsientos.TabIndex = 8;
            btnAsientos.Text = "Asientos";
            btnAsientos.UseVisualStyleBackColor = true;
            btnAsientos.Click += btnAsientos_Click;
            // 
            // btnBoletos
            // 
            btnBoletos.Location = new Point(23, 287);
            btnBoletos.Name = "btnBoletos";
            btnBoletos.Size = new Size(75, 23);
            btnBoletos.TabIndex = 9;
            btnBoletos.Text = "Boletos";
            btnBoletos.UseVisualStyleBackColor = true;
            btnBoletos.Click += btnBoletos_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(23, 316);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(75, 23);
            btnPagos.TabIndex = 10;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // tnFacturas
            // 
            tnFacturas.Location = new Point(23, 345);
            tnFacturas.Name = "tnFacturas";
            tnFacturas.Size = new Size(75, 23);
            tnFacturas.TabIndex = 11;
            tnFacturas.Text = "Facturas";
            tnFacturas.UseVisualStyleBackColor = true;
            tnFacturas.Click += tnFacturas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 12;
            label2.Text = "SISTEMA DE BOLETOS";
            label2.Click += label2_Click;
            // 
            // Menuprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tnFacturas);
            Controls.Add(btnPagos);
            Controls.Add(btnBoletos);
            Controls.Add(btnAsientos);
            Controls.Add(btnZonas);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnEquipos);
            Controls.Add(button1);
            Name = "Menuprincipal";
            Text = "Form1";
            Load += Menuprincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnEquipos;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnZonas;
        private Button btnAsientos;
        private Button btnBoletos;
        private Button btnPagos;
        private Button tnFacturas;
        private Label label2;
    }
}
