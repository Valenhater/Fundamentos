namespace Fundamentos
{
    partial class Form12PracticaColeccionesNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            label4 = new Label();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 64);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(57, 93);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(136, 169);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(279, 93);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(122, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(279, 122);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(122, 23);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 166);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 210);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Pares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(334, 163);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 6;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(334, 202);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 245);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(334, 245);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // Form12PracticaColeccionesNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form12PracticaColeccionesNumeros";
            Text = "Form12PracticaColeccionesNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label label4;
        private TextBox txtImpares;
    }
}