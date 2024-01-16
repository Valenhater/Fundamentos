namespace Fundamentos
{
    partial class Form19Temperaturas
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
            label3 = new Label();
            label4 = new Label();
            txtMax = new TextBox();
            txtMin = new TextBox();
            txtMedia = new TextBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            listMeses = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "MESES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 167);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Temperatura maxima";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 249);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Temperatura minima";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 338);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Media anual";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(283, 199);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(52, 23);
            txtMax.TabIndex = 5;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(283, 280);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(52, 23);
            txtMin.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(283, 366);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(52, 23);
            txtMedia.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(255, 59);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(114, 40);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar meses";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(255, 105);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(114, 35);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // listMeses
            // 
            listMeses.FormattingEnabled = true;
            listMeses.ItemHeight = 15;
            listMeses.Location = new Point(12, 72);
            listMeses.Name = "listMeses";
            listMeses.Size = new Size(152, 274);
            listMeses.TabIndex = 10;
            // 
            // Form19Temperaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listMeses);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(txtMedia);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form19Temperaturas";
            Text = "Form19Temperaturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMax;
        private TextBox txtMin;
        private TextBox txtMedia;
        private Button btnGenerar;
        private Button btnMostrar;
        private ListBox listMeses;
    }
}