namespace Fundamentos
{
    partial class Form14Metodos
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
            lblResultado = new Label();
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            btnDobleRef = new Button();
            btnObjRef = new Button();
            lblMouse = new Label();
            label2 = new Label();
            txtNum = new TextBox();
            txtLetras = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(127, 135);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(127, 84);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(127, 162);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(95, 41);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(127, 209);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(95, 45);
            btnDobleRef.TabIndex = 4;
            btnDobleRef.Text = "Doble Referencia";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // btnObjRef
            // 
            btnObjRef.Location = new Point(127, 260);
            btnObjRef.Name = "btnObjRef";
            btnObjRef.Size = new Size(95, 46);
            btnObjRef.TabIndex = 5;
            btnObjRef.Text = "Objeto Referencia";
            btnObjRef.UseVisualStyleBackColor = true;
            btnObjRef.Click += btnObjRef_Click;
            // 
            // lblMouse
            // 
            lblMouse.BackColor = Color.Aquamarine;
            lblMouse.Location = new Point(323, 188);
            lblMouse.Name = "lblMouse";
            lblMouse.Size = new Size(226, 118);
            lblMouse.TabIndex = 6;
            lblMouse.Text = "lblMouse";
            lblMouse.TextAlign = ContentAlignment.MiddleCenter;
            lblMouse.Click += lblMouse_Click;
            lblMouse.MouseMove += lblMouse_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo Numeros";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(411, 89);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 8;
            txtNum.KeyPress += txtNum_KeyPress;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(411, 137);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLetras);
            Controls.Add(label3);
            Controls.Add(txtNum);
            Controls.Add(label2);
            Controls.Add(lblMouse);
            Controls.Add(btnObjRef);
            Controls.Add(btnDobleRef);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNumero);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            FormClosed += Form14Metodos_FormClosed;
            Load += Form14Metodos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleRef;
        private Button btnObjRef;
        private Label lblMouse;
        private Label label2;
        private TextBox txtNum;
        private TextBox txtLetras;
        private Label label3;
    }
}