﻿namespace Operaciones_Matematicas_CS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsuma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmultip = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(37, 239);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(123, 40);
            this.btnsuma.TabIndex = 0;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "numero 2:";
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(213, 239);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(123, 40);
            this.btnresta.TabIndex = 7;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // btnmultip
            // 
            this.btnmultip.Location = new System.Drawing.Point(397, 239);
            this.btnmultip.Name = "btnmultip";
            this.btnmultip.Size = new System.Drawing.Size(123, 40);
            this.btnmultip.TabIndex = 8;
            this.btnmultip.Text = "Multiplicacion";
            this.btnmultip.UseVisualStyleBackColor = true;
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(574, 239);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(123, 40);
            this.btndiv.TabIndex = 9;
            this.btndiv.Text = "Division";
            this.btndiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmultip);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsuma);
            this.Name = "Form1";
            this.Text = "Formulario de operaciones basicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmultip;
        private System.Windows.Forms.Button btndiv;
    }
}

