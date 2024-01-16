namespace Fundamentos
{
    partial class Form09LetraDni
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
            btnDni = new Button();
            label1 = new Label();
            lblDNI = new Label();
            txtDni = new TextBox();
            SuspendLayout();
            // 
            // btnDni
            // 
            btnDni.Location = new Point(147, 119);
            btnDni.Name = "btnDni";
            btnDni.Size = new Size(170, 23);
            btnDni.TabIndex = 0;
            btnDni.Text = "Descubrir letra";
            btnDni.UseVisualStyleBackColor = true;
            btnDni.Click += btnDni_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca DNI";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(147, 175);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "lblDNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(147, 90);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(170, 23);
            txtDni.TabIndex = 3;
            // 
            // Form09LetraDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDni);
            Controls.Add(lblDNI);
            Controls.Add(label1);
            Controls.Add(btnDni);
            Name = "Form09LetraDni";
            Text = "Form09LetraDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDni;
        private Label label1;
        private Label lblDNI;
        private TextBox txtDni;
    }
}