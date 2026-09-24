namespace SistemaONG.Modelos
{
    public class Donacion
    {
        public int IdDonacion { get; set; }
        public Donante Donante { get; set; }

        public double Monto { get; set; }

        public string? Bien { get; set; }

        public string TipoDonacion { get; set; } = "";

        public DateTime Fecha { get; set; }

       
        public string? MetodoPago { get; set; }

        public int IdProyecto { get; set; }

        //TODO: 1 Constructor
        public Donacion(Donante donante, double monto)
        {
            Donante = donante;
            Monto = monto;
            TipoDonacion = "Efectivo";
            Bien = null;
            Fecha = DateTime.Now;

            donante.TotalDonado += monto;
        }

        //TODO: 2 Constructor
        public Donacion(Donante donante, string bien)
        {
            Donante = donante;
            Bien = bien;
            TipoDonacion = "Especie";
            Monto = 0;
            Fecha = DateTime.Now;
        }

        //TODO: 1 Metodo normal
        public string RegistrarDonacion()
        {
}