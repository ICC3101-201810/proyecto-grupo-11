namespace Biblio_app_windows_form
{
    partial class vista_administrador
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
            this.arrendar_libro_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo_txtbox = new System.Windows.Forms.TextBox();
            this.autor_txtbox = new System.Windows.Forms.TextBox();
            this.codigo_txtbox = new System.Windows.Forms.TextBox();
            this.fecha_dev_txtbox = new System.Windows.Forms.TextBox();
            this.ingresar_codigo_btn = new System.Windows.Forms.Button();
            this.cerrar_sesion_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrendar_libro_btn
            // 
            this.arrendar_libro_btn.Enabled = false;
            this.arrendar_libro_btn.Location = new System.Drawing.Point(191, 125);
            this.arrendar_libro_btn.Name = "arrendar_libro_btn";
            this.arrendar_libro_btn.Size = new System.Drawing.Size(75, 48);
            this.arrendar_libro_btn.TabIndex = 0;
            this.arrendar_libro_btn.Text = "Arrendar Libro";
            this.arrendar_libro_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha devolución";
            // 
            // titulo_txtbox
            // 
            this.titulo_txtbox.Location = new System.Drawing.Point(135, 12);
            this.titulo_txtbox.Name = "titulo_txtbox";
            this.titulo_txtbox.Size = new System.Drawing.Size(237, 20);
            this.titulo_txtbox.TabIndex = 5;
            // 
            // autor_txtbox
            // 
            this.autor_txtbox.Location = new System.Drawing.Point(135, 38);
            this.autor_txtbox.Name = "autor_txtbox";
            this.autor_txtbox.Size = new System.Drawing.Size(237, 20);
            this.autor_txtbox.TabIndex = 6;
            // 
            // codigo_txtbox
            // 
            this.codigo_txtbox.Location = new System.Drawing.Point(135, 64);
            this.codigo_txtbox.Name = "codigo_txtbox";
            this.codigo_txtbox.Size = new System.Drawing.Size(237, 20);
            this.codigo_txtbox.TabIndex = 7;
            // 
            // fecha_dev_txtbox
            // 
            this.fecha_dev_txtbox.Location = new System.Drawing.Point(135, 90);
            this.fecha_dev_txtbox.Name = "fecha_dev_txtbox";
            this.fecha_dev_txtbox.Size = new System.Drawing.Size(237, 20);
            this.fecha_dev_txtbox.TabIndex = 8;
            // 
            // ingresar_codigo_btn
            // 
            this.ingresar_codigo_btn.Enabled = false;
            this.ingresar_codigo_btn.Location = new System.Drawing.Point(288, 125);
            this.ingresar_codigo_btn.Name = "ingresar_codigo_btn";
            this.ingresar_codigo_btn.Size = new System.Drawing.Size(75, 48);
            this.ingresar_codigo_btn.TabIndex = 9;
            this.ingresar_codigo_btn.Text = "Ingresar código";
            this.ingresar_codigo_btn.UseVisualStyleBackColor = true;
            // 
            // cerrar_sesion_btn
            // 
            this.cerrar_sesion_btn.Enabled = false;
            this.cerrar_sesion_btn.Location = new System.Drawing.Point(23, 125);
            this.cerrar_sesion_btn.Name = "cerrar_sesion_btn";
            this.cerrar_sesion_btn.Size = new System.Drawing.Size(119, 23);
            this.cerrar_sesion_btn.TabIndex = 10;
            this.cerrar_sesion_btn.Text = "Cerrar sesión";
            this.cerrar_sesion_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(23, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vista_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cerrar_sesion_btn);
            this.Controls.Add(this.ingresar_codigo_btn);
            this.Controls.Add(this.fecha_dev_txtbox);
            this.Controls.Add(this.codigo_txtbox);
            this.Controls.Add(this.autor_txtbox);
            this.Controls.Add(this.titulo_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrendar_libro_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "vista_administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio app (admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrendar_libro_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titulo_txtbox;
        private System.Windows.Forms.TextBox autor_txtbox;
        private System.Windows.Forms.TextBox codigo_txtbox;
        private System.Windows.Forms.TextBox fecha_dev_txtbox;
        private System.Windows.Forms.Button ingresar_codigo_btn;
        private System.Windows.Forms.Button cerrar_sesion_btn;
        private System.Windows.Forms.Button button1;
    }
}