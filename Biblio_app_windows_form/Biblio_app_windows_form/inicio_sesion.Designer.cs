namespace Biblio_app_windows_form
{
    partial class inicio_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_sesion));
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.salir_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.iniciar_sesion_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(100, 12);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(247, 20);
            this.username_txtbox.TabIndex = 0;
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(226, 64);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(117, 23);
            this.salir_btn.TabIndex = 1;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(100, 38);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(247, 20);
            this.password_txtbox.TabIndex = 4;
            // 
            // iniciar_sesion_btn
            // 
            this.iniciar_sesion_btn.Location = new System.Drawing.Point(100, 65);
            this.iniciar_sesion_btn.Name = "iniciar_sesion_btn";
            this.iniciar_sesion_btn.Size = new System.Drawing.Size(117, 23);
            this.iniciar_sesion_btn.TabIndex = 5;
            this.iniciar_sesion_btn.Text = "Iniciar sesion";
            this.iniciar_sesion_btn.UseVisualStyleBackColor = true;
            this.iniciar_sesion_btn.Click += new System.EventHandler(this.iniciar_sesion_btn_Click);
            // 
            // inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 100);
            this.Controls.Add(this.iniciar_sesion_btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.username_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inicio_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button iniciar_sesion_btn;
    }
}

