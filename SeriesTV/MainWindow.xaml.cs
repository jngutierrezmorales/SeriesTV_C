using SeriesTV.logica;
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

// Ventana principal del proyecto, permite hacer login o registrar un nuevo usuario
// Login accede a la ventana ListaSeries

namespace SeriesTV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
        }

        // BUTTON Login
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            ListaSeries listaSeries = new ListaSeries();
            listaSeries.Show();
        }

        // BUTTON Registrar
        private void ButtonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            DialogoRegistrar dialogoRegistrar = new DialogoRegistrar();
            dialogoRegistrar.Show();
        }

        /*private void DataGridSeries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }*/
    }
}
