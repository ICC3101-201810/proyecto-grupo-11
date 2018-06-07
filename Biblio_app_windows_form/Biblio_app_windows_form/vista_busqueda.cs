using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
                List<Arriendo> arriendos = null;
                try
                {
                    using (Stream stream = new FileStream("Arriendos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        arriendos = (List<Arriendo>)formatter.Deserialize(stream);
                        stream.Close();
                    }
                }
                catch (IOException)
                {

                }

                foreach(Arriendo a in arriendos)
                {
                    if(a.alumno.sesion == true)
                    {
                        if(a.alumno.Deudas == 0 && copias_txtbox.Text != "0")
                        {
                            ArrendarLibroEventArgs arriendoa = new ArrendarLibroEventArgs();
                            arriendoa.titulo = this.titulo_txtbox.Text;
                            arriendoa.autor = this.autor_txtbox.Text;
                            arriendoa.copia = Convert.ToInt32(this.copias_txtbox.Text);
                            OnArrendar(this, arriendoa);
                            MessageBox.Show("Arriendo Exitoso!");
                        }
                        else if(copias_txtbox.Text == "0")
                        {
                            MessageBox.Show("No quedan copias de este libro");
                        }
                        else
                        {
                            MessageBox.Show("No puede arrendar, tiene una deuda pendiente");
                        }
                    }
                }
            }
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            List<Alumno> alumnos = null;
            List<Libro> libros = null;
            List<Arriendo> arriendos = null;
            try
            {
                using (Stream stream = new FileStream("Alumnos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    alumnos = (List<Alumno>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }

            try
            {
                using (Stream stream = new FileStream("Libros.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    libros = (List<Libro>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }

            try
            {
                using (Stream stream = new FileStream("Arriendos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    arriendos = (List<Arriendo>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }
            
            string busqueda = " ";
            vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
            vista2.Show();
            this.Close();
        }

        private void resultados_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (resultados_listbox.SelectedIndex < libros_a_la_vista.Count && resultados_listbox.SelectedIndex >= 0)
            {
                Libro libro_seleccionado = libros_a_la_vista.ElementAt(resultados_listbox.SelectedIndex);
                titulo_txtbox.Text = libro_seleccionado.Titulos;
                copias_txtbox.Text = libro_seleccionado.Copias.ToString();
                autor_txtbox.Text = libro_seleccionado.GetAutor();
                calification_bar.Value = (int)(libro_seleccionado.GetCalificacion() % 10);
                comets_richtxtbox.Text = libro_seleccionado.MostrarComentarios();
                agno_txtbox.Text = libro_seleccionado.GetFechaPublicacion();
                ubicacion_txtbox.Text = libro_seleccionado.GetUbicacionString();
            }

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
                    if (lib.GetAutor().Contains(busqueda))
                    {
                        libros_a_mostrar_primero.Add(lib);
                    }
                    else
                        libros_a_mostrar_ultimo.Add(lib);
                }
                
                // Falta libro.Carrera o libro.Materia
                if (busqueda == "Carrera")
                {
                    if (lib.GetCarreraAsociada().Contains(busqueda))
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
