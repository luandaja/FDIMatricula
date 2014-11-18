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

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MAlumnos_Click(object sender, RoutedEventArgs e)
        {
            PAlumnos pa = new PAlumnos();
            this.NavigationService.Navigate(pa);
        }

        private void MCuros_Click(object sender, RoutedEventArgs e)
        {
            PCursos pa = new PCursos();
            this.NavigationService.Navigate(pa);
        }

        private void MMatricula_Click(object sender, RoutedEventArgs e)
        {
            PMatricula pa = new PMatricula();
            this.NavigationService.Navigate(pa);
        }
    }
}
