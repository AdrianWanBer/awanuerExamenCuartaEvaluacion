using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz que contendra los metodos que tengan que ver con menus
    /// awb
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que mostrara el menu principal
        /// awb
        /// </summary>
        /// <returns>int</returns>
        public int menuPrincipal();

        /// <summary>
        /// Metodo que mostrara el menu de las consultas
        /// awb
        /// </summary>
        /// <returns>int</returns>
        public int menuConsultas();

        /// <summary>
        /// Metodo que mostrara el submenu con los distintos tipos de consultas
        /// awb
        /// </summary>
        /// <returns>int</returns>
        public int subMenuConsultas();
    }
}
