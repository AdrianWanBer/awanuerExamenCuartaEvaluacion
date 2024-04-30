using awanuerExamenCuartaEvaluacion.Dtos;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de contener todas las implementaciones relacionadas con los ficheros
    /// awb
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo que leera el fiechero que contendra los datos para las listas
        /// awb
        /// </summary>
        public void leerFicheroCitas(List<CitasDtos> listaCitas);
    }
}
