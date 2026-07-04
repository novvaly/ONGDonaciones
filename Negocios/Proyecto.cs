namespace SistemaONG.Modelos
{
    // Cada proyecto puede tener beneficiarios y donaciones asociadas
    public class Proyecto
    {
        // Propiedades del proyecto.
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; }

        public List<Beneficiario> Beneficiarios { get; set; }
        public List<Donacion> Donaciones { get; set; }

        
        public Proyecto(string nombre, string tipo, DateTime fechaInicio, string descripcion = "")
        {
            NombreProyecto = nombre;
            TipoProyecto = tipo;
            FechaInicio = fechaInicio;
            Descripcion = descripcion;

            // Todo proyecto inicia como activo
            Estado = "Activo";

            // Inicializa las listas vacías
            Beneficiarios = new List<Beneficiario>();
            Donaciones = new List<Donacion>();
        }

      


        // Devuelve un resumen con la información principal del proyecto.
        public string ObtenerResumen()
        {
            return $"Proyecto: {NombreProyecto} | Tipo: {TipoProyecto} | " +
                   $"Beneficiarios: {Beneficiarios.Count} | Estado: {Estado}";
        }

        // Sobrescribe ToString() para mostrar el nombre y el tipo del proyecto
        // cuando el objeto sea convertido a texto.
        public override string ToString()
        {
            return $"{NombreProyecto} ({TipoProyecto})";
        }
    }
}