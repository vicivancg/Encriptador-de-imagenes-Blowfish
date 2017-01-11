namespace blowfish
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtTextoPlano = new System.Windows.Forms.RichTextBox();
            this.txtEnc = new System.Windows.Forms.RichTextBox();
            this.lblTextoPlano = new System.Windows.Forms.Label();
            this.lblTextoEnc = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.Location = new System.Drawing.Point(401, 263);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(83, 41);
            this.btnEncriptar.TabIndex = 0;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDes
            // 
            this.btnDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDes.Location = new System.Drawing.Point(490, 263);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(100, 41);
            this.btnDes.TabIndex = 1;
            this.btnDes.Text = "Desencriptar";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(52, 263);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 57);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Introducir imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtTextoPlano
            // 
            this.txtTextoPlano.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoPlano.Location = new System.Drawing.Point(70, 109);
            this.txtTextoPlano.Name = "txtTextoPlano";
            this.txtTextoPlano.Size = new System.Drawing.Size(227, 120);
            this.txtTextoPlano.TabIndex = 3;
            this.txtTextoPlano.Text = "";
            // 
            // txtEnc
            // 
            this.txtEnc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnc.Location = new System.Drawing.Point(338, 109);
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(227, 120);
            this.txtEnc.TabIndex = 4;
            this.txtEnc.Text = "";
            // 
            // lblTextoPlano
            // 
            this.lblTextoPlano.AutoSize = true;
            this.lblTextoPlano.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPlano.Location = new System.Drawing.Point(67, 93);
            this.lblTextoPlano.Name = "lblTextoPlano";
            this.lblTextoPlano.Size = new System.Drawing.Size(83, 17);
            this.lblTextoPlano.TabIndex = 5;
            this.lblTextoPlano.Text = "Texto plano";
            // 
            // lblTextoEnc
            // 
            this.lblTextoEnc.AutoSize = true;
            this.lblTextoEnc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoEnc.Location = new System.Drawing.Point(335, 93);
            this.lblTextoEnc.Name = "lblTextoEnc";
            this.lblTextoEnc.Size = new System.Drawing.Size(117, 17);
            this.lblTextoEnc.TabIndex = 6;
            this.lblTextoEnc.Text = "Texto encriptado";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(49, 52);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(47, 17);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(113, 49);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(384, 23);
            this.txtClave.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blowfish";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(49, 375);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(175, 17);
            this.lblArchivo.TabIndex = 10;
            this.lblArchivo.Text = "Archivo: No seleccionado";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(244, 254);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(151, 108);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Introducir txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblTextoEnc);
            this.Controls.Add(this.lblTextoPlano);
            this.Controls.Add(this.txtEnc);
            this.Controls.Add(this.txtTextoPlano);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnEncriptar);
            this.Name = "Form1";
            this.Text = "Blowfish";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RichTextBox txtTextoPlano;
        private System.Windows.Forms.RichTextBox txtEnc;
        private System.Windows.Forms.Label lblTextoPlano;
        private System.Windows.Forms.Label lblTextoEnc;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button button1;
    }
}

