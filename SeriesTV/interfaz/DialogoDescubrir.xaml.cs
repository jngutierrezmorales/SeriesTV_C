using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Se accede desde el button Descubrir de la ventana ListaSeries
// El objetivo de esta ventana es mostrar al usuario nuevas series que le puedan interesar

// Para mostrar las imagenes a la hora de ejecutar hay que seleccionar todas desde el Solution Explorer, 
// click derecho Properties y establecer la propiedad "Build Action" como "Resource"

namespace SeriesTV
{
    /// <summary>
    /// Interaction logic for DialogoDescubrir.xaml
    /// </summary>
    public partial class DialogoDescubrir : Window
    {
        public DialogoDescubrir()
        {
            InitializeComponent();
        }

        // BUTTON ACEPTAR
        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // BUTTON CANCELAR
        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
