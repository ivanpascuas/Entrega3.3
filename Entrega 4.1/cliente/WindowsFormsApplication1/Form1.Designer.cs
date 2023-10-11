namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.palindromo_but = new System.Windows.Forms.RadioButton();
            this.MAYUS = new System.Windows.Forms.RadioButton();
            this.Celsius_box = new System.Windows.Forms.TextBox();
            this.Fahrenheit_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fahrenheit_but = new System.Windows.Forms.Button();
            this.celsius_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(126, 80);
            this.IP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(193, 26);
            this.IP.TabIndex = 2;
            this.IP.Text = "192.168.56.102";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 48);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.MAYUS);
            this.groupBox1.Controls.Add(this.palindromo_but);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(174, 118);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(247, 24);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(174, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(233, 24);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // palindromo_but
            // 
            this.palindromo_but.AutoSize = true;
            this.palindromo_but.Location = new System.Drawing.Point(174, 150);
            this.palindromo_but.Name = "palindromo_but";
            this.palindromo_but.Size = new System.Drawing.Size(113, 24);
            this.palindromo_but.TabIndex = 7;
            this.palindromo_but.TabStop = true;
            this.palindromo_but.Text = "Palindromo";
            this.palindromo_but.UseVisualStyleBackColor = true;
            // 
            // MAYUS
            // 
            this.MAYUS.AutoSize = true;
            this.MAYUS.Location = new System.Drawing.Point(174, 180);
            this.MAYUS.Name = "MAYUS";
            this.MAYUS.Size = new System.Drawing.Size(80, 24);
            this.MAYUS.TabIndex = 9;
            this.MAYUS.TabStop = true;
            this.MAYUS.Text = "Mayús";
            this.MAYUS.UseVisualStyleBackColor = true;
            // 
            // Celsius_box
            // 
            this.Celsius_box.Location = new System.Drawing.Point(660, 339);
            this.Celsius_box.Name = "Celsius_box";
            this.Celsius_box.Size = new System.Drawing.Size(100, 26);
            this.Celsius_box.TabIndex = 10;
            // 
            // Fahrenheit_box
            // 
            this.Fahrenheit_box.Location = new System.Drawing.Point(892, 339);
            this.Fahrenheit_box.Name = "Fahrenheit_box";
            this.Fahrenheit_box.Size = new System.Drawing.Size(100, 26);
            this.Fahrenheit_box.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Celsius (ºC)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fahrenheit (ºF)";
            // 
            // fahrenheit_but
            // 
            this.fahrenheit_but.Location = new System.Drawing.Point(633, 390);
            this.fahrenheit_but.Name = "fahrenheit_but";
            this.fahrenheit_but.Size = new System.Drawing.Size(146, 36);
            this.fahrenheit_but.TabIndex = 14;
            this.fahrenheit_but.Text = "Calcular ºF";
            this.fahrenheit_but.UseVisualStyleBackColor = true;
            this.fahrenheit_but.Click += new System.EventHandler(this.fahrenheit_but_Click);
            // 
            // celsius_but
            // 
            this.celsius_but.Location = new System.Drawing.Point(886, 390);
            this.celsius_but.Name = "celsius_but";
            this.celsius_but.Size = new System.Drawing.Size(118, 36);
            this.celsius_but.TabIndex = 15;
            this.celsius_but.Text = "Calcular ºC";
            this.celsius_but.UseVisualStyleBackColor = true;
            this.celsius_but.Click += new System.EventHandler(this.celsius_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
            this.Controls.Add(this.celsius_but);
            this.Controls.Add(this.fahrenheit_but);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fahrenheit_box);
            this.Controls.Add(this.Celsius_box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton palindromo_but;
        private System.Windows.Forms.RadioButton MAYUS;
        private System.Windows.Forms.TextBox Celsius_box;
        private System.Windows.Forms.TextBox Fahrenheit_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fahrenheit_but;
        private System.Windows.Forms.Button celsius_but;
    }
}

