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
            this.portada_imgbox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.portada_imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultados_listbox
            // 
            this.resultados_listbox.FormattingEnabled = true;
            this.resultados_listbox.Location = new System.Drawing.Point(24, 45);
            this.resultados_listbox.MultiColumn = true;
            this.resultados_listbox.Name = "resultados_listbox";
            this.resultados_listbox.Size = new System.Drawing.Size(326, 381);
            this.resultados_listbox.TabIndex = 0;
            this.resultados_listbox.SelectedIndexChanged += new System.EventHandler(this.resultados_listbox_SelectedIndexChanged);
            // 
            // busqueda_txtbox
            // 
            this.busqueda_txtbox.Location = new System.Drawing.Point(88, 10);
            this.busqueda_txtbox.Name = "busqueda_txtbox";
            this.busqueda_txtbox.Size = new System.Drawing.Size(188, 20);
            this.busqueda_txtbox.TabIndex = 1;
            // 
            // busqueda_lbl
            // 
            this.busqueda_lbl.AutoSize = true;
            this.busqueda_lbl.Location = new System.Drawing.Point(24, 13);
            this.busqueda_lbl.Name = "busqueda_lbl";
            this.busqueda_lbl.Size = new System.Drawing.Size(58, 13);
            this.busqueda_lbl.TabIndex = 2;
            this.busqueda_lbl.Text = "Busqueda:";
            // 
            // portada_imgbox
            // 
            this.portada_imgbox.Location = new System.Drawing.Point(399, 45);
            this.portada_imgbox.Name = "portada_imgbox";
            this.portada_imgbox.Size = new System.Drawing.Size(131, 191);
            this.portada_imgbox.TabIndex = 3;
            this.portada_imgbox.TabStop = false;
            // 
            // arrendar_btn
            // 
            this.arrendar_btn.Location = new System.Drawing.Point(399, 408);
            this.arrendar_btn.Name = "arrendar_btn";
            this.arrendar_btn.Size = new System.Drawing.Size(75, 23);
            this.arrendar_btn.TabIndex = 4;
            this.arrendar_btn.Text = "Arrendar";
            this.arrendar_btn.UseVisualStyleBackColor = true;
            this.arrendar_btn.Click += new System.EventHandler(this.arrendar_btn_Click);
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Location = new System.Drawing.Point(542, 52);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(33, 13);
            this.titulo_lbl.TabIndex = 5;
            this.titulo_lbl.Text = "Titulo";
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Location = new System.Drawing.Point(543, 72);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(32, 13);
            this.autor_lbl.TabIndex = 6;
            this.autor_lbl.Text = "Autor";
            // 
            // agno_lbl
            // 
            this.agno_lbl.AutoSize = true;
            this.agno_lbl.Location = new System.Drawing.Point(549, 98);
            this.agno_lbl.Name = "agno_lbl";
            this.agno_lbl.Size = new System.Drawing.Size(26, 13);
            this.agno_lbl.TabIndex = 7;
            this.agno_lbl.Text = "Año";
            // 
            // copias_lbl
            // 
            this.copias_lbl.AutoSize = true;
            this.copias_lbl.Location = new System.Drawing.Point(578, 129);
            this.copias_lbl.Name = "copias_lbl";
            this.copias_lbl.Size = new System.Drawing.Size(97, 13);
            this.copias_lbl.TabIndex = 8;
            this.copias_lbl.Text = "Copias disponibles:";
            // 
            // copias_txtbox
            // 
            this.copias_txtbox.Location = new System.Drawing.Point(681, 126);
            this.copias_txtbox.Name = "copias_txtbox";
            this.copias_txtbox.ReadOnly = true;
            this.copias_txtbox.Size = new System.Drawing.Size(20, 20);
            this.copias_txtbox.TabIndex = 9;
            this.copias_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titulo_txtbox
            // 
            this.titulo_txtbox.Location = new System.Drawing.Point(581, 45);
            this.titulo_txtbox.Name = "titulo_txtbox";
            this.titulo_txtbox.ReadOnly = true;
            this.titulo_txtbox.ShortcutsEnabled = false;
            this.titulo_txtbox.Size = new System.Drawing.Size(207, 20);
            this.titulo_txtbox.TabIndex = 10;
            this.titulo_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autor_txtbox
            // 
            this.autor_txtbox.Location = new System.Drawing.Point(581, 69);
            this.autor_txtbox.Name = "autor_txtbox";
            this.autor_txtbox.ReadOnly = true;
            this.autor_txtbox.ShortcutsEnabled = false;
            this.autor_txtbox.Size = new System.Drawing.Size(207, 20);
            this.autor_txtbox.TabIndex = 11;
            this.autor_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agno_txtbox
            // 
            this.agno_txtbox.Location = new System.Drawing.Point(581, 95);
            this.agno_txtbox.Name = "agno_txtbox";
            this.agno_txtbox.ReadOnly = true;
            this.agno_txtbox.ShortcutsEnabled = false;
            this.agno_txtbox.Size = new System.Drawing.Size(207, 20);
            this.agno_txtbox.TabIndex = 12;
            this.agno_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(282, 8);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(68, 23);
            this.buscar_btn.TabIndex = 14;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // volver_btn
            // 
            this.volver_btn.Location = new System.Drawing.Point(713, 408);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(75, 23);
            this.volver_btn.TabIndex = 15;
            this.volver_btn.Text = "Volver";
            this.volver_btn.UseVisualStyleBackColor = true;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // calification_bar
            // 
            this.calification_bar.Location = new System.Drawing.Point(566, 213);
            this.calification_bar.Maximum = 10;
            this.calification_bar.Name = "calification_bar";
            this.calification_bar.Size = new System.Drawing.Size(207, 23);
            this.calification_bar.TabIndex = 16;
            // 
            // calification_lbl
            // 
            this.calification_lbl.AutoSize = true;
            this.calification_lbl.Location = new System.Drawing.Point(634, 197);
            this.calification_lbl.Name = "calification_lbl";
            this.calification_lbl.Size = new System.Drawing.Size(61, 13);
            this.calification_lbl.TabIndex = 17;
            this.calification_lbl.Text = "Calificación";
            // 
            // i_bar_lbl
            // 
            this.i_bar_lbl.AutoSize = true;
            this.i_bar_lbl.Location = new System.Drawing.Point(563, 197);
            this.i_bar_lbl.Name = "i_bar_lbl";
            this.i_bar_lbl.Size = new System.Drawing.Size(13, 13);
            this.i_bar_lbl.TabIndex = 18;
            this.i_bar_lbl.Text = "0";
            // 
            // f_bar_lbl
            // 
            this.f_bar_lbl.AutoSize = true;
            this.f_bar_lbl.Location = new System.Drawing.Point(754, 196);
            this.f_bar_lbl.Name = "f_bar_lbl";
            this.f_bar_lbl.Size = new System.Drawing.Size(19, 13);
            this.f_bar_lbl.TabIndex = 19;
            this.f_bar_lbl.Text = "10";
            // 
            // comets_richtxtbox
            // 
            this.comets_richtxtbox.Location = new System.Drawing.Point(399, 253);
            this.comets_richtxtbox.Name = "comets_richtxtbox";
            this.comets_richtxtbox.ReadOnly = true;
            this.comets_richtxtbox.Size = new System.Drawing.Size(374, 132);
            this.comets_richtxtbox.TabIndex = 20;
            this.comets_richtxtbox.Text = "";
            // 
            // comentarios_lbl
            // 
            this.comentarios_lbl.AutoSize = true;
            this.comentarios_lbl.Location = new System.Drawing.Point(396, 239);
            this.comentarios_lbl.Name = "comentarios_lbl";
            this.comentarios_lbl.Size = new System.Drawing.Size(65, 13);
            this.comentarios_lbl.TabIndex = 21;
            this.comentarios_lbl.Text = "Comentarios";
            // 
            // vista_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.PictureBox portada_imgbox;
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
    }
}