namespace Fundamentos
{
    partial class Form02PosicionColores
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
            label2 = new Label();
            txtVertical = new TextBox();
            txtHorizontal = new TextBox();
            btnPosicion = new Button();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnColor = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 71);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "posicion vertical:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 120);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Posicion horizontal:";
            // 
            // txtVertical
            // 
            txtVertical.Location = new Point(392, 71);
            txtVertical.Name = "txtVertical";
            txtVertical.Size = new Size(100, 23);
            txtVertical.TabIndex = 2;
            // 
            // txtHorizontal
            // 
            txtHorizontal.Location = new Point(392, 117);
            txtHorizontal.Name = "txtHorizontal";
            txtHorizontal.Size = new Size(100, 23);
            txtHorizontal.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(275, 153);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(136, 23);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(275, 211);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 5;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(275, 249);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 6;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(275, 289);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 7;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(275, 327);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 23);
            btnColor.TabIndex = 8;
            btnColor.Text = "Cambiar color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 252);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "verde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 292);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "azul";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 219);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "rojo";
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(btnPosicion);
            Controls.Add(txtHorizontal);
            Controls.Add(txtVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVertical;
        private TextBox txtHorizontal;
        private Button btnPosicion;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnColor;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}