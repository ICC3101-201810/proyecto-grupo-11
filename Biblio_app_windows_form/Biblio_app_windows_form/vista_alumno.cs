using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Biblio_app_windows_form
{
    public partial class vista_alumno : Form
    {
        public event EventHandler<ArrendarLibroEventArgs> OnArrendar;
        
        private void ArrendarLibroButton_Click(object sender, EventArgs e)
        {
            ArrendarLibroEventArgs arriendo = new ArrendarLibroEventArgs();
            arriendo.titulo = this.seleccionar_libro_cbbox.Text;
        }

        public void ActualizarLibros(string nuevoLibro)
        {
            
            seleccionar_libro_cbbox.Items.Add(nuevoLibro);
            
        }

        public vista_alumno()
        {
            InitializeComponent();
            tipo_usuario_label.Text = "Alumno";
            nombre_usuario_label.Text = "Prueba";
            filtro_cbbox.Text = "Titulo";
            List<Libro> libros = null;
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
            foreach(Libro l in libros)
            {
                seleccionar_libro_cbbox.Items.Add(l.Titulos+", "+l.GetAutor()+", "+l.Copias+" copias disponibles");
            }
            List<Arriendo> arriendos = null;
            try
            {
                using (Stream stream = new FileStream("Arriendos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    arriendos = (List<Arriendo>)formatter.Deserialize(stream);
                }
            }
            catch (IOException)
            {

            }
            foreach (Arriendo a in arriendos)
            {
                if (a.alumno.GetSesion() == true)
                {
                    
                    for (int i = 0; i < a.libro.Count(); i++)
                    {
                        this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[i].Cells[0].Value = a.libro[i].Titulos;
                        this.dataGridView1.Rows[i].Cells[1].Value = a.libro[i].GetAutor();
                        this.dataGridView1.Rows[i].Cells[2].Value = a.FechaArriendo[i].ToString();
                        this.dataGridView1.Rows[i].Cells[3].Value = a.FechaArriendo[i].AddDays(7).ToString();
                        if(DateTime.Now < a.FechaArriendo[i].AddDays(7))
                        {
                            this.dataGridView1.Rows[i].Cells[4].Value = "En Plazo";
                        }
                        else
                        {
                            this.dataGridView1.Rows[i].Cells[4].Value = "Atrasado";
                        }                    
                    }
                }
            }
        }

        private void devolver_btn_Click(object sender, EventArgs e)
        {
            // revisar la deuda, aunque el boton deberia estar inactivo si el usuario no selecciona pagar
            // devolver el libro
            // quitar de la lista de libros arrendados
        }

        private void pagar_deuda_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (pagar_deuda_chkbox.Checked == true)
            {
                devolver_btn.Enabled = true;
                renovar_btn.Enabled = true;
            }
            if (pagar_deuda_chkbox.Checked == false & deuda_txtbox.Text != "0")
            {
                devolver_btn.Enabled = false;
                renovar_btn.Enabled = false;
            }
        }


        private void buscar_btn_Click(object sender, EventArgs e)
        {
            #region "Prueba"
            // Desde aqui es para probar: Hay 3 libros, en distintas ubicaciones y con distintos comentarios
            /*List<Libro> libros = new List<Libro>(); // temporal, después hay que ver como pasarle la lista filtrada
            List<string> palabras = new List<string> { "muy bueno", "espectacular" };
            Ubicacion tercer_piso = new Ubicacion("norte", 3, 5, 2);
            Libro baldor = new Libro("Ingenieria", 3, "Al Juarismi", "1986", 8, palabras, tercer_piso, "Baldor. Álgebra");
            libros.Add(baldor);
            List<string> palabras2 = new List<string> { "me gusto", "increible" };
            Ubicacion segundo_piso = new Ubicacion("norte", 2, 10, 4);
            Libro metafisica = new Libro("Derecho", 1, "Juan Antonio Widow", "1998", 8, palabras2, segundo_piso, "Curso de Metafísica");
            libros.Add(metafisica);
            List<string> palabras3 = new List<string> { "Buenos ejemplos", "sencillo" };
            Ubicacion primer_piso = new Ubicacion("centro", 1, 2, 2);
            Libro quimica = new Libro("Medicina", 5, "R Chi", "1978", 6, palabras3, primer_piso, "Fundamentos de la Química");
            libros.Add(quimica);*/
            // hasta aqui es de prueba
            #endregion

            List<Libro> libros = null;
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

            // Se revisan los libros segun el criterio de busqueda:

            string busqueda = busqueda_txtbox.Text;
            string filtro = filtro_cbbox.Text;
            List<Libro> libros_a_mostrar = new List<Libro>();// Lista completa con todos los libros
            List<Libro> libros_a_mostrar_primero = new List<Libro>();// Lista con los resultados identicos
            List<Libro> libros_a_mostrar_ultimo = new List<Libro>();// Lista con el resto de libros

            foreach (Libro lib in libros)
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

            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            List<Alumno> alumnos = null;
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
            vista_busqueda vista_Busqueda = new vista_busqueda(busqueda, libros_a_mostrar);
            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista_Busqueda);
            vista_Busqueda.Show();
            this.Close();
            //abrir ventana de resultados de busqueda
        }

        private void cerrar_sesion_btn_Click(object sender, EventArgs e)
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
                }
            }
            catch (IOException)
            {

            }
            foreach (Alumno a in alumnos)
            {
                if (a.sesion == true)
                {
                    a.sesion = false;
                }

            }
            using (Stream stream = new FileStream("Alumnos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, alumnos);
                stream.Close();
            }
            string busqueda = " ";
            vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
            i_s.abrir_inicio();
            //i_s.Show();
            this.Close();
            //abrir_inicio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void renovar_btn_Click(object sender, EventArgs e)
        {
            if (OnArrendar != null)
            {
                ArrendarLibroEventArgs arriendo = new ArrendarLibroEventArgs();
                arriendo.titulo = this.seleccionar_libro_cbbox.Text;
                OnArrendar(this, arriendo);
                MessageBox.Show("Arriendo exitoso");
            }
        }
        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
