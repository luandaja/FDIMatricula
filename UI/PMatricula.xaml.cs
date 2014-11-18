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
using BL;
using DA;
namespace UI
{
    /// <summary>
    /// Lógica de interacción para PMatricula.xaml
    /// </summary>
    public partial class PMatricula : Page
    {
        BL.BL_Matricula bl = new BL.BL_Matricula();
        public PMatricula()
        {
            InitializeComponent();
            IniciarBindings();
            Refrescar();
            
        }
        void IniciarBindings()
        {
            lbxAlumno.ItemsSource = (new BL_Alumno()).mostrarAlumnos();
            lbxCurso.ItemsSource = (new BL_Curso()).mostrarCursos();

        }
        void Refrescar()
        {
            dtgDatos.ItemsSource = null;
            dtgDatos.ItemsSource = bl.mostrarMatriculas();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Matricula a = new Matricula
            {
                 FK_AlumnoID = ((Alumno)lbxAlumno.SelectedItem).ID,
                 FK_CursoID = ((Curso)lbxCurso.SelectedItem).CursoID,
                 Fecha = dtpFechaN.SelectedDate.Value
            };
            if (bl.agregarMatricula(a))
            {
                Refrescar();
                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Matricula a = (Matricula)dtgDatos.SelectedItem;
            if (bl.eliminarMatricula(a))
            {
                Refrescar();
                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void CargarInfoActulizar()
        {
            Matricula a = (Matricula)dtgDatos.SelectedItem;
            int p;
            foreach(var aux in lbxAlumno.Items)
            {
                if ((aux as Alumno).ID == a.FK_AlumnoID)
                {
                    p = lbxAlumno.Items.IndexOf(aux);
                    lbxAlumno.SelectedItem = lbxAlumno.Items[p];
                    break;

                }
            }

            foreach (var aux in lbxCurso.Items)
            {
                if ((aux as Curso).CursoID == a.FK_CursoID)
                {
                    p = lbxCurso.Items.IndexOf(aux);
                    lbxCurso.SelectedItem = lbxCurso.Items[p];
                    break;

                }
            }
            dtpFechaN.SelectedDate = a.Fecha;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Matricula a = (Matricula)dtgDatos.SelectedItem;
            a.FK_AlumnoID = ((Alumno)lbxAlumno.SelectedItem).ID;
            a.FK_CursoID= ((Curso)lbxCurso.SelectedItem).CursoID;
            a.Fecha = dtpFechaN.SelectedDate.Value;

            if (bl.actualizarMatricula(a))
            {
                Refrescar();

                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dtgDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CargarInfoActulizar();
            }
            catch
            {

            }
        }
    }
}
