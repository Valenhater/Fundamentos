namespace Fundamentos
{
    partial class Form24ListaCompra
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
            btnNuevo = new Button();
            btnLeer = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            lstCompra = new ListBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(127, 250);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 34);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Añadir a la lista";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(127, 290);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(119, 33);
            btnLeer.TabIndex = 1;
            btnLeer.Text = "Leer lista";
            btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(127, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 33);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar lista";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 130);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Alimento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 117);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Lista de la compra";
            // 
            // lstCompra
            // 
            lstCompra.FormattingEnabled = true;
            lstCompra.ItemHeight = 15;
            lstCompra.Location = new Point(306, 147);
            lstCompra.Name = "lstCompra";
            lstCompra.Size = new Size(251, 304);
            lstCompra.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 189);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(127, 207);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            // 
            // Form24ListaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 571);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(lstCompra);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevo);
            Name = "Form24ListaCompra";
            Text = "Form24ListaCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnLeer;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private ListBox lstCompra;
        private Label label3;
        private TextBox txtCantidad;
    }
}