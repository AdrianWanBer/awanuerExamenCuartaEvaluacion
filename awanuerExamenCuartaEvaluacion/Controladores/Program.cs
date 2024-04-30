﻿using awanuerExamenCuartaEvaluacion.Dtos;
using awanuerExamenCuartaEvaluacion.Servicios;

namespace awanuerExamenCuartaEvaluacion.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {

            List<CitasDtos> listaCitas = new List<CitasDtos>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            fi.ficheroLog("Se abre la aplicación");


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
                        fi.añadirDatosLog("Se cierra la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1: //Registro de llegada
                        fi.añadirDatosLog("Se abre Registo de llegada");
                        oi.registroDeLLegada(listaCitas);
                        break;
                    case 2: //Listado de consultas
                        fi.añadirDatosLog("Se abre Listado de consultas");
                        int seleccionConsultas = mi.menuConsultas();
                        switch (seleccionConsultas)
                        {
                            case 0: //Volver
                                break;
                            case 1:
                                oi.mostrarConsulta(listaCitas);
                                break;
                            case 2:
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