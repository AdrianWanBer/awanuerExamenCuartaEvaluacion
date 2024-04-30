namespace awanuerExamenCuartaEvaluacion.Dtos
{
    /// <summary>
    /// Clase dto que se encargara de los datos de las citas
    /// </summary>
    internal class CitasDtos
    {
        public string dni = "99999";
        public string nombre = "aaaaa";
        public string apellidos = "aaaaa";
        public string tipoCita = "aaaaa";
        public DateTime fechaConsulta;
        public string asistido = "aaaaa";

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string TipoCita { get => tipoCita; set => tipoCita = value; }
        public string Asistido { get => asistido; set => asistido = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
    }
}
