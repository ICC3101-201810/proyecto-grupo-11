namespace Biblio_app_windows_form
{
    partial class Arrendar_libro
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
            this.arrendar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portada_pictbox = new System.Windows.Forms.PictureBox();
            this.resultados_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo_txtbox = new System.Windows.Forms.TextBox();
            this.autor_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.comentarios_listbox = new System.Windows.Forms.ListBox();
            this.valoraciones_prgsbar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.volver_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.copias_disp_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portada_pictbox)).BeginInit();
            this.SuspendLayout();
            // 
            // arrendar_btn
            // 
            this.arrendar_btn.Location = new System.Drawing.Point(484, 347);
            this.arrendar_btn.Name = "arrendar_btn";
            this.arrendar_btn.Size = new System.Drawing.Size(178, 23);
            this.arrendar_btn.TabIndex = 0;
            this.arrendar_btn.Text = "Arrendar";
            this.arrendar_btn.UseVisualStyleBackColor = true;
            this.arrendar_btn.Click += new System.EventHandler(this.arrendar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados de busqueda";
            // 
            // portada_pictbox
            // 
            this.portada_pictbox.Location = new System.Drawing.Point(484, 31);
            this.portada_pictbox.Name = "portada_pictbox";
            this.portada_pictbox.Size = new System.Drawing.Size(178, 216);
            this.portada_pictbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portada_pictbox.TabIndex = 2;
            this.portada_pictbox.TabStop = false;
            // 
            // resultados_listbox
            // 
            this.resultados_listbox.FormattingEnabled = true;
            this.resultados_listbox.Location = new System.Drawing.Point(12, 32);
            this.resultados_listbox.Name = "resultados_listbox";
            this.resultados_listbox.Size = new System.Drawing.Size(196, 290);
            this.resultados_listbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // titulo_txtbox
            // 
            this.titulo_txtbox.Location = new System.Drawing.Point(484, 253);
            this.titulo_txtbox.Name = "titulo_txtbox";
            this.titulo_txtbox.Size = new System.Drawing.Size(178, 20);
            this.titulo_txtbox.TabIndex = 7;
            // 
            // autor_txtbox
            // 
            this.autor_txtbox.Location = new System.Drawing.Point(484, 276);
            this.autor_txtbox.Name = "autor_txtbox";
            this.autor_txtbox.Size = new System.Drawing.Size(178, 20);
            this.autor_txtbox.TabIndex = 8;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(484, 298);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(178, 20);
            this.id_txtbox.TabIndex = 9;
            // 
            // comentarios_listbox
            // 
            this.comentarios_listbox.FormattingEnabled = true;
            this.comentarios_listbox.Location = new System.Drawing.Point(240, 31);
            this.comentarios_listbox.Name = "comentarios_listbox";
            this.comentarios_listbox.Size = new System.Drawing.Size(179, 290);
            this.comentarios_listbox.TabIndex = 10;
            // 
            // valoraciones_prgsbar
            // 
            this.valoraciones_prgsbar.Location = new System.Drawing.Point(240, 346);
            this.valoraciones_prgsbar.Name = "valoraciones_prgsbar";
            this.valoraciones_prgsbar.Size = new System.Drawing.Size(179, 23);
            this.valoraciones_prgsbar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valoraciones";
            // 
            // volver_btn
            // 
            this.volver_btn.Location = new System.Drawing.Point(12, 347);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(196, 23);
            this.volver_btn.TabIndex = 13;
            this.volver_btn.Text = "Volver";
            this.volver_btn.UseVisualStyleBackColor = true;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Portada";
            // 
            // copias_disp_txtbox
            // 
            this.copias_disp_txtbox.Location = new System.Drawing.Point(571, 321);
            this.copias_disp_txtbox.Name = "copias_disp_txtbox";
            this.copias_disp_txtbox.Size = new System.Drawing.Size(91, 20);
            this.copias_disp_txtbox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copias disponibles";
            // 
            // Arrendar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 387);
            this.Controls.Add(this.copias_disp_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volver_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valoraciones_prgsbar);
            this.Controls.Add(this.comentarios_listbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.autor_txtbox);
            this.Controls.Add(this.titulo_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultados_listbox);
            this.Controls.Add(this.portada_pictbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrendar_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Arrendar_libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrendar_libro";
            ((System.ComponentModel.ISupportInitialize)(this.portada_pictbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrendar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox portada_pictbox;
        private System.Windows.Forms.ListBox resultados_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titulo_txtbox;
        private System.Windows.Forms.TextBox autor_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.ListBox comentarios_listbox;
        private System.Windows.Forms.ProgressBar valoraciones_prgsbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button volver_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox copias_disp_txtbox;
        private System.Windows.Forms.Label label7;
    }
}