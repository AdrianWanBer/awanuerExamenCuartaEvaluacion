using awanuerExamenCuartaEvaluacion.Dtos;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion que contendra todos los metodos que tenga que ver con los ficheros
    /// awb
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        /// <summary>
        /// Metodo que creara el fichero log
        /// awb
        /// </summary>
        public void ficheroLogCreacion()
        {
            DateTime ahora = DateTime.Now;
            StreamWriter swlog = new StreamWriter($"log-{ahora.ToString("ddMMyyyy")}.txt");
        }

        /// <summary>
        /// Metodo que leera el fichero de las citas
        /// awb
        /// </summary>
        public void leerFicheroCitas(List<CitasDtos> listaCitas)
        {
            try
            {
                DateTime ahora = DateTime.Now;
                StreamReader lector = new StreamReader("C:\\Users\\Adrian\\source\\repos\\awanuerExamenCuartaEvaluacion\\awanuerExamenCuartaEvaluacion\\citas.txt");
                string todo = lector.ReadToEnd();

                string[] celdas = lector.ReadToEnd().Split(" ");

                //PRUEBA ---> Console.WriteLine(celdas[0]);

                for (int i = 0; i < celdas.Length - 1; i++)
                {
                    Console.Write(celdas[i]);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
