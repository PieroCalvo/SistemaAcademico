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
using System.Windows.Shapes;

namespace CapaPresentacion.Clases
{
    /// <summary>
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }

        static ClaseNegocio.Docente docente = new ClaseNegocio.Docente();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            if (cboLugarNac.SelectedIndex >= 1)
            {
                docente.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta", "Agregar ciudad");
            if (cboFacultad.SelectedIndex >= 1)
            {
                docente.Facultad = cboFacultad.Text;
            }
            else MessageBox.Show("Seleccione una facultad correcta", "Agregar facultad");
            if (cboGrado.SelectedIndex >= 1)
            {
                docente.Grado = cboGrado.Text;
            }
            else MessageBox.Show("Seleccione un grado académico correcto", "Agregar grado académico");
            MessageBox.Show("Los datos del objeto docente fueron registrados correctamente", "Agregar docente");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + docente.Apellidos + "\nNombres: " + docente.Nombres +
                            "\nCodigo: " + docente.Codigo + "\nCorreo: " + docente.Correo + "\nDomicilio: " + docente.Domicilio +
                            "\nFecha de Nacimiento: " + docente.FechaNac + "\nLugar de Nacimiento: " + docente.LugarNac +
                            "\nFacultad: " + docente.Facultad + "\nGrado académico: " + docente.Grado, "Registro");
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir(), "Asisitir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Existir(), "Existir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo actualizar esta en proceso de implementación", "Actualizar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo agregar esta en proceso de implementación", "Agregar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo buscar esta en proceso de implementación", "Buscar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo eliminar esta en proceso de implementación", "Eliminar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo listar esta en proceso de implementación", "Listar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
