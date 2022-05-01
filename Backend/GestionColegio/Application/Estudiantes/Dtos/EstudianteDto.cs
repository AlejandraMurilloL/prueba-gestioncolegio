namespace GestionColegio.Application.Estudiantes.Dtos
{
    public class EstudianteDto
    {
        public int? Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
