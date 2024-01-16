namespace Fundamentos
{
    partial class Form08ValidarISBN
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
            txtISBN = new TextBox();
            btnValidar = new Button();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(108, 51);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(142, 23);
            txtISBN.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(108, 80);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(142, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(108, 128);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(55, 15);
            lblValidar.TabIndex = 3;
            lblValidar.Text = "lblValidar";
            // 
            // Form08ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 317);
            Controls.Add(lblValidar);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Name = "Form08ValidarISBN";
            Text = "Form08ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtISBN;
        private Button btnValidar;
        private Label lblValidar;
    }
}