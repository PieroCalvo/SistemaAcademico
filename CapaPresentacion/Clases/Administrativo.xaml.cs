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
    /// Lógica de interacción para Administrativo.xaml
    /// </summary>
    public partial class Administrativo : Window
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        static ClaseNegocio.Administrativo administrativo = new ClaseNegocio.Administrativo();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            if (cboLugarNac.SelectedIndex >= 1)
            {
                administrativo.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta", "Agregar ciudad");
            administrativo.Experiencia = txtExperiencia.Text.Trim();
            if (cboFacultad.SelectedIndex >= 1)
            {
                administrativo.Facultad = cboFacultad.Text;
            }
            else MessageBox.Show("Seleccione una facultad correcta", "Agregar facultad");
            if (cboLabor.SelectedIndex >= 1)
            {
                administrativo.Labor = cboLabor.Text;
            }
            else MessageBox.Show("Seleccione una labor correcto", "Agregar labor");
            MessageBox.Show("Los datos del objeto administrativo fueron registrados correctamente", "Agregar docente");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + administrativo.Apellidos + "\nNombres: " + administrativo.Nombres +
                            "\nCodigo: " + administrativo.Codigo + "\nCorreo: " + administrativo.Correo + "\nDomicilio: " + administrativo.Domicilio +
                            "\nFecha de Nacimiento: " + administrativo.FechaNac + "\nLugar de Nacimiento: " + administrativo.LugarNac +
                            "\nExperiencia: " + administrativo.Experiencia + "\nFacultad: " + administrativo.Facultad + "\nLabor: " + administrativo.Labor, "Registro");
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir(), "Asisitir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Existir(), "Existir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
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
