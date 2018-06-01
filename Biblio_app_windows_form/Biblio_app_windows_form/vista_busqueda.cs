using System;
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
    public partial class vista_busqueda : Form
    {
        List<Libro> libros_a_la_vista = new List<Libro>();

        public event EventHandler<ArrendarLibroEventArgs> OnArrendar;

        public vista_busqueda(string mi_busqueda, List<Libro> mi_libros)
        {
            InitializeComponent();
            if (busqueda_txtbox != null)
            {
                busqueda_txtbox.Text = mi_busqueda;
                foreach (Libro libro in mi_libros)
                {
                    resultados_listbox.Items.Add(libro.Titulos);
                    libros_a_la_vista.Add(libro);
                }

            }
        }

        private void arrendar_btn_Click(object sender, EventArgs e)
        {
            if(OnArrendar != null)
            {
                ArrendarLibroEventArgs arriendo = new ArrendarLibroEventArgs();
                arriendo.titulo = this.titulo_txtbox.Text;
                arriendo.autor = this.autor_txtbox.Text;
                arriendo.copia = Convert.ToInt32(this.copias_txtbox.Text);
                OnArrendar(this, arriendo);
                MessageBox.Show("Arriendo Exitoso!");
            }
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultados_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro libro_seleccionado = libros_a_la_vista.ElementAt(resultados_listbox.SelectedIndex);
            titulo_txtbox.Text = libro_seleccionado.Titulos;
            copias_txtbox.Text = libro_seleccionado.Copias.ToString();
            autor_txtbox.Text = libro_seleccionado.GetAutor();
            calification_bar.Value = libro_seleccionado.GetCalificacion();
            comets_richtxtbox.Text = libro_seleccionado.MostrarComentarios();
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            resultados_listbox.Items.Clear();

            string filtro = "Titulo";
            string busqueda = busqueda_txtbox.Text;
            List<Libro> libros_a_mostrar = new List<Libro>();// Lista completa con todos los libros
            List<Libro> libros_a_mostrar_primero = new List<Libro>();// Lista con los resultados identicos
            List<Libro> libros_a_mostrar_ultimo = new List<Libro>();// Lista con el resto de libros
            foreach (Libro lib in libros_a_la_vista)
            {
                if (filtro == "Titulo")
                {
                    if (lib.Titulos.Contains(busqueda))
                    {
                        libros_a_mostrar_primero.Add(lib);
                    }
                    else
                        libros_a_mostrar_ultimo.Add(lib);
                }
                if (filtro == "Autor")
                {
                    if (lib.GetAutor() == busqueda)
                    {
                        libros_a_mostrar_primero.Add(lib);
                    }
                    else
                        libros_a_mostrar_ultimo.Add(lib);
                }
                
                // Falta libro.Carrera o libro.Materia
                if (busqueda == "Carrera")
                {
                    if (lib.GetCarreraAsociada() == busqueda)
                    {
                        libros_a_mostrar_primero.Add(lib);
                    }
                    else
                        libros_a_mostrar_ultimo.Add(lib);
                }
                
            }
            foreach (Libro lib in libros_a_mostrar_primero)
            {
                libros_a_mostrar.Add(lib);
            }
            foreach (Libro lib in libros_a_mostrar_ultimo)
            {
                libros_a_mostrar.Add(lib);
            }
            libros_a_la_vista.Clear();
            foreach (Libro libro in libros_a_mostrar)
            {
                resultados_listbox.Items.Add(libro.Titulos);
                libros_a_la_vista.Add(libro);
            }
        }
    }
}
