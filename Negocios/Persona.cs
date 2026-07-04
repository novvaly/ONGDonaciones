namespace SistemaONG.Modelos
{

    // TODO: Clase abstrasta 
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string cedula, string telefono)
        {
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
        }

        // TODO: metodo abastracto (obliga a las clases hijas a decir cual es su rol)
        public abstract string ObtenerRol();


        // TODO: metodo virtual (puede modificarse en las clases hijas)
        // mide la importancia o el efecto que tiene una entidad dentro de la ONG
        public virtual double CalcularImpacto() 
        {
            return 0;                           
        }

       
    }
}