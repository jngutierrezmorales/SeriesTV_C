using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

// Clase objeto Serie que establece los atributos y constructores

namespace SeriesTV.dto
{
    public class Serie : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        // PROPIEDADES Y METODOS
        // NOMBRE
        private String nombre;
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        // SINOPSIS
        private String sinopsis;
        public String Sinopsis
        {
            get
            {
                return sinopsis;
            }
            set
            {
                sinopsis = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Sinopsis"));
            }
        }

        // FECHA ESTRENO
        private DateTime fechaEstreno;
        public DateTime FechaEstreno
        {
            get
            {
                return fechaEstreno;
            }
            set
            {
                fechaEstreno = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEstreno"));
            }
        }

        // VALIDACION METODOS
        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(nombre))
                        result = "Debes introducir el nombre";
                }
                if (columnName == "Sinopsis")
                {
                    if (string.IsNullOrEmpty(sinopsis))
                        result = "Debes introducir la sinopsis";
                }
                return result;
            }
        }

        // CONSTRUCTORES
        public Serie(String nombre, String sinopsis, DateTime fechaEstreno)
        {
            this.nombre = nombre;
            this.sinopsis = sinopsis;
            this.fechaEstreno = fechaEstreno;
        }

        public Serie()
        {
            this.fechaEstreno = DateTime.Now;
        }
        
        // NOTIFICAR CAMBIO EN PROPIEDAD
        public event PropertyChangedEventHandler PropertyChanged;

        // METODO PARA CLONAR OBJETO SERIE
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
