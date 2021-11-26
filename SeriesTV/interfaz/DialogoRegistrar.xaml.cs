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

// Se accede desde el button Registrar de la ventana MainWindow
// Permite registrar un nuevo usuario

namespace SeriesTV
{
    /// <summary>
    /// Interaction logic for DialogoRegistrar.xaml
    /// </summary>
    public partial class DialogoRegistrar : Window
    {
        public DialogoRegistrar()
        {
            InitializeComponent();
        }

        // BUTTON CANCELAR
        private void ButtonCancelarRegistrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // BUTTON ACEPTAR
        private void ButtonAceptarRegistrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
