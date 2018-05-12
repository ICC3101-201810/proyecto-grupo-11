﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio_app_windows_form
{
    public partial class vista_administrador : Form
    {
        public event EventHandler<AgregarUsuarioEventArgs> OnAgregarUsuario;
        public event EventHandler<AgregarLibroEventArgs> OnAgregarLibro;
        

        public vista_administrador()
        {
            
            InitializeComponent();

        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrar_sesion_btn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void rut_lbl_Click(object sender, EventArgs e)
        {

        }

        private void vista_administrador_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void agregar_libro_btn_Click(object sender, EventArgs e)
        {
            if (OnAgregarLibro != null)
            {
                AgregarLibroEventArgs libroArgs = new AgregarLibroEventArgs();
                libroArgs.Titulo = this.titulo_txtbox.Text;
                libroArgs.Autor = this.autor_txtbox.Text;
                libroArgs.Copia = Int32.Parse(this.copias_txtbox.Text);
                libroArgs.CarreraAsociada = this.CarreraAsociada_txtBox.Text;
                libroArgs.FechaCreacion = this.fecha_pub_txtbox.Text;
                OnAgregarLibro(this, libroArgs);
                MessageBox.Show("Libro agregado con éxito!");
            }
        }

        private void agreagar_usuario_btn_Click(object sender, EventArgs e)
        {
            if (OnAgregarUsuario != null)
            {
                AgregarUsuarioEventArgs usuarioArgs = new AgregarUsuarioEventArgs();
                usuarioArgs.Nombre = this.nombre_txtbox.Text;
                usuarioArgs.Apellido = this.apellido_txtbox.Text;
                usuarioArgs.Rut = this.rut_txtbox.Text + "-" + this.dgt_ver_txtbox.Text;
                usuarioArgs.Usuario = this.new_username_txtbox.Text;
                usuarioArgs.Password = this.new_password_txtbox.Text;
                OnAgregarUsuario(this, usuarioArgs);
                MessageBox.Show("Usuario creado con éxito!");
            }
        }

        
    }
}
