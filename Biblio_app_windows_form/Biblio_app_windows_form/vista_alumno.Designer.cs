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
            this.buscar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filtro_cbbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviso_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seleccionar_libro_cbbox = new System.Windows.Forms.ComboBox();
            this.devolver_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deuda_txtbox = new System.Windows.Forms.TextBox();
            this.renovar_btn = new System.Windows.Forms.Button();
            this.pagar_deuda_chkbox = new System.Windows.Forms.CheckBox();
            this.salir_btn = new System.Windows.Forms.Button();
            this.cerrar_sesion_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(481, 12);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_btn.TabIndex = 0;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar segun:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 2;
            // 
            // filtro_cbbox
            // 
            this.filtro_cbbox.FormattingEnabled = true;
            this.filtro_cbbox.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Id",
            "Materia"});
            this.filtro_cbbox.Location = new System.Drawing.Point(92, 12);
            this.filtro_cbbox.Name = "filtro_cbbox";
            this.filtro_cbbox.Size = new System.Drawing.Size(121, 21);
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
            this.id,
            this.fecha_dev,
            this.aviso_estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 190);
            this.dataGridView1.TabIndex = 4;
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
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mis libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar libro";
            // 
            // seleccionar_libro_cbbox
            // 
            this.seleccionar_libro_cbbox.FormattingEnabled = true;
            this.seleccionar_libro_cbbox.Location = new System.Drawing.Point(108, 286);
            this.seleccionar_libro_cbbox.Name = "seleccionar_libro_cbbox";
            this.seleccionar_libro_cbbox.Size = new System.Drawing.Size(157, 21);
            this.seleccionar_libro_cbbox.TabIndex = 7;
            // 
            // devolver_btn
            // 
            this.devolver_btn.Location = new System.Drawing.Point(271, 284);
            this.devolver_btn.Name = "devolver_btn";
            this.devolver_btn.Size = new System.Drawing.Size(75, 23);
            this.devolver_btn.TabIndex = 8;
            this.devolver_btn.Text = "Devolver";
            this.devolver_btn.UseVisualStyleBackColor = true;
            this.devolver_btn.Click += new System.EventHandler(this.devolver_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deuda";
            // 
            // deuda_txtbox
            // 
            this.deuda_txtbox.Location = new System.Drawing.Point(107, 317);
            this.deuda_txtbox.Name = "deuda_txtbox";
            this.deuda_txtbox.Size = new System.Drawing.Size(158, 20);
            this.deuda_txtbox.TabIndex = 10;
            // 
            // renovar_btn
            // 
            this.renovar_btn.Location = new System.Drawing.Point(352, 284);
            this.renovar_btn.Name = "renovar_btn";
            this.renovar_btn.Size = new System.Drawing.Size(75, 23);
            this.renovar_btn.TabIndex = 12;
            this.renovar_btn.Text = "Renovar";
            this.renovar_btn.UseVisualStyleBackColor = true;
            // 
            // pagar_deuda_chkbox
            // 
            this.pagar_deuda_chkbox.AutoSize = true;
            this.pagar_deuda_chkbox.Location = new System.Drawing.Point(271, 319);
            this.pagar_deuda_chkbox.Name = "pagar_deuda_chkbox";
            this.pagar_deuda_chkbox.Size = new System.Drawing.Size(87, 17);
            this.pagar_deuda_chkbox.TabIndex = 13;
            this.pagar_deuda_chkbox.Text = "Pagar deuda";
            this.pagar_deuda_chkbox.UseVisualStyleBackColor = true;
            this.pagar_deuda_chkbox.CheckedChanged += new System.EventHandler(this.pagar_deuda_chkbox_CheckedChanged);
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(468, 323);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(88, 23);
            this.salir_btn.TabIndex = 14;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // cerrar_sesion_btn
            // 
            this.cerrar_sesion_btn.Location = new System.Drawing.Point(468, 294);
            this.cerrar_sesion_btn.Name = "cerrar_sesion_btn";
            this.cerrar_sesion_btn.Size = new System.Drawing.Size(87, 23);
            this.cerrar_sesion_btn.TabIndex = 15;
            this.cerrar_sesion_btn.Text = "Cerrar sesión";
            this.cerrar_sesion_btn.UseVisualStyleBackColor = true;
            // 
            // vista_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 358);
            this.Controls.Add(this.cerrar_sesion_btn);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.pagar_deuda_chkbox);
            this.Controls.Add(this.renovar_btn);
            this.Controls.Add(this.deuda_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.devolver_btn);
            this.Controls.Add(this.seleccionar_libro_cbbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtro_cbbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar_btn);
            this.Name = "vista_alumno";
            this.Text = "Biblio App (alumno)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox filtro_cbbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviso_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seleccionar_libro_cbbox;
        private System.Windows.Forms.Button devolver_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deuda_txtbox;
        private System.Windows.Forms.Button renovar_btn;
        private System.Windows.Forms.CheckBox pagar_deuda_chkbox;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Button cerrar_sesion_btn;
    }
}