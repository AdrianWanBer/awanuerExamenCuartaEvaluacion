using awanuerExamenCuartaEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos relacionados con las operativas
    /// awb
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// metodo encargado de revisar los registros de llegada y todo lo englobado a ello
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void registroDeLLegada(List<CitasDtos> listaCitas);

        /// <summary>
        /// Metodo que se encarga de las opciones al seleccionar mostrar consulta
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void mostrarConsulta(List<CitasDtos> listaCitas);

        /// <summary>
        /// metodo encargado de imprimir las consultas en un fichero
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void imprimirConsultas(List<CitasDtos> listaCitas);
    }
}
