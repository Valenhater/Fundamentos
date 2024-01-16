namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            txtNumeros = new TextBox();
            lblSuma = new Label();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(48, 52);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(153, 23);
            txtNumeros.TabIndex = 1;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(48, 134);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(50, 15);
            lblSuma.TabIndex = 2;
            lblSuma.Text = "lblSuma";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(48, 81);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(153, 27);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 462);
            Controls.Add(btnSumar);
            Controls.Add(lblSuma);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Label lblSuma;
        private Button btnSumar;
    }
}