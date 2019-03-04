namespace Registro3UEES
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
            this.txtRegistro1 = new System.Windows.Forms.TextBox();
            this.txtRegistro2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtRegistro3 = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegistro1
            // 
            this.txtRegistro1.Location = new System.Drawing.Point(36, 54);
            this.txtRegistro1.Name = "txtRegistro1";
            this.txtRegistro1.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro1.TabIndex = 0;
            // 
            // txtRegistro2
            // 
            this.txtRegistro2.Location = new System.Drawing.Point(145, 54);
            this.txtRegistro2.Name = "txtRegistro2";
            this.txtRegistro2.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro 3";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(61, 90);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtRegistro3
            // 
            this.txtRegistro3.Location = new System.Drawing.Point(90, 143);
            this.txtRegistro3.Name = "txtRegistro3";
            this.txtRegistro3.ReadOnly = true;
            this.txtRegistro3.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro3.TabIndex = 6;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(145, 90);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 187);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtRegistro3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistro2);
            this.Controls.Add(this.txtRegistro1);
            this.Name = "Form1";
            this.Text = "Calcular Nota de 3er Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistro1;
        private System.Windows.Forms.TextBox txtRegistro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtRegistro3;
        private System.Windows.Forms.Button btnClean;
    }
}

