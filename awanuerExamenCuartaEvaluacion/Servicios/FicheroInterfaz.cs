using awanuerExamenCuartaEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de contener todas las implementaciones relacionadas con los ficheros
    /// awb
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo que creara el fichero log
        /// awb
        /// </summary>
        public void ficheroLogCreacion();
       
        /// <summary>
        /// Metodo que leera el fiechero que contendra los datos para las listas
        /// awb
        /// </summary>
        public void leerFicheroCitas(List<CitasDtos> listaCitas);
    }
}
