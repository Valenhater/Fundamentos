namespace Fundamentos
{
    partial class Form03DiaNacimiento
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
            btnCalcularDia = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDiaNacimiento = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcularDia
            // 
            btnCalcularDia.Location = new Point(516, 124);
            btnCalcularDia.Name = "btnCalcularDia";
            btnCalcularDia.Size = new Size(122, 151);
            btnCalcularDia.TabIndex = 0;
            btnCalcularDia.Text = "Calcular mi dia de nacimiento";
            btnCalcularDia.UseVisualStyleBackColor = true;
            btnCalcularDia.Click += btnCalcularDia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 127);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 197);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 255);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // lblDiaNacimiento
            // 
            lblDiaNacimiento.AutoSize = true;
            lblDiaNacimiento.Location = new Point(331, 325);
            lblDiaNacimiento.Name = "lblDiaNacimiento";
            lblDiaNacimiento.Size = new Size(99, 15);
            lblDiaNacimiento.TabIndex = 4;
            lblDiaNacimiento.Text = "lblDiaNacimiento";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(382, 124);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(382, 189);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 6;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(382, 252);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 23);
            txtAnyo.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblDiaNacimiento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcularDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularDia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDiaNacimiento;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
    }
}