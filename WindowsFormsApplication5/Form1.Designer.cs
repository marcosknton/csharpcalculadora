namespace WindowsFormsApplication5
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
            this.Bcalcular = new System.Windows.Forms.Button();
            this.Tboperador1 = new System.Windows.Forms.TextBox();
            this.Tboperador2 = new System.Windows.Forms.TextBox();
            this.Tbsumar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbmultiplicar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbdivision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbresta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bcalcular
            // 
            this.Bcalcular.Location = new System.Drawing.Point(87, 106);
            this.Bcalcular.Name = "Bcalcular";
            this.Bcalcular.Size = new System.Drawing.Size(100, 23);
            this.Bcalcular.TabIndex = 0;
            this.Bcalcular.Text = "calcular";
            this.Bcalcular.UseVisualStyleBackColor = true;
            this.Bcalcular.Click += new System.EventHandler(this.Bcalcular_Click);
            // 
            // Tboperador1
            // 
            this.Tboperador1.Location = new System.Drawing.Point(22, 58);
            this.Tboperador1.Name = "Tboperador1";
            this.Tboperador1.Size = new System.Drawing.Size(100, 20);
            this.Tboperador1.TabIndex = 1;
            // 
            // Tboperador2
            // 
            this.Tboperador2.Location = new System.Drawing.Point(158, 58);
            this.Tboperador2.Name = "Tboperador2";
            this.Tboperador2.Size = new System.Drawing.Size(100, 20);
            this.Tboperador2.TabIndex = 2;
            // 
            // Tbsumar
            // 
            this.Tbsumar.Location = new System.Drawing.Point(158, 173);
            this.Tbsumar.Name = "Tbsumar";
            this.Tbsumar.Size = new System.Drawing.Size(100, 20);
            this.Tbsumar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "número1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "número2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "suma";
            // 
            // Tbmultiplicar
            // 
            this.Tbmultiplicar.Location = new System.Drawing.Point(158, 230);
            this.Tbmultiplicar.Name = "Tbmultiplicar";
            this.Tbmultiplicar.Size = new System.Drawing.Size(100, 20);
            this.Tbmultiplicar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "multiplicacion";
            // 
            // Tbdivision
            // 
            this.Tbdivision.Location = new System.Drawing.Point(22, 173);
            this.Tbdivision.Name = "Tbdivision";
            this.Tbdivision.Size = new System.Drawing.Size(100, 20);
            this.Tbdivision.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "division";
            // 
            // Tbresta
            // 
            this.Tbresta.Location = new System.Drawing.Point(22, 230);
            this.Tbresta.Name = "Tbresta";
            this.Tbresta.Size = new System.Drawing.Size(100, 20);
            this.Tbresta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = " resta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tbresta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbdivision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbmultiplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbsumar);
            this.Controls.Add(this.Tboperador2);
            this.Controls.Add(this.Tboperador1);
            this.Controls.Add(this.Bcalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bcalcular;
        private System.Windows.Forms.TextBox Tboperador1;
        private System.Windows.Forms.TextBox Tboperador2;
        private System.Windows.Forms.TextBox Tbsumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbmultiplicar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbdivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbresta;
        private System.Windows.Forms.Label label6;
    }
}

