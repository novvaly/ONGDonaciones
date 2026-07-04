namespace SistemaONG.Modelos
{
    // La clase Beneficiario hereda de Persona y representa
    // a las personas que reciben ayuda de la ONG
    public class Beneficiario : Persona
    {
        // Propiedades específicas del beneficiario
        public string Direccion { get; set; } = "";
        public int IdProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public int CantidadBeneficios { get; set; }
        public DateTime FechaAsignacion { get; set; }

        // Constructor 
       
        public Beneficiario(
            string nombre,
            string cedula,
            string telefono,
            string direccion,
            int idProyecto,
            string tipoProyecto,
            string nombreProyecto)
            : base(nombre, cedula, telefono)
        {
            Direccion = direccion;
            IdProyecto = idProyecto;
            TipoProyecto = tipoProyecto;
            NombreProyecto = nombreProyecto;

            // El beneficiario inicia sin beneficios registrados
            CantidadBeneficios = 0;

            // Registra automáticamente la fecha de asignación
            FechaAsignacion = DateTime.Now;
        }

        // TODO: Sobrescribe método abstracto ObtenerRol()
        // para identificar que esta persona es un beneficiario
        public override string ObtenerRol()
        {
            return "Beneficiario";
        }

        // TODO: Sobrescribe método CalcularImpacto()
        // Calcula el impacto del beneficiario según el tipo de proyecto

        public override double CalcularImpacto()
        {
            switch (TipoProyecto.ToLower())
            {
                case "educacion":
                    return CantidadBeneficios * 10;

                case "salud":
                    return CantidadBeneficios * 15;

                case "alimentacion":
                    return CantidadBeneficios * 8;

                case "vivienda":
                    return CantidadBeneficios * 20;

                default:
                    return CantidadBeneficios * 5;
            }
        }

        //TODO: 2 Metodo normal
        public string AsignarBeneficiario()
        {
            CantidadBeneficios++;

            return $"{Nombre} asignado al proyecto {NombreProyecto}";
        }
    }
}