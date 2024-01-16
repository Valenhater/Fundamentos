namespace Fundamentos
{
    partial class Form20TestingClases
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
            lstDatosClases = new ListBox();
            btnCrear = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos de Clases";
            // 
            // lstDatosClases
            // 
            lstDatosClases.FormattingEnabled = true;
            lstDatosClases.ItemHeight = 15;
            lstDatosClases.Location = new Point(12, 71);
            lstDatosClases.Name = "lstDatosClases";
            lstDatosClases.Size = new Size(442, 289);
            lstDatosClases.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(474, 71);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(124, 34);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(474, 123);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(124, 36);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Crear Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // Form20TestingClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 443);
            Controls.Add(btnEmpleado);
            Controls.Add(btnCrear);
            Controls.Add(lstDatosClases);
            Controls.Add(label1);
            Name = "Form20TestingClases";
            Text = "Form20TestingClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDatosClases;
        private Button btnCrear;
        private Button btnEmpleado;
    }
}