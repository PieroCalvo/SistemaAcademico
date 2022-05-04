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
    /// Lógica de interacción para Alumno.xaml
    /// </summary>
    public partial class Alumno : Window
    {
        public Alumno()
        {
            InitializeComponent();
        }

        // Declarar un objeto
        static ClaseNegocio.Alumno alumno = new ClaseNegocio.Alumno();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            if (cboLugarNac.SelectedIndex >= 1)
            {
                alumno.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta","Agregar ciudad");
            if (cboEscuela.SelectedIndex >= 1)
            {
                alumno.Escuela = cboEscuela.Text;
            }
            else MessageBox.Show("Seleccione una escuela correcta", "Agregar escuela");
            if (cboSeguro.SelectedIndex >= 0)
            {
                alumno.Seguro = Convert.ToBoolean(cboSeguro.Text);
            }
            else MessageBox.Show("Seleccione una opcion valida", "Confirmar seguro");
            MessageBox.Show("Los datos del objeto alumno fueron registrados correctamente","Agregar alumno");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + alumno.Apellidos+"\nNombres: "+alumno.Nombres+
                            "\nCodigo: "+alumno.Codigo+"\nCorreo: "+alumno.Correo+"\nDomicilio: "+alumno.Domicilio+
                            "\nFecha de Nacimiento: "+alumno.FechaNac+"\nLugar de Nacimiento: "+alumno.LugarNac+
                            "\nEscuela profesional: "+alumno.Escuela+"\nSeguro: "+alumno.Seguro,"Registro");
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir(),"Asisitir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Existir(), "Existir", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo actualizar esta en proceso de implementación","Actualizar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
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
