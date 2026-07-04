namespace SistemaONG.Modelos
{
    public class Certificado
    {
        public int IdCertificado { get; set; }
        public Donacion Donacion { get; set; }
        public Donante Donante { get; set; }
        public DateTime FechaEmision { get; set; }
        public string CodigoCertificado { get; set; }
        public string Descripcion { get; set; }

      
        public Certificado(Donacion donacion)
        {
            Donacion = donacion;
            Donante = donacion.Donante;
            FechaEmision = DateTime.Now;
            CodigoCertificado = GenerarCodigo();
            Descripcion = $"Certificado de donación emitido a {Donante.Nombre}";
        }

       
        private string GenerarCodigo()
        {
            return $"CERT-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 6).ToUpper()}";
        }

       // TODO: 3 Metodo normal
        public string GenerarCertificado()
        {
            return $"====== CERTIFICADO DE DONACIÓN ======\n" +
                   $"Código     : {CodigoCertificado}\n" +
                   $"Donante    : {Donante.Nombre}\n" +
                   $"Cédula     : {Donante.Cedula}\n" +
                   $"Tipo       : {Donacion.TipoDonacion}\n" +
                   $"Monto/Bien : {(Donacion.TipoDonacion == "Efectivo" ? $"RD${Donacion.Monto:N2}" : Donacion.Bien)}\n" +
                   $"Fecha      : {FechaEmision:dd/MM/yyyy}\n" +
                   $"=====================================";
        }

        public override string ToString()
        {
            return $"{CodigoCertificado} - {Donante.Nombre}";
        }
    }
}