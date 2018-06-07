namespace Biblio_app_windows_form
{
    partial class vista_busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vista_busqueda));
            this.resultados_listbox = new System.Windows.Forms.ListBox();
            this.busqueda_txtbox = new System.Windows.Forms.TextBox();
            this.busqueda_lbl = new System.Windows.Forms.Label();
            this.arrendar_btn = new System.Windows.Forms.Button();
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.autor_lbl = new System.Windows.Forms.Label();
            this.agno_lbl = new System.Windows.Forms.Label();
            this.copias_lbl = new System.Windows.Forms.Label();
            this.copias_txtbox = new System.Windows.Forms.TextBox();
            this.titulo_txtbox = new System.Windows.Forms.TextBox();
            this.autor_txtbox = new System.Windows.Forms.TextBox();
            this.agno_txtbox = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.volver_btn = new System.Windows.Forms.Button();
            this.calification_bar = new System.Windows.Forms.ProgressBar();
            this.calification_lbl = new System.Windows.Forms.Label();
            this.i_bar_lbl = new System.Windows.Forms.Label();
            this.f_bar_lbl = new System.Windows.Forms.Label();
            this.comets_richtxtbox = new System.Windows.Forms.RichTextBox();
            this.comentarios_lbl = new System.Windows.Forms.Label();
            this.ubicacion_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portada_imgbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.portada_imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultados_listbox
            // 
            this.resultados_listbox.FormattingEnabled = true;
            this.resultados_listbox.ItemHeight = 16;
            this.resultados_listbox.Location = new System.Drawing.Point(32, 55);
            this.resultados_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultados_listbox.MultiColumn = true;
            this.resultados_listbox.Name = "resultados_listbox";
            this.resultados_listbox.Size = new System.Drawing.Size(433, 468);
            this.resultados_listbox.TabIndex = 0;
            this.resultados_listbox.SelectedIndexChanged += new System.EventHandler(this.resultados_listbox_SelectedIndexChanged);
            // 
            // busqueda_txtbox
            // 
            this.busqueda_txtbox.Location = new System.Drawing.Point(117, 12);
            this.busqueda_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.busqueda_txtbox.Name = "busqueda_txtbox";
            this.busqueda_txtbox.Size = new System.Drawing.Size(249, 22);
            this.busqueda_txtbox.TabIndex = 1;
            // 
            // busqueda_lbl
            // 
            this.busqueda_lbl.AutoSize = true;
            this.busqueda_lbl.Location = new System.Drawing.Point(32, 16);
            this.busqueda_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.busqueda_lbl.Name = "busqueda_lbl";
            this.busqueda_lbl.Size = new System.Drawing.Size(76, 17);
            this.busqueda_lbl.TabIndex = 2;
            this.busqueda_lbl.Text = "Busqueda:";
            // 
            // arrendar_btn
            // 
            this.arrendar_btn.Location = new System.Drawing.Point(498, 495);
            this.arrendar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrendar_btn.Name = "arrendar_btn";
            this.arrendar_btn.Size = new System.Drawing.Size(100, 28);
            this.arrendar_btn.TabIndex = 4;
            this.arrendar_btn.Text = "Arrendar";
            this.arrendar_btn.UseVisualStyleBackColor = true;
            this.arrendar_btn.Click += new System.EventHandler(this.arrendar_btn_Click);
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Location = new System.Drawing.Point(689, 58);
            this.titulo_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(43, 17);
            this.titulo_lbl.TabIndex = 5;
            this.titulo_lbl.Text = "Titulo";
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Location = new System.Drawing.Point(689, 88);
            this.autor_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(42, 17);
            this.autor_lbl.TabIndex = 6;
            this.autor_lbl.Text = "Autor";
            // 
            // agno_lbl
            // 
            this.agno_lbl.AutoSize = true;
            this.agno_lbl.Location = new System.Drawing.Point(698, 120);
            this.agno_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agno_lbl.Name = "agno_lbl";
            this.agno_lbl.Size = new System.Drawing.Size(33, 17);
            this.agno_lbl.TabIndex = 7;
            this.agno_lbl.Text = "Año";
            // 
            // copias_lbl
            // 
            this.copias_lbl.AutoSize = true;
            this.copias_lbl.Location = new System.Drawing.Point(771, 196);
            this.copias_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copias_lbl.Name = "copias_lbl";
            this.copias_lbl.Size = new System.Drawing.Size(130, 17);
            this.copias_lbl.TabIndex = 8;
            this.copias_lbl.Text = "Copias disponibles:";
            // 
            // copias_txtbox
            // 
            this.copias_txtbox.Location = new System.Drawing.Point(908, 192);
            this.copias_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copias_txtbox.Name = "copias_txtbox";
            this.copias_txtbox.ReadOnly = true;
            this.copias_txtbox.Size = new System.Drawing.Size(42, 22);
            this.copias_txtbox.TabIndex = 9;
            this.copias_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titulo_txtbox
            // 
            this.titulo_txtbox.Location = new System.Drawing.Point(740, 55);
            this.titulo_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titulo_txtbox.Name = "titulo_txtbox";
            this.titulo_txtbox.ReadOnly = true;
            this.titulo_txtbox.ShortcutsEnabled = false;
            this.titulo_txtbox.Size = new System.Drawing.Size(314, 22);
            this.titulo_txtbox.TabIndex = 10;
            this.titulo_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autor_txtbox
            // 
            this.autor_txtbox.Location = new System.Drawing.Point(740, 85);
            this.autor_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autor_txtbox.Name = "autor_txtbox";
            this.autor_txtbox.ReadOnly = true;
            this.autor_txtbox.ShortcutsEnabled = false;
            this.autor_txtbox.Size = new System.Drawing.Size(314, 22);
            this.autor_txtbox.TabIndex = 11;
            this.autor_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agno_txtbox
            // 
            this.agno_txtbox.Location = new System.Drawing.Point(740, 119);
            this.agno_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agno_txtbox.Name = "agno_txtbox";
            this.agno_txtbox.ReadOnly = true;
            this.agno_txtbox.ShortcutsEnabled = false;
            this.agno_txtbox.Size = new System.Drawing.Size(314, 22);
            this.agno_txtbox.TabIndex = 12;
            this.agno_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(376, 10);
            this.buscar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(91, 28);
            this.buscar_btn.TabIndex = 14;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // volver_btn
            // 
            this.volver_btn.Location = new System.Drawing.Point(931, 495);
            this.volver_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(100, 28);
            this.volver_btn.TabIndex = 15;
            this.volver_btn.Text = "Volver";
            this.volver_btn.UseVisualStyleBackColor = true;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // calification_bar
            // 
            this.calification_bar.Location = new System.Drawing.Point(755, 262);
            this.calification_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calification_bar.Maximum = 10;
            this.calification_bar.Name = "calification_bar";
            this.calification_bar.Size = new System.Drawing.Size(276, 28);
            this.calification_bar.TabIndex = 16;
            // 
            // calification_lbl
            // 
            this.calification_lbl.AutoSize = true;
            this.calification_lbl.Location = new System.Drawing.Point(845, 242);
            this.calification_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calification_lbl.Name = "calification_lbl";
            this.calification_lbl.Size = new System.Drawing.Size(79, 17);
            this.calification_lbl.TabIndex = 17;
            this.calification_lbl.Text = "Calificación";
            // 
            // i_bar_lbl
            // 
            this.i_bar_lbl.AutoSize = true;
            this.i_bar_lbl.Location = new System.Drawing.Point(751, 242);
            this.i_bar_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.i_bar_lbl.Name = "i_bar_lbl";
            this.i_bar_lbl.Size = new System.Drawing.Size(16, 17);
            this.i_bar_lbl.TabIndex = 18;
            this.i_bar_lbl.Text = "0";
            // 
            // f_bar_lbl
            // 
            this.f_bar_lbl.AutoSize = true;
            this.f_bar_lbl.Location = new System.Drawing.Point(1005, 241);
            this.f_bar_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_bar_lbl.Name = "f_bar_lbl";
            this.f_bar_lbl.Size = new System.Drawing.Size(24, 17);
            this.f_bar_lbl.TabIndex = 19;
            this.f_bar_lbl.Text = "10";
            // 
            // comets_richtxtbox
            // 
            this.comets_richtxtbox.Location = new System.Drawing.Point(498, 311);
            this.comets_richtxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comets_richtxtbox.Name = "comets_richtxtbox";
            this.comets_richtxtbox.ReadOnly = true;
            this.comets_richtxtbox.Size = new System.Drawing.Size(531, 162);
            this.comets_richtxtbox.TabIndex = 20;
            this.comets_richtxtbox.Text = "";
            // 
            // comentarios_lbl
            // 
            this.comentarios_lbl.AutoSize = true;
            this.comentarios_lbl.Location = new System.Drawing.Point(495, 294);
            this.comentarios_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comentarios_lbl.Name = "comentarios_lbl";
            this.comentarios_lbl.Size = new System.Drawing.Size(87, 17);
            this.comentarios_lbl.TabIndex = 21;
            this.comentarios_lbl.Text = "Comentarios";
            // 
            // ubicacion_txtbox
            // 
            this.ubicacion_txtbox.Location = new System.Drawing.Point(740, 149);
            this.ubicacion_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ubicacion_txtbox.Name = "ubicacion_txtbox";
            this.ubicacion_txtbox.ReadOnly = true;
            this.ubicacion_txtbox.ShortcutsEnabled = false;
            this.ubicacion_txtbox.Size = new System.Drawing.Size(314, 22);
            this.ubicacion_txtbox.TabIndex = 23;
            this.ubicacion_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ubicación";
            // 
            // portada_imgbox
            // 
            this.portada_imgbox.Location = new System.Drawing.Point(498, 55);
            this.portada_imgbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portada_imgbox.Name = "portada_imgbox";
            this.portada_imgbox.Size = new System.Drawing.Size(155, 235);
            this.portada_imgbox.TabIndex = 3;
            this.portada_imgbox.TabStop = false;
            // 
            // vista_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ubicacion_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comentarios_lbl);
            this.Controls.Add(this.comets_richtxtbox);
            this.Controls.Add(this.f_bar_lbl);
            this.Controls.Add(this.i_bar_lbl);
            this.Controls.Add(this.calification_lbl);
            this.Controls.Add(this.calification_bar);
            this.Controls.Add(this.volver_btn);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.agno_txtbox);
            this.Controls.Add(this.autor_txtbox);
            this.Controls.Add(this.titulo_txtbox);
            this.Controls.Add(this.copias_txtbox);
            this.Controls.Add(this.copias_lbl);
            this.Controls.Add(this.agno_lbl);
            this.Controls.Add(this.autor_lbl);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.arrendar_btn);
            this.Controls.Add(this.portada_imgbox);
            this.Controls.Add(this.busqueda_lbl);
            this.Controls.Add(this.busqueda_txtbox);
            this.Controls.Add(this.resultados_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vista_busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vista_busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.portada_imgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultados_listbox;
        private System.Windows.Forms.TextBox busqueda_txtbox;
        private System.Windows.Forms.Label busqueda_lbl;
        private System.Windows.Forms.Button arrendar_btn;
        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Label autor_lbl;
        private System.Windows.Forms.Label agno_lbl;
        private System.Windows.Forms.Label copias_lbl;
        private System.Windows.Forms.TextBox copias_txtbox;
        private System.Windows.Forms.TextBox titulo_txtbox;
        private System.Windows.Forms.TextBox autor_txtbox;
        private System.Windows.Forms.TextBox agno_txtbox;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Button volver_btn;
        private System.Windows.Forms.ProgressBar calification_bar;
        private System.Windows.Forms.Label calification_lbl;
        private System.Windows.Forms.Label i_bar_lbl;
        private System.Windows.Forms.Label f_bar_lbl;
        private System.Windows.Forms.RichTextBox comets_richtxtbox;
        private System.Windows.Forms.Label comentarios_lbl;
        private System.Windows.Forms.TextBox ubicacion_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox portada_imgbox;
    }
}