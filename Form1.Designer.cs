namespace ArchivoDeTexto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLeerDirecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(290, 37);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(162, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "button1";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 266);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(26, 393);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(162, 23);
            this.buttonLeer.TabIndex = 3;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLeerDirecto
            // 
            this.buttonLeerDirecto.Location = new System.Drawing.Point(290, 393);
            this.buttonLeerDirecto.Name = "buttonLeerDirecto";
            this.buttonLeerDirecto.Size = new System.Drawing.Size(162, 23);
            this.buttonLeerDirecto.TabIndex = 4;
            this.buttonLeerDirecto.Text = "Leer Directo";
            this.buttonLeerDirecto.UseVisualStyleBackColor = true;
            this.buttonLeerDirecto.Click += new System.EventHandler(this.buttonLeerDirecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 479);
            this.Controls.Add(this.buttonLeerDirecto);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonLeer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLeerDirecto;
    }
}

