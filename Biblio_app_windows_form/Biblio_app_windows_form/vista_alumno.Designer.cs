namespace Biblio_app_windows_form
{
    partial class vista_alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vista_alumno));
            this.buscar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.busqueda_txtbox = new System.Windows.Forms.TextBox();
            this.filtro_cbbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_arr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviso_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.devolver_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deuda_txtbox = new System.Windows.Forms.TextBox();
            this.renovar_btn = new System.Windows.Forms.Button();
            this.pagar_deuda_chkbox = new System.Windows.Forms.CheckBox();
            this.salir_btn = new System.Windows.Forms.Button();
            this.cerrar_sesion_btn = new System.Windows.Forms.Button();
            this.tipo_usuario_label = new System.Windows.Forms.Label();
            this.nombre_usuario_label = new System.Windows.Forms.Label();
            this.comentario_richtextbox = new System.Windows.Forms.RichTextBox();
            this.dejar_comentario_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(639, 96);
            this.buscar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(100, 27);
            this.buscar_btn.TabIndex = 0;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar segun:";
            // 
            // busqueda_txtbox
            // 
            this.busqueda_txtbox.Location = new System.Drawing.Point(291, 97);
            this.busqueda_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.busqueda_txtbox.Name = "busqueda_txtbox";
            this.busqueda_txtbox.Size = new System.Drawing.Size(340, 22);
            this.busqueda_txtbox.TabIndex = 2;
            // 
            // filtro_cbbox
            // 
            this.filtro_cbbox.FormattingEnabled = true;
            this.filtro_cbbox.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Id",
            "Carrera"});
            this.filtro_cbbox.Location = new System.Drawing.Point(121, 97);
            this.filtro_cbbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtro_cbbox.Name = "filtro_cbbox";
            this.filtro_cbbox.Size = new System.Drawing.Size(160, 24);
            this.filtro_cbbox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.autor,
            this.fecha_arr,
            this.fecha_dev,
            this.aviso_estado});
            this.dataGridView1.Location = new System.Drawing.Point(15, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 234);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // fecha_arr
            // 
            this.fecha_arr.HeaderText = "Fecha Arriendo";
            this.fecha_arr.Name = "fecha_arr";
            this.fecha_arr.ReadOnly = true;
            // 
            // fecha_dev
            // 
            this.fecha_dev.HeaderText = "Fecha devolución";
            this.fecha_dev.Name = "fecha_dev";
            this.fecha_dev.ReadOnly = true;
            // 
            // aviso_estado
            // 
            this.aviso_estado.HeaderText = "Estado";
            this.aviso_estado.Name = "aviso_estado";
            this.aviso_estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mis libros";
            // 
            // devolver_btn
            // 
            this.devolver_btn.Location = new System.Drawing.Point(471, 409);
            this.devolver_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devolver_btn.Name = "devolver_btn";
            this.devolver_btn.Size = new System.Drawing.Size(100, 28);
            this.devolver_btn.TabIndex = 8;
            this.devolver_btn.Text = "Devolver";
            this.devolver_btn.UseVisualStyleBackColor = true;
            this.devolver_btn.Click += new System.EventHandler(this.devolver_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto a Pagar";
            // 
            // deuda_txtbox
            // 
            this.deuda_txtbox.Location = new System.Drawing.Point(128, 409);
            this.deuda_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deuda_txtbox.Name = "deuda_txtbox";
            this.deuda_txtbox.ReadOnly = true;
            this.deuda_txtbox.Size = new System.Drawing.Size(209, 22);
            this.deuda_txtbox.TabIndex = 10;
            // 
            // renovar_btn
            // 
            this.renovar_btn.Location = new System.Drawing.Point(579, 409);
            this.renovar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renovar_btn.Name = "renovar_btn";
            this.renovar_btn.Size = new System.Drawing.Size(100, 28);
            this.renovar_btn.TabIndex = 12;
            this.renovar_btn.Text = "Renovar";
            this.renovar_btn.UseVisualStyleBackColor = true;
            this.renovar_btn.Click += new System.EventHandler(this.renovar_btn_Click);
            // 
            // pagar_deuda_chkbox
            // 
            this.pagar_deuda_chkbox.AutoSize = true;
            this.pagar_deuda_chkbox.Location = new System.Drawing.Point(347, 411);
            this.pagar_deuda_chkbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagar_deuda_chkbox.Name = "pagar_deuda_chkbox";
            this.pagar_deuda_chkbox.Size = new System.Drawing.Size(112, 21);
            this.pagar_deuda_chkbox.TabIndex = 13;
            this.pagar_deuda_chkbox.Text = "Pagar deuda";
            this.pagar_deuda_chkbox.UseVisualStyleBackColor = true;
            this.pagar_deuda_chkbox.CheckedChanged += new System.EventHandler(this.pagar_deuda_chkbox_CheckedChanged);
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(603, 537);
            this.salir_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(117, 28);
            this.salir_btn.TabIndex = 14;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // cerrar_sesion_btn
            // 
            this.cerrar_sesion_btn.Location = new System.Drawing.Point(603, 474);
            this.cerrar_sesion_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cerrar_sesion_btn.Name = "cerrar_sesion_btn";
            this.cerrar_sesion_btn.Size = new System.Drawing.Size(116, 28);
            this.cerrar_sesion_btn.TabIndex = 15;
            this.cerrar_sesion_btn.Text = "Cerrar sesión";
            this.cerrar_sesion_btn.UseVisualStyleBackColor = true;
            this.cerrar_sesion_btn.Click += new System.EventHandler(this.cerrar_sesion_btn_Click);
            // 
            // tipo_usuario_label
            // 
            this.tipo_usuario_label.AutoSize = true;
            this.tipo_usuario_label.Location = new System.Drawing.Point(36, 11);
            this.tipo_usuario_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipo_usuario_label.Name = "tipo_usuario_label";
            this.tipo_usuario_label.Size = new System.Drawing.Size(73, 17);
            this.tipo_usuario_label.TabIndex = 16;
            this.tipo_usuario_label.Text = "something";
            // 
            // nombre_usuario_label
            // 
            this.nombre_usuario_label.AutoSize = true;
            this.nombre_usuario_label.Location = new System.Drawing.Point(36, 27);
            this.nombre_usuario_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre_usuario_label.Name = "nombre_usuario_label";
            this.nombre_usuario_label.Size = new System.Drawing.Size(73, 17);
            this.nombre_usuario_label.TabIndex = 17;
            this.nombre_usuario_label.Text = "something";
            // 
            // comentario_richtextbox
            // 
            this.comentario_richtextbox.Location = new System.Drawing.Point(19, 444);
            this.comentario_richtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comentario_richtextbox.Name = "comentario_richtextbox";
            this.comentario_richtextbox.Size = new System.Drawing.Size(548, 159);
            this.comentario_richtextbox.TabIndex = 19;
            this.comentario_richtextbox.Text = "";
            // 
            // dejar_comentario_btn
            // 
            this.dejar_comentario_btn.Location = new System.Drawing.Point(192, 612);
            this.dejar_comentario_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dejar_comentario_btn.Name = "dejar_comentario_btn";
            this.dejar_comentario_btn.Size = new System.Drawing.Size(185, 28);
            this.dejar_comentario_btn.TabIndex = 20;
            this.dejar_comentario_btn.Text = "Dejar comentario";
            this.dejar_comentario_btn.UseVisualStyleBackColor = true;
            this.dejar_comentario_btn.Click += new System.EventHandler(this.dejar_comentario_btn_Click);
            // 
            // vista_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 647);
            this.Controls.Add(this.dejar_comentario_btn);
            this.Controls.Add(this.comentario_richtextbox);
            this.Controls.Add(this.nombre_usuario_label);
            this.Controls.Add(this.tipo_usuario_label);
            this.Controls.Add(this.cerrar_sesion_btn);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.pagar_deuda_chkbox);
            this.Controls.Add(this.renovar_btn);
            this.Controls.Add(this.deuda_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.devolver_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtro_cbbox);
            this.Controls.Add(this.busqueda_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vista_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busqueda_txtbox;
        private System.Windows.Forms.ComboBox filtro_cbbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button devolver_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deuda_txtbox;
        private System.Windows.Forms.Button renovar_btn;
        private System.Windows.Forms.CheckBox pagar_deuda_chkbox;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Button cerrar_sesion_btn;
        private System.Windows.Forms.Label tipo_usuario_label;
        private System.Windows.Forms.Label nombre_usuario_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_arr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviso_estado;
        private System.Windows.Forms.RichTextBox comentario_richtextbox;
        private System.Windows.Forms.Button dejar_comentario_btn;
    }
}