using SeriesTV.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

// Clase con la logica de negocio del proyecto

namespace SeriesTV.logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<Serie> listaSeries { get; set; }

        // CONSTRUCTOR
        public LogicaNegocio()
        {
            listaSeries = new ObservableCollection<Serie>();
            // Serie añadida automaticamente con la hora actual al iniciar el programa
            listaSeries.Add(new Serie("El Juego Del Calamar", "Supervivencia", DateTime.Now));
        }

        // Metodo para agregar una serie
        public void agregarSerie(Serie serie)
        {
            listaSeries.Add(serie);
        }

        // Metodo para modificar los datos de una serie, recibe la serie y posicion que ocupa en el 
        // DataGrid de la ventana ListaSeries
        public void modificarSerie(Serie serie, int posicion)
        {
            listaSeries[posicion] = serie;
        }
    }
}
