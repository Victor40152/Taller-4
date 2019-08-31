namespace WindowsFormsApp1
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
            this.lblcalculo = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnprom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalculo
            // 
            this.lblcalculo.AutoSize = true;
            this.lblcalculo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculo.Location = new System.Drawing.Point(276, 48);
            this.lblcalculo.Name = "lblcalculo";
            this.lblcalculo.Size = new System.Drawing.Size(223, 32);
            this.lblcalculo.TabIndex = 0;
            this.lblcalculo.Text = "Calculo de Notas";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(129, 134);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(89, 27);
            this.lblnota1.TabIndex = 1;
            this.lblnota1.Text = "Nota 1:";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(129, 186);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(89, 27);
            this.lblnota2.TabIndex = 2;
            this.lblnota2.Text = "Nota 2:";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(129, 241);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(89, 27);
            this.lblnota3.TabIndex = 3;
            this.lblnota3.Text = "Nota 3:";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(268, 135);
            this.txtnota1.Multiline = true;
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(112, 26);
            this.txtnota1.TabIndex = 4;
            this.txtnota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(268, 186);
            this.txtnota2.Multiline = true;
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(112, 27);
            this.txtnota2.TabIndex = 5;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(268, 241);
            this.txtnota3.Multiline = true;
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(112, 27);
            this.txtnota3.TabIndex = 6;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(134, 317);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 27);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total :";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(262, 312);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(30, 32);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "0";
            // 
            // btnprom
            // 
            this.btnprom.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprom.Location = new System.Drawing.Point(451, 186);
            this.btnprom.Name = "btnprom";
            this.btnprom.Size = new System.Drawing.Size(161, 56);
            this.btnprom.TabIndex = 9;
            this.btnprom.Text = "Promedio";
            this.btnprom.UseVisualStyleBackColor = true;
            this.btnprom.Click += new System.EventHandler(this.btnprom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprom);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.lblcalculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalculo;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnprom;
    }
}

