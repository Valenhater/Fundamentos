namespace Fundamentos
{
    partial class Form22Files
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
            btnNombre = new Button();
            label2 = new Label();
            label3 = new Label();
            lstNombres = new ListBox();
            btnWriteFile = new Button();
            txtContenido = new TextBox();
            btnRead = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(319, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(319, 161);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(100, 33);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Nuevo Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 58);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Contenido File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 58);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 15;
            lstNombres.Location = new Point(538, 84);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(191, 244);
            lstNombres.TabIndex = 5;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(319, 271);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(100, 37);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(44, 84);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(189, 257);
            txtContenido.TabIndex = 7;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(319, 214);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(100, 39);
            btnRead.TabIndex = 8;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Form22Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRead);
            Controls.Add(txtContenido);
            Controls.Add(btnWriteFile);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNombre);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form22Files";
            Text = "Form22Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnNombre;
        private Label label2;
        private Label label3;
        private ListBox lstNombres;
        private Button btnWriteFile;
        private TextBox txtContenido;
        private Button btnRead;
    }
}