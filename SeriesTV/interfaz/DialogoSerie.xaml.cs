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

// Ventana accesible desde el menu Opciones, menu item Agregar del dialogo ListaSeries
// Permite agregar una nueva serie a la lista

namespace SeriesTV
{
    /// <summary>
    /// Interaction logic for DialogoSerie.xaml
    /// </summary>
    public partial class DialogoSerie : Window
    {
        // ATRIBUTOS
        private LogicaNegocio logicaNegocio;
        public Serie serie;
        private int posicion;
        private Boolean modificar;
        private int errores;

        // CONSTRUCTOR, aplica logica de negocio establecida en clase LogicaNegocio
        public DialogoSerie(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            serie = new Serie();
            this.DataContext = serie;
            modificar = false;
        }

        // CONSTRUCTOR, recibe serie a modificar con la posicion que ocupa en la lista de series
        public DialogoSerie(LogicaNegocio logicaNegocio, Serie serieModificar, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.serie = serieModificar;
            this.posicion = posicion;
            this.DataContext = serie;
            modificar = true;
        }

        // BUTTON Cancelar
        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cerrar ventana
        }


        // BUTTON Aceptar
        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar) // MODIFICAR
                logicaNegocio.modificarSerie(serie, posicion);
            else // AGREGAR
                logicaNegocio.agregarSerie(serie);

            this.Close();
        }

        // Metodo para validar campos y habilitar el button Aceptar si es correcto
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                ButtonAceptar.IsEnabled = true;
            else
                ButtonAceptar.IsEnabled = false;
        }
    }
}
