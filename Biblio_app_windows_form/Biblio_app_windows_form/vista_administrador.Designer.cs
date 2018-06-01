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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vista_administrador));
            this.agregar_libro_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo_txtbox = new System.Windows.Forms.TextBox();
            this.autor_txtbox = new System.Windows.Forms.TextBox();
            this.copias_txtbox = new System.Windows.Forms.TextBox();
            this.fecha_pub_txtbox = new System.Windows.Forms.TextBox();
            this.agreagar_usuario_btn = new System.Windows.Forms.Button();
            this.cerrar_sesion_btn = new System.Windows.Forms.Button();
            this.salir_btn = new System.Windows.Forms.Button();
            this.new_password_txtbox = new System.Windows.Forms.TextBox();
            this.new_username_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre_txtbox = new System.Windows.Forms.TextBox();
            this.rut_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rut_lbl = new System.Windows.Forms.Label();
            this.dgt_ver_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.apellido_txtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tipo_alumno_rdiobtn = new System.Windows.Forms.RadioButton();
            this.tipo_profesor_rdiobtn = new System.Windows.Forms.RadioButton();
            this.tipo_grpbox = new System.Windows.Forms.GroupBox();
            this.CarreraAsociada_txtBox = new System.Windows.Forms.TextBox();
            this.carrera = new System.Windows.Forms.Label();
            this.tipo_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // agregar_libro_btn
            // 
            this.agregar_libro_btn.Location = new System.Drawing.Point(297, 162);
            this.agregar_libro_btn.Name = "agregar_libro_btn";
            this.agregar_libro_btn.Size = new System.Drawing.Size(75, 48);
            this.agregar_libro_btn.TabIndex = 0;
            this.agregar_libro_btn.Text = "Agregar Libro";
            this.agregar_libro_btn.UseVisualStyleBackColor = true;
            this.agregar_libro_btn.Click += new System.EventHandler(this.agregar_libro_btn_Click);
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
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Publicación";
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
            // copias_txtbox
            // 
            this.copias_txtbox.Location = new System.Drawing.Point(135, 64);
            this.copias_txtbox.Name = "copias_txtbox";
            this.copias_txtbox.Size = new System.Drawing.Size(237, 20);
            this.copias_txtbox.TabIndex = 7;
            // 
            // fecha_pub_txtbox
            // 
            this.fecha_pub_txtbox.Location = new System.Drawing.Point(135, 90);
            this.fecha_pub_txtbox.Name = "fecha_pub_txtbox";
            this.fecha_pub_txtbox.Size = new System.Drawing.Size(237, 20);
            this.fecha_pub_txtbox.TabIndex = 8;
            // 
            // agreagar_usuario_btn
            // 
            this.agreagar_usuario_btn.Location = new System.Drawing.Point(296, 338);
            this.agreagar_usuario_btn.Name = "agreagar_usuario_btn";
            this.agreagar_usuario_btn.Size = new System.Drawing.Size(75, 48);
            this.agreagar_usuario_btn.TabIndex = 9;
            this.agreagar_usuario_btn.Text = "Crear un nuevo usuario";
            this.agreagar_usuario_btn.UseVisualStyleBackColor = true;
            this.agreagar_usuario_btn.Click += new System.EventHandler(this.agreagar_usuario_btn_Click);
            // 
            // cerrar_sesion_btn
            // 
            this.cerrar_sesion_btn.Location = new System.Drawing.Point(253, 394);
            this.cerrar_sesion_btn.Name = "cerrar_sesion_btn";
            this.cerrar_sesion_btn.Size = new System.Drawing.Size(119, 23);
            this.cerrar_sesion_btn.TabIndex = 10;
            this.cerrar_sesion_btn.Text = "Cerrar sesión";
            this.cerrar_sesion_btn.UseVisualStyleBackColor = true;
            this.cerrar_sesion_btn.Click += new System.EventHandler(this.cerrar_sesion_btn_Click);
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(253, 423);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(119, 23);
            this.salir_btn.TabIndex = 11;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // new_password_txtbox
            // 
            this.new_password_txtbox.Location = new System.Drawing.Point(134, 240);
            this.new_password_txtbox.Name = "new_password_txtbox";
            this.new_password_txtbox.Size = new System.Drawing.Size(237, 20);
            this.new_password_txtbox.TabIndex = 15;
            // 
            // new_username_txtbox
            // 
            this.new_username_txtbox.Location = new System.Drawing.Point(134, 216);
            this.new_username_txtbox.Name = "new_username_txtbox";
            this.new_username_txtbox.Size = new System.Drawing.Size(237, 20);
            this.new_username_txtbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username";
            // 
            // nombre_txtbox
            // 
            this.nombre_txtbox.Location = new System.Drawing.Point(134, 289);
            this.nombre_txtbox.Name = "nombre_txtbox";
            this.nombre_txtbox.Size = new System.Drawing.Size(237, 20);
            this.nombre_txtbox.TabIndex = 21;
            // 
            // rut_txtbox
            // 
            this.rut_txtbox.Location = new System.Drawing.Point(134, 265);
            this.rut_txtbox.MaxLength = 8;
            this.rut_txtbox.Name = "rut_txtbox";
            this.rut_txtbox.Size = new System.Drawing.Size(202, 20);
            this.rut_txtbox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre";
            // 
            // rut_lbl
            // 
            this.rut_lbl.AutoSize = true;
            this.rut_lbl.Location = new System.Drawing.Point(38, 267);
            this.rut_lbl.Name = "rut_lbl";
            this.rut_lbl.Size = new System.Drawing.Size(30, 13);
            this.rut_lbl.TabIndex = 18;
            this.rut_lbl.Text = "RUT";
            this.rut_lbl.Click += new System.EventHandler(this.rut_lbl_Click);
            // 
            // dgt_ver_txtbox
            // 
            this.dgt_ver_txtbox.Location = new System.Drawing.Point(354, 265);
            this.dgt_ver_txtbox.MaxLength = 1;
            this.dgt_ver_txtbox.Name = "dgt_ver_txtbox";
            this.dgt_ver_txtbox.Size = new System.Drawing.Size(19, 20);
            this.dgt_ver_txtbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "-";
            // 
            // apellido_txtbox
            // 
            this.apellido_txtbox.Location = new System.Drawing.Point(135, 314);
            this.apellido_txtbox.Name = "apellido_txtbox";
            this.apellido_txtbox.Size = new System.Drawing.Size(237, 20);
            this.apellido_txtbox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Apellido";
            // 
            // tipo_alumno_rdiobtn
            // 
            this.tipo_alumno_rdiobtn.AutoSize = true;
            this.tipo_alumno_rdiobtn.Checked = true;
            this.tipo_alumno_rdiobtn.Location = new System.Drawing.Point(6, 19);
            this.tipo_alumno_rdiobtn.Name = "tipo_alumno_rdiobtn";
            this.tipo_alumno_rdiobtn.Size = new System.Drawing.Size(60, 17);
            this.tipo_alumno_rdiobtn.TabIndex = 26;
            this.tipo_alumno_rdiobtn.TabStop = true;
            this.tipo_alumno_rdiobtn.Text = "Alumno";
            this.tipo_alumno_rdiobtn.UseVisualStyleBackColor = true;
            // 
            // tipo_profesor_rdiobtn
            // 
            this.tipo_profesor_rdiobtn.AutoSize = true;
            this.tipo_profesor_rdiobtn.Location = new System.Drawing.Point(94, 19);
            this.tipo_profesor_rdiobtn.Name = "tipo_profesor_rdiobtn";
            this.tipo_profesor_rdiobtn.Size = new System.Drawing.Size(64, 17);
            this.tipo_profesor_rdiobtn.TabIndex = 27;
            this.tipo_profesor_rdiobtn.TabStop = true;
            this.tipo_profesor_rdiobtn.Text = "Profesor";
            this.tipo_profesor_rdiobtn.UseVisualStyleBackColor = true;
            // 
            // tipo_grpbox
            // 
            this.tipo_grpbox.Controls.Add(this.tipo_alumno_rdiobtn);
            this.tipo_grpbox.Controls.Add(this.tipo_profesor_rdiobtn);
            this.tipo_grpbox.Location = new System.Drawing.Point(40, 338);
            this.tipo_grpbox.Name = "tipo_grpbox";
            this.tipo_grpbox.Size = new System.Drawing.Size(189, 48);
            this.tipo_grpbox.TabIndex = 28;
            this.tipo_grpbox.TabStop = false;
            this.tipo_grpbox.Text = "Tipo";
            // 
            // CarreraAsociada_txtBox
            // 
            this.CarreraAsociada_txtBox.Location = new System.Drawing.Point(134, 114);
            this.CarreraAsociada_txtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarreraAsociada_txtBox.Name = "CarreraAsociada_txtBox";
            this.CarreraAsociada_txtBox.Size = new System.Drawing.Size(237, 20);
            this.CarreraAsociada_txtBox.TabIndex = 29;
            // 
            // carrera
            // 
            this.carrera.AutoSize = true;
            this.carrera.Location = new System.Drawing.Point(38, 116);
            this.carrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(88, 13);
            this.carrera.TabIndex = 30;
            this.carrera.Text = "Carrera Asociada";
            // 
            // vista_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 457);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.CarreraAsociada_txtBox);
            this.Controls.Add(this.tipo_grpbox);
            this.Controls.Add(this.apellido_txtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgt_ver_txtbox);
            this.Controls.Add(this.nombre_txtbox);
            this.Controls.Add(this.rut_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rut_lbl);
            this.Controls.Add(this.new_password_txtbox);
            this.Controls.Add(this.new_username_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.cerrar_sesion_btn);
            this.Controls.Add(this.agreagar_usuario_btn);
            this.Controls.Add(this.fecha_pub_txtbox);
            this.Controls.Add(this.copias_txtbox);
            this.Controls.Add(this.autor_txtbox);
            this.Controls.Add(this.titulo_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregar_libro_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vista_administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio app (admin)";
            this.Load += new System.EventHandler(this.vista_administrador_Load);
            this.tipo_grpbox.ResumeLayout(false);
            this.tipo_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar_libro_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titulo_txtbox;
        private System.Windows.Forms.TextBox autor_txtbox;
        private System.Windows.Forms.TextBox copias_txtbox;
        private System.Windows.Forms.TextBox fecha_pub_txtbox;
        private System.Windows.Forms.Button agreagar_usuario_btn;
        private System.Windows.Forms.Button cerrar_sesion_btn;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.TextBox new_password_txtbox;
        private System.Windows.Forms.TextBox new_username_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre_txtbox;
        private System.Windows.Forms.TextBox rut_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rut_lbl;
        private System.Windows.Forms.TextBox dgt_ver_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox apellido_txtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton tipo_alumno_rdiobtn;
        private System.Windows.Forms.RadioButton tipo_profesor_rdiobtn;
        private System.Windows.Forms.GroupBox tipo_grpbox;
        private System.Windows.Forms.TextBox CarreraAsociada_txtBox;
        private System.Windows.Forms.Label carrera;
    }
}