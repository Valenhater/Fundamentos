namespace Fundamentos
{
    partial class Form10Colecciones
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
            Elementos = new Label();
            listElements = new ListBox();
            lblSelected = new Label();
            lblIndice = new Label();
            lbl4 = new Label();
            txtElemento = new TextBox();
            btnInsert = new Button();
            btnElminar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // Elementos
            // 
            Elementos.AutoSize = true;
            Elementos.Location = new Point(87, 36);
            Elementos.Name = "Elementos";
            Elementos.Size = new Size(62, 15);
            Elementos.TabIndex = 0;
            Elementos.Text = "Elementos";
            // 
            // listElements
            // 
            listElements.FormattingEnabled = true;
            listElements.ItemHeight = 15;
            listElements.Location = new Point(87, 69);
            listElements.Name = "listElements";
            listElements.Size = new Size(120, 94);
            listElements.TabIndex = 1;
            listElements.SelectedIndexChanged += listElements_SelectedIndexChanged;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(87, 179);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(90, 15);
            lblSelected.TabIndex = 2;
            lblSelected.Text = "lblSeleccionado";
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(87, 204);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(52, 15);
            lblIndice.TabIndex = 3;
            lblIndice.Text = "lblIndice";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(362, 36);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(95, 15);
            lbl4.TabIndex = 4;
            lbl4.Text = "Nuevo elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(362, 54);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(128, 23);
            txtElemento.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(362, 83);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(128, 28);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnElminar
            // 
            btnElminar.Location = new Point(362, 117);
            btnElminar.Name = "btnElminar";
            btnElminar.Size = new Size(128, 26);
            btnElminar.TabIndex = 7;
            btnElminar.Text = "Eliminar";
            btnElminar.UseVisualStyleBackColor = true;
            btnElminar.Click += btnElminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(362, 149);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(128, 25);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form10Colecciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnElminar);
            Controls.Add(btnInsert);
            Controls.Add(txtElemento);
            Controls.Add(lbl4);
            Controls.Add(lblIndice);
            Controls.Add(lblSelected);
            Controls.Add(listElements);
            Controls.Add(Elementos);
            Name = "Form10Colecciones";
            Text = "Form10Colecciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Elementos;
        private ListBox listElements;
        private Label lblSelected;
        private Label lblIndice;
        private Label lbl4;
        private TextBox txtElemento;
        private Button btnInsert;
        private Button btnElminar;
        private Button btnBorrar;
    }
}