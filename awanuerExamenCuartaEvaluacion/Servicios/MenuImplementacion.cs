namespace awanuerExamenCuartaEvaluacion.Servicios
{
    /// <summary>
    /// MenuImplementacion contiene los metodos de los menus, que recogeran las selecciones
    /// awb
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Menu que se mostrara al abrir la aplicacion y redigira al usuario
        /// awb
        /// </summary>
        /// <returns>Int (seleccion)</returns>
        public int menuPrincipal()
        {
            try
            {
                int seleccion;
                Console.WriteLine("MENU");
                Console.WriteLine("0.Cerrar");
                Console.WriteLine("1.Registro de llegada");
                Console.WriteLine("2.Listado de consultas");
                seleccion = int.Parse(Console.ReadLine());
                return seleccion;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// Menu de consultas donde el usuario elegira que hacer
        /// Int (seleccion)
        /// </summary>
        /// <returns>Int (seleccion)</returns>
        public int menuConsultas()
        {
            try
            {
                int seleccion;
                Console.WriteLine("MENU CONSULTAS");
                Console.WriteLine("0.Volver");
                Console.WriteLine("1.Mostrar consultas");
                Console.WriteLine("2.Imprimir consultas");
                seleccion = int.Parse(Console.ReadLine());
                return seleccion;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        /// <summary>
        /// Submenu con las diferentes opciones de las consultas
        /// awb
        /// </summary>
        /// <returns>Int (seleccion)</returns>

        public int subMenuConsultas()
        {
            int seleccion;
            Console.WriteLine("SUBMENU CONSULTAS");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Psicologia");
            Console.WriteLine("2.Traumatología");
            Console.WriteLine("3.Fisioterapia");
            seleccion = int.Parse(Console.ReadLine());
            return seleccion;
        }
    }
}
