namespace Fundamentos
{
    partial class Form13TiendaProductos
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
            txtProducto = new TextBox();
            lstTienda = new ListBox();
            label2 = new Label();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBorrarTodo = new Button();
            btnSeleccionado = new Button();
            btnMovertodos = new Button();
            label3 = new Label();
            lstProductos = new ListBox();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(35, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 1;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.ItemHeight = 15;
            lstTienda.Location = new Point(195, 50);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(120, 244);
            lstTienda.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 32);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Tienda";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(35, 89);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 32);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(35, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(35, 184);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 32);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(35, 233);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 32);
            btnBorrarTodo.TabIndex = 7;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnSeleccionado
            // 
            btnSeleccionado.Location = new Point(340, 98);
            btnSeleccionado.Name = "btnSeleccionado";
            btnSeleccionado.Size = new Size(100, 32);
            btnSeleccionado.TabIndex = 8;
            btnSeleccionado.Text = "Seleccion -->";
            btnSeleccionado.UseVisualStyleBackColor = true;
            btnSeleccionado.Click += btnSeleccionado_Click;
            // 
            // btnMovertodos
            // 
            btnMovertodos.Location = new Point(340, 159);
            btnMovertodos.Name = "btnMovertodos";
            btnMovertodos.Size = new Size(100, 42);
            btnMovertodos.TabIndex = 9;
            btnMovertodos.Text = "Mover todos -->";
            btnMovertodos.UseVisualStyleBackColor = true;
            btnMovertodos.Click += btnMovertodos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 32);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Productos";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(488, 50);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(120, 244);
            lstProductos.TabIndex = 11;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(642, 89);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(100, 32);
            btnSubir.TabIndex = 12;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(642, 159);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(100, 32);
            btnBajar.TabIndex = 13;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstProductos);
            Controls.Add(label3);
            Controls.Add(btnMovertodos);
            Controls.Add(btnSeleccionado);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(label2);
            Controls.Add(lstTienda);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private ListBox lstTienda;
        private Label label2;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBorrarTodo;
        private Button btnSeleccionado;
        private Button btnMovertodos;
        private Label label3;
        private ListBox lstProductos;
        private Button btnSubir;
        private Button btnBajar;
    }
}