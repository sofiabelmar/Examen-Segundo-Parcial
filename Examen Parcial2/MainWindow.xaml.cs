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

namespace Examen_Parcial2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (controlPersona.txtNombre.Text == "" || controlPersona.txtAp.Text=="")
            {

                    validacion.Text = "Es necesario llenar todos los campos";
                
             
            }
            else
            {
                if (controlPersona.txtAm.Text == "" || controlPersona.txtEdad.Text == "")
                {
                    validacion.Text = "Es necesario llenar todos los campos";
                }
                else
                {
                    controlPersona.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                    validacion.Text = ":)";
                    btnSiguiente.Visibility = Visibility.Collapsed;
                    btnSiguiente2.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnSiguiente2_Click(object sender, RoutedEventArgs e)
        {
            if(controlContacto.txtCorreo.Text==""|| controlContacto.txtTelefono.Text=="")
            {
                
                    validacion.Text = "Es necesesario llenar todos los datos";
               
            }
            else
            {
                if (controlContacto.txtCelular.Text == "")
                {
                    validacion.Text = "Es necesesario llenar todos los datos";
                }
                else { 
                controlContacto.Visibility = Visibility.Collapsed;
                controlPago.Visibility = Visibility.Visible;
                validacion.Text = ":)";
                btnSiguiente2.Visibility = Visibility.Collapsed;
                btnFinalizar.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            if (controlPago.txtNumeroTarjeta.Text.Length != 16)
            {
                validacion.Text = "Es necesario que el numero de targeta sea de 16 digitos";
            }
            else
            {
                validacion.Text = ":)";
            }
        }
    }
}
