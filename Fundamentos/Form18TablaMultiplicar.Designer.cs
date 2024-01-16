namespace Fundamentos
{
    partial class Form18TablaMultiplicar
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
            txtNum = new TextBox();
            btnMostrarTabla = new Button();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(78, 63);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(114, 23);
            txtNum.TabIndex = 1;
            // 
            // btnMostrarTabla
            // 
            btnMostrarTabla.Location = new Point(78, 92);
            btnMostrarTabla.Name = "btnMostrarTabla";
            btnMostrarTabla.Size = new Size(100, 37);
            btnMostrarTabla.TabIndex = 2;
            btnMostrarTabla.Text = "Mostrar tabla";
            btnMostrarTabla.UseVisualStyleBackColor = true;
            btnMostrarTabla.Click += btnMostrarTabla_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(241, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 338);
            panel1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // Form18TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 455);
            Controls.Add(panel1);
            Controls.Add(btnMostrarTabla);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form18TablaMultiplicar";
            Text = "Form18TablaMultiplicar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnMostrarTabla;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}