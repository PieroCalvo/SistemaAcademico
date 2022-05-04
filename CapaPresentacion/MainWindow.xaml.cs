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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Threading.Thread.Sleep(4000);
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Clases.Alumno frm = new Clases.Alumno();
            frm.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Clases.Docente frm = new Clases.Docente();
            frm.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Clases.Administrativo frm = new Clases.Administrativo();
            frm.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
