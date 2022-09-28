namespace testepessoalcalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelnumero1 = new System.Windows.Forms.Label();
            this.labelnumero2 = new System.Windows.Forms.Label();
            this.textBoxnumero1 = new System.Windows.Forms.TextBox();
            this.textBoxnumero2 = new System.Windows.Forms.TextBox();
            this.buttonsoma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "calculadora";
            // 
            // labelnumero1
            // 
            this.labelnumero1.AutoSize = true;
            this.labelnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero1.Location = new System.Drawing.Point(26, 134);
            this.labelnumero1.Name = "labelnumero1";
            this.labelnumero1.Size = new System.Drawing.Size(114, 29);
            this.labelnumero1.TabIndex = 1;
            this.labelnumero1.Text = "numero 1";
            // 
            // labelnumero2
            // 
            this.labelnumero2.AutoSize = true;
            this.labelnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero2.Location = new System.Drawing.Point(25, 232);
            this.labelnumero2.Name = "labelnumero2";
            this.labelnumero2.Size = new System.Drawing.Size(114, 29);
            this.labelnumero2.TabIndex = 2;
            this.labelnumero2.Text = "numero 2";
            // 
            // textBoxnumero1
            // 
            this.textBoxnumero1.Location = new System.Drawing.Point(242, 123);
            this.textBoxnumero1.Multiline = true;
            this.textBoxnumero1.Name = "textBoxnumero1";
            this.textBoxnumero1.Size = new System.Drawing.Size(106, 50);
            this.textBoxnumero1.TabIndex = 3;
            this.textBoxnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxnumero2
            // 
            this.textBoxnumero2.Location = new System.Drawing.Point(242, 213);
            this.textBoxnumero2.Multiline = true;
            this.textBoxnumero2.Name = "textBoxnumero2";
            this.textBoxnumero2.Size = new System.Drawing.Size(106, 48);
            this.textBoxnumero2.TabIndex = 4;
            // 
            // buttonsoma
            // 
            this.buttonsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsoma.Location = new System.Drawing.Point(242, 350);
            this.buttonsoma.Name = "buttonsoma";
            this.buttonsoma.Size = new System.Drawing.Size(99, 38);
            this.buttonsoma.TabIndex = 5;
            this.buttonsoma.Text = "soma";
            this.buttonsoma.UseVisualStyleBackColor = true;
            this.buttonsoma.Click += new System.EventHandler(this.buttonsoma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESULTADO";
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.Location = new System.Drawing.Point(612, 196);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(30, 31);
            this.labelresultado.TabIndex = 7;
            this.labelresultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonsoma);
            this.Controls.Add(this.textBoxnumero2);
            this.Controls.Add(this.textBoxnumero1);
            this.Controls.Add(this.labelnumero2);
            this.Controls.Add(this.labelnumero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnumero1;
        private System.Windows.Forms.Label labelnumero2;
        private System.Windows.Forms.TextBox textBoxnumero1;
        private System.Windows.Forms.TextBox textBoxnumero2;
        private System.Windows.Forms.Button buttonsoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelresultado;
    }
}

