namespace Fundamentos
{
    partial class Form06ValidarMail
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
            txtMail = new TextBox();
            btnValidar = new Button();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 55);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Escriba un mail";
            label1.Click += label1_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(127, 73);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(174, 23);
            txtMail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(127, 102);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(174, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Mail";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(129, 142);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(99, 15);
            lblValidar.TabIndex = 3;
            lblValidar.Text = "Pulse para validar";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidar);
            Controls.Add(btnValidar);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Button btnValidar;
        private Label lblValidar;
    }
}