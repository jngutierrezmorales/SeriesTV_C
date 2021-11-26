using SeriesTV.dto;
using SeriesTV.logica;
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

// Ventana accesible una vez se hace login en la aplicacion, muestra la lista de series que sigue 
// el usuario, permite agregar o modificar una existente y un boton para descubrir nuevas series

namespace SeriesTV
{
    /// <summary>
    /// Interaction logic for ListaSeries.xaml
    /// </summary>
    public partial class ListaSeries : Window
    {
        private LogicaNegocio logicaNegocio;

        // CONSTRUCTOR
        public ListaSeries()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            DataGridSeries.DataContext = logicaNegocio;
        }

        // MENU ITEM para acceder a la ventana DialogoSerie
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DialogoSerie dialogoSerie = new DialogoSerie(logicaNegocio);
            dialogoSerie.Show();
        }

        // BUTTON Modificar, selecciona una serie del grid y pulsar boton para modificar
        // Metodo Clone() de la clase serie permite clonar el objeto serie para modificar valor al pulsar Aceptar
        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridSeries.SelectedIndex != 1)
            {
                Serie serie = (Serie)DataGridSeries.SelectedItem;
                DialogoSerie dialogoSerie = new DialogoSerie(logicaNegocio, (Serie)serie.Clone(), DataGridSeries.SelectedIndex);
                dialogoSerie.Show();
            }
            
        }

        // BUTTON Descubrir para acceder a DialogoDescubrir
        private void ButtonDescubrir_Click(object sender, RoutedEventArgs e)
        {
            DialogoDescubrir dialogoDescubrir = new DialogoDescubrir();
            dialogoDescubrir.Show();
        }
    }
}
