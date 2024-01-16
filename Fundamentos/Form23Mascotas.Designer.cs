namespace Fundamentos
{
    partial class Form23Mascotas
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            btnNuevaMascota = new Button();
            btnLeerMascota = new Button();
            btnGuardarMascota = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 115);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(25, 133);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(117, 23);
            txtRaza.TabIndex = 3;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(25, 184);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(117, 33);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnLeerMascota
            // 
            btnLeerMascota.Location = new Point(25, 232);
            btnLeerMascota.Name = "btnLeerMascota";
            btnLeerMascota.Size = new Size(117, 36);
            btnLeerMascota.TabIndex = 5;
            btnLeerMascota.Text = "Leer Mascota";
            btnLeerMascota.UseVisualStyleBackColor = true;
            btnLeerMascota.Click += btnLeerMascota_Click;
            // 
            // btnGuardarMascota
            // 
            btnGuardarMascota.Location = new Point(29, 288);
            btnGuardarMascota.Name = "btnGuardarMascota";
            btnGuardarMascota.Size = new Size(113, 45);
            btnGuardarMascota.TabIndex = 6;
            btnGuardarMascota.Text = "Guardar Mascota";
            btnGuardarMascota.UseVisualStyleBackColor = true;
            btnGuardarMascota.Click += btnGuardarMascota_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 45);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 15;
            lstMascotas.Location = new Point(202, 63);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(255, 289);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form23Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnGuardarMascota);
            Controls.Add(btnLeerMascota);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23Mascotas";
            Text = "Form23Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevaMascota;
        private Button btnLeerMascota;
        private Button btnGuardarMascota;
        private Label label3;
        private ListBox lstMascotas;
    }
}