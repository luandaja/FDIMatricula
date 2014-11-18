using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DA;
namespace UI
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class PAlumnos : Page
    {
        BL_Alumno bl;
        public PAlumnos()
        {
            bl = new BL_Alumno();
            InitializeComponent();
            RefrescarCBX();
        }
        void RefrescarCBX()
        {
            dtgDatos.ItemsSource = null;
            dtgDatos.ItemsSource = bl.mostrarAlumnos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Alumno a = new Alumno

            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                FechaNac = dtpFechaN.SelectedDate.Value,
                Edad = bl.calcularEdad(dtpFechaN.SelectedDate.Value)
            };
            if (bl.agregarAlumno(a))
            {
                RefrescarCBX();
                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Alumno a = (Alumno)dtgDatos.SelectedItem;
            if (bl.eliminarAlumno(a))
            {
                RefrescarCBX();

                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void CargarInfoAlumnoAActulizar()
        {
            Alumno a = (Alumno)dtgDatos.SelectedItem;
            txtNombre.Text = a.Nombre;
            txtApellido.Text = a.Apellido;
            dtpFechaN.SelectedDate = a.FechaNac;

        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

            Alumno a = (Alumno)dtgDatos.SelectedItem;
            a.Nombre = txtNombre.Text.Trim();
            a.Apellido = txtApellido.Text.Trim();
            a.FechaNac = dtpFechaN.SelectedDate.Value;
            a.Edad = bl.calcularEdad(dtpFechaN.SelectedDate.Value);

            if (bl.actualizarAlumno(a))
            {
                RefrescarCBX();

                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void cbxAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CargarInfoAlumnoAActulizar();
            }
            catch
            {

            }
        }
    }
}
