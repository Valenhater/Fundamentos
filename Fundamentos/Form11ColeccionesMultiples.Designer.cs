namespace Fundamentos
{
    partial class Form11ColeccionesMultiples
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
            btnBorrar = new Button();
            btnElminar = new Button();
            btnInsert = new Button();
            txtElemento = new TextBox();
            lbl4 = new Label();
            lblIndice = new Label();
            lblSelected = new Label();
            listElements = new ListBox();
            Elementos = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(319, 175);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(128, 25);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnElminar
            // 
            btnElminar.Location = new Point(319, 111);
            btnElminar.Name = "btnElminar";
            btnElminar.Size = new Size(128, 26);
            btnElminar.TabIndex = 16;
            btnElminar.Text = "Eliminar";
            btnElminar.UseVisualStyleBackColor = true;
            btnElminar.Click += btnElminar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(319, 77);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(128, 28);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(319, 48);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(128, 23);
            txtElemento.TabIndex = 14;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(319, 30);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(95, 15);
            lbl4.TabIndex = 13;
            lbl4.Text = "Nuevo elemento";
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(44, 198);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(52, 15);
            lblIndice.TabIndex = 12;
            lblIndice.Text = "lblIndice";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(44, 173);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(90, 15);
            lblSelected.TabIndex = 11;
            lblSelected.Text = "lblSeleccionado";
            // 
            // listElements
            // 
            listElements.FormattingEnabled = true;
            listElements.ItemHeight = 15;
            listElements.Location = new Point(44, 63);
            listElements.Name = "listElements";
            listElements.Size = new Size(120, 94);
            listElements.TabIndex = 10;
            // 
            // Elementos
            // 
            Elementos.AutoSize = true;
            Elementos.Location = new Point(44, 30);
            Elementos.Name = "Elementos";
            Elementos.Size = new Size(62, 15);
            Elementos.TabIndex = 9;
            Elementos.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(319, 143);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(128, 26);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionesMultiples
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 357);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnBorrar);
            Controls.Add(btnElminar);
            Controls.Add(btnInsert);
            Controls.Add(txtElemento);
            Controls.Add(lbl4);
            Controls.Add(lblIndice);
            Controls.Add(lblSelected);
            Controls.Add(listElements);
            Controls.Add(Elementos);
            Name = "Form11ColeccionesMultiples";
            Text = "Form11ColeccionesMultiples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnElminar;
        private Button btnInsert;
        private TextBox txtElemento;
        private Label lbl4;
        private Label lblIndice;
        private Label lblSelected;
        private ListBox listElements;
        private Label Elementos;
        private Button btnSeleccionados;
    }
}