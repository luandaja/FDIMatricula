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
using BL;

namespace UI
{
    /// <summary>
    /// Lógica de interacción para PCursos.xaml
    /// </summary>
    public partial class PCursos : Page
    {
        BL_Curso bl = new BL_Curso();
        public PCursos()
        {
            InitializeComponent();
            Refrescar();
        }

        void Refrescar()
        {
            dtgDatos.ItemsSource = null;
            dtgDatos.ItemsSource = bl.mostrarCursos() ;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aux = 2;
            Curso a = new Curso
            {
                Nombre = txtNombre.Text.Trim(),
                Creditos = int.TryParse(txtCreditos.Text.Trim(), out aux)==true?aux:2
            };
            aux = a.Creditos;
            if (bl.agregarCurso(a))
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
            Curso a = (Curso)dtgDatos.SelectedItem;
            if (bl.eliminarCurso(a))
            {
                Refrescar();

                MessageBox.Show("Éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void CargarInfoCursoActulizar()
        {
            Curso a = (Curso)dtgDatos.SelectedItem;
            txtNombre.Text = a.Nombre;
            txtCreditos.Text = a.Creditos.ToString();

        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Curso a = (Curso)dtgDatos.SelectedItem;
            int aux;
            a.Nombre = txtNombre.Text.Trim();
            a.Creditos = int.TryParse(txtCreditos.Text.Trim(), out aux) == true ? aux : aux;

            if (bl.actualizarCurso(a))
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
                CargarInfoCursoActulizar();
            }
            catch
            {

            }
        }
    }
}
