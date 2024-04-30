using awanuerExamenCuartaEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion que contiene todos los metodos relacionados con las operativas
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        MenuInterfaz mi = new MenuImplementacion();
        /// <summary>
        /// Metodo de la operativa que se encarga de ver el registro de llegada y revisar si un dni (valido)
        /// tiene alguna cita
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void registroDeLLegada(List<CitasDtos> listaCitas)
        {
            
            try
            {


                bool dniValidado = false;
                while (!dniValidado)
                {
                    DateTime hoy = DateTime.Now;
                    Console.WriteLine("¿Cual es su DNI? (numeros)");
                    int dniNumeros = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Cual es su DNI? (letra mayuscula)");
                    string dniLetra = Console.ReadLine();

                    //Validacion de dni
                    string[] letras = { "T", "R", "W", "A", "G", "M", "Y"
                    , "F", "P", "D", "X", "B", "N", "J", "Z", "S"
                    , "Q", "V", "H", "L", "C", "K", "E" };
                    int num = dniNumeros % 23;

                    if (letras[num] == dniLetra.ToUpper())
                    {
                        dniValidado = true;
                        string dniCompleto = $"{dniNumeros}{dniLetra}";
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.Dni == dniCompleto)
                            {
                                foreach (CitasDtos citaUsuario in listaCitas)
                                {

                                    if (hoy.ToString("dd-MM-yyyy") == citaUsuario.FechaConsulta.ToString("dd-MM-yyyy"))
                                    {
                                        Console.WriteLine($"Espere su turno para la consulta de {cita.TipoCita} en la sala de espera. Su especialista le avisará");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No dispone de cita previa hoy");
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                
            }
        }

        /// <summary>
        /// Metodo que realizara la operativa relacionada con mostrar consulta
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void mostrarConsulta(List<CitasDtos> listaCitas)
        {
            try
            {
                int seleccion = mi.subMenuConsultas();
                switch (seleccion)
                {
                    case 0: //Volver
                        break;
                    case 1: // Psicología
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha.ToString("dd-MM-yyyy")
                                && cita.TipoCita.Equals("Psicología"))
                            {
                                Console.WriteLine(cita.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                            }
                        }
                        break;
                    case 2: //Traumatología
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha2 = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha2.ToString("dd-MM-yyyy")
                                && cita.TipoCita.Equals("Traumatología"))
                            {
                                Console.WriteLine(cita.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                            }
                        }
                        break;
                    case 3: //Fisioterapia
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha3 = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha3.ToString("dd-MM-yyyy")
                                && cita.TipoCita.Equals("Fisioterapia"))
                            {
                                Console.WriteLine(cita.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                            }
                        }
                        break;
                    default:
                        break;
                }
            }catch(Exception e)
            {

            }
        }

        /// <summary>
        /// Metodo que escribira en un fichero todas las consultas del dia especificado
        /// awb
        /// </summary>
        /// <param name="listaCitas"></param>
        public void imprimirConsultas(List<CitasDtos> listaCitas)
        {
            try
            {

                int seleccion = mi.subMenuConsultas();
                switch (seleccion)
                {
                    case 0: //Volver
                        break;
                    case 1: //Psicologia
                        DateTime ahora = DateTime.Now;
                        StreamWriter sw = new StreamWriter($"C:\\Users\\Adrian\\source\\repos\\awanuerExamenCuartaEvaluacion\\awanuerExamenCuartaEvaluacion\\citasConAsistencia-{ahora.ToString("ddMMyyyy")}.txt");
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha.ToString("dd-MM-yyyy")
                                            && cita.TipoCita.Equals("Psicología") && cita.asistido.Equals("True"))
                            {
                                sw.WriteLine(string.Concat("Nombre Completo: ", cita.nombre, " ", cita.apellidos,
                                    ", Hora: ", cita.fechaConsulta.ToString("hh:mm")));
                            }
                        }
                        break;
                    case 2: //Traumatología
                        DateTime ahora2 = DateTime.Now;
                        StreamWriter sw2 = new StreamWriter($"C:\\Users\\Adrian\\source\\repos\\awanuerExamenCuartaEvaluacion\\awanuerExamenCuartaEvaluacion\\citasConAsistencia-{ahora2.ToString("ddMMyyyy")}.txt");
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha2 = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha2.ToString("dd-MM-yyyy")
                                            && cita.TipoCita.Equals("Traumatología") && cita.asistido.Equals("True"))
                            {
                                sw2.WriteLine(string.Concat("Nombre Completo: ", cita.nombre, " ", cita.apellidos,
                                    ", Hora: ", cita.fechaConsulta.ToString("hh:mm")));
                            }
                        }
                        break;
                    case 3: //Fisioterapia
                        DateTime ahora3 = DateTime.Now;
                        StreamWriter sw3 = new StreamWriter($"C:\\Users\\Adrian\\source\\repos\\awanuerExamenCuartaEvaluacion\\awanuerExamenCuartaEvaluacion\\citasConAsistencia-{ahora3.ToString("ddMMyyyy")}.txt");
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        DateTime fecha3 = DateTime.Parse(Console.ReadLine());
                        foreach (CitasDtos cita in listaCitas)
                        {
                            if (cita.FechaConsulta.ToString("dd-MM-yyyy") == fecha3.ToString("dd-MM-yyyy")
                                            && cita.TipoCita.Equals("Fisioterapia") && cita.asistido.Equals("True"))
                            {
                                sw3.WriteLine(string.Concat("Nombre Completo: ", cita.nombre, " ", cita.apellidos,
                                    ", Hora: ", cita.fechaConsulta.ToString("hh:mm")));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            
        }
    }
}