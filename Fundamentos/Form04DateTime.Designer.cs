namespace Fundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            groupBox1 = new GroupBox();
            btnIncremento = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual:";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(41, 69);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(333, 23);
            txtFechaActual.TabIndex = 1;
            txtFechaActual.TextChanged += txtFechaActual_TextChanged;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(41, 109);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(153, 19);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar Formato Fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(6, 31);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(6, 56);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(6, 81);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncremento);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Location = new Point(41, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 121);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar fecha";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(160, 85);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(167, 23);
            btnIncremento.TabIndex = 8;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(160, 56);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(167, 23);
            txtIncremento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 33);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 270);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(41, 288);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(333, 23);
            txtNuevaFecha.TabIndex = 8;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private GroupBox groupBox1;
        private Button btnIncremento;
        private TextBox txtIncremento;
        private Label label2;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}