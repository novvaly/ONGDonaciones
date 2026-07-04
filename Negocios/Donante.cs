namespace SistemaONG.Modelos
{
    // La clase Donante hereda de la clase abstracta Persona
    public class Donante : Persona
    {
        // Propiedades específicas del donante
        public string Email { get; set; }
        public string Direccion { get; set; }
        public double TotalDonado { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Constructor que inicializa los datos del donante
        // son enviados al constructor de la clase Persona
        public Donante(
            string nombre,
            string cedula,
            string telefono,
            string email,
            string direccion,
            DateTime fechaRegistro)
            : base(nombre, cedula, telefono)
        {
            Email = email;
            Direccion = direccion;
            FechaRegistro = fechaRegistro;

            // Al registrarse, el donante aún no ha realizado donaciones.
            TotalDonado = 0;
        }

        // Sobrescribe el método abstracto ObtenerRol()
        // para indicar que esta persona es un Donante.
        public override string ObtenerRol()
        {
            return "Donante";
        }
    }
}