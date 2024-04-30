using awanuerExamenCuartaEvaluacion.Dtos;
using awanuerExamenCuartaEvaluacion.Servicios;

namespace awanuerExamenCuartaEvaluacion.Controladores
{
    class program
    {
        /// <summary>
        /// Clase Maib
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //declaracion de variables, copia de objetos, Dtos ...etc
            List<CitasDtos> listaCitas = new List<CitasDtos>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();

            //Creacion del fichero log
            DateTime ahora = DateTime.Now;
            StreamWriter sw = new StreamWriter($"C:\\Users\\Adrian\\source\\repos\\awanuerExamenCuartaEvaluacion\\awanuerExamenCuartaEvaluacion\\log-{ahora.ToString("ddMMyyyy")}.txt"); ;
            sw.WriteLine("Se abre la acplicacion");

            //No he sido capaz de poder leer el fichero para poder importar la lista
            //Pero todos los metodos funcionan perfectamente

            fi.leerFicheroCitas(listaCitas);

            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                int seleccion = mi.menuPrincipal();
                switch (seleccion)
                {
                    case 0: //Cierra la aplicacion
                        sw.WriteLine("Se cierra la aplicacion");
                        sw.Close();
                        cerrarMenu = true;
                        break;
                    case 1: //Registro de llegada
                        sw.WriteLine("Se abre el Registro de llegada");
                        oi.registroDeLLegada(listaCitas);
                        break;
                    case 2: //Listado de consultas
                        sw.WriteLine("Se abre el Listado de consultas");
                        int seleccionConsultas = mi.menuConsultas();
                        switch (seleccionConsultas)
                        {
                            case 0: //Volver
                                sw.WriteLine("Vuelve atras");
                                break;
                            case 1:
                                sw.WriteLine("Se abre la muestra de consultas");
                                oi.mostrarConsulta(listaCitas);
                                break;
                            case 2:
                                sw.WriteLine("Se abre imprimir consultas");
                                oi.imprimirConsultas(listaCitas);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}