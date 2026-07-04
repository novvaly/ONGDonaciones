using AccesoDatos;
using Microsoft.Data.SqlClient;
using SistemaONG.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Negocios
{
    public class GestionONG
    {
        public void RegistrarDonante(Donante d)
        {
            string sql = @"INSERT INTO Donantes (Nombre, Cedula, Email, Telefono, Direccion, FechaRegistro)
                           VALUES (@Nombre, @Cedula, @Email, @Telefono, @Direccion, @Fecha)";

            SqlParameter[] parametros = {
                new SqlParameter("@Nombre", d.Nombre),
                new SqlParameter("@Cedula", d.Cedula ?? ""),
                new SqlParameter("@Email", d.Email ?? ""),
                new SqlParameter("@Telefono", d.Telefono ?? ""),
                new SqlParameter("@Direccion", d.Direccion ?? ""),
                new SqlParameter("@Fecha", d.FechaRegistro)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public void EliminarDonacion(int id)
        {
            string sql = "DELETE FROM Donaciones WHERE IdDonacion=@Id";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Id", id)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public void EditarDonante(int id, Donante d)
        {
            string sql = @"UPDATE Donantes
                   SET Nombre=@Nombre,
                       Cedula=@Cedula,
                       Email=@Email,
                       Telefono=@Telefono,
                       Direccion=@Direccion,
                       FechaRegistro=@Fecha
                   WHERE IdDonante=@Id";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Nombre", d.Nombre),
        new SqlParameter("@Cedula", d.Cedula),
        new SqlParameter("@Email", d.Email),
        new SqlParameter("@Telefono", d.Telefono),
        new SqlParameter("@Direccion", d.Direccion),
        new SqlParameter("@Fecha", d.FechaRegistro),
        new SqlParameter("@Id", id)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        
        public void EliminarDonante(int id)
        {    
            string sql = "DELETE FROM Donantes WHERE IdDonante=@Id";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Id", id)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public DataTable ObtenerDonantes()
        {
            return ConexionDB.EjecutarConsulta("SELECT * FROM Donantes");
        }

        public void RegistrarDonacion(Donacion donacion)
        {
            string sql = @"INSERT INTO Donaciones (IdDonante, IdProyecto, Monto, Fecha, MetodoPago)
                           VALUES (@IdDonante, @IdProyecto, @Monto, @Fecha, @MetodoPago)";

            SqlParameter[] parametros = {
                new SqlParameter("@IdDonante", donacion.Donante.Id),
                new SqlParameter("@IdProyecto", donacion.IdProyecto),
                new SqlParameter("@Monto", donacion.Monto),
                new SqlParameter("@Fecha", donacion.Fecha),
                new SqlParameter("@MetodoPago", donacion.TipoDonacion)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public void EditarDonacion(
    int idDonacion,
    int idDonante,
    int idProyecto,
    double monto,
    DateTime fecha,
    string metodoPago)
        {
            string sql = @"UPDATE Donaciones
                   SET IdDonante=@IdDonante,
                       IdProyecto=@IdProyecto,
                       Monto=@Monto,
                       Fecha=@Fecha,
                       MetodoPago=@MetodoPago
                   WHERE IdDonacion=@IdDonacion";

            SqlParameter[] parametros =
            {
        new SqlParameter("@IdDonacion", idDonacion),
        new SqlParameter("@IdDonante", idDonante),
        new SqlParameter("@IdProyecto", idProyecto),
        new SqlParameter("@Monto", monto),
        new SqlParameter("@Fecha", fecha),
        new SqlParameter("@MetodoPago", metodoPago)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public DataTable ObtenerDonaciones()
        {
            string sql = @"SELECT
                   d.IdDonacion,
                   d.IdDonante,
                   d.IdProyecto,
                   dn.Nombre AS Donante,
                   p.NombreProyecto AS Proyecto,
                   d.Monto,
                   d.Fecha,
                   d.MetodoPago
            FROM Donaciones d
            INNER JOIN Donantes dn ON d.IdDonante = dn.IdDonante
            INNER JOIN Proyectos p ON d.IdProyecto = p.IdProyecto";

            return ConexionDB.EjecutarConsulta(sql);
        }
        public DataTable ObtenerDonacionesPorProyecto(int idProyecto)
        {
            string sql = @"SELECT
                   d.IdDonacion,
                   d.IdDonante,
                   d.IdProyecto,
                   dn.Nombre AS Donante,
                   p.NombreProyecto AS Proyecto,
                   d.Monto,
                   d.Fecha,
                   d.MetodoPago
            FROM Donaciones d
            INNER JOIN Donantes dn ON d.IdDonante = dn.IdDonante
            INNER JOIN Proyectos p ON d.IdProyecto = p.IdProyecto
            WHERE d.IdProyecto = @IdProyecto";

            SqlParameter[] parametros =
            {
        new SqlParameter("@IdProyecto", idProyecto)
    };

            return ConexionDB.EjecutarConsulta(sql, parametros);
        }
        public DataTable ObtenerProyectos()
        {
            return ConexionDB.EjecutarConsulta("SELECT * FROM Proyectos");
        }

        public void AsignarBeneficiario(Beneficiario b)
        {
            string sql = @"INSERT INTO Beneficiarios
                  (Nombre, Cedula, Telefono, Direccion, IdProyecto)
                  VALUES
                  (@Nombre, @Cedula, @Telefono, @Direccion, @IdProyecto)";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Nombre", b.Nombre),
        new SqlParameter("@Cedula", b.Cedula ?? ""),
        new SqlParameter("@Telefono", b.Telefono ?? ""),
        new SqlParameter("@Direccion", b.Direccion ?? ""),
        new SqlParameter("@IdProyecto", b.IdProyecto)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        public DataTable ObtenerBeneficiarios()
        {
            string sql = @"SELECT b.IdBeneficiario,
                          b.Nombre,
                          b.Cedula,
                          b.Direccion,
                          b.Telefono,
                          p.NombreProyecto AS Proyecto
                   FROM Beneficiarios b
                   INNER JOIN Proyectos p
                        ON b.IdProyecto = p.IdProyecto";

            return ConexionDB.EjecutarConsulta(sql);
        }

        public void GenerarCertificado(Certificado c)
        {
            string sql = @"INSERT INTO Certificados (IdDonacion, IdDonante, FechaEmision, CodigoCertificado, Descripcion)
                           VALUES (@IdDonacion, @IdDonante, @Fecha, @Codigo, @Descripcion)";

            SqlParameter[] parametros = {
                new SqlParameter("@IdDonacion", c.Donacion.IdDonacion),
                new SqlParameter("@IdDonante", c.Donante.Id),
                new SqlParameter("@Fecha", c.FechaEmision),
                new SqlParameter("@Codigo", c.CodigoCertificado),
                new SqlParameter("@Descripcion", c.Descripcion)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }
        // TODO: Func para ranking de mayores donantes
        public List<string> ObtenerRankingDonantes()
        {
            Func<DataTable, List<string>> ranking = (tabla) =>
            {
                return tabla.AsEnumerable()
                    .OrderByDescending(r => r.Field<decimal>("TotalDonado"))
                    .Take(10)
                    .Select((r, i) => $"#{i + 1} {r["Nombre"]} - RD${r["TotalDonado"]:N2}")
                    .ToList();
            };

            string sql = @"SELECT d.Nombre, SUM(dn.Monto) AS TotalDonado
                           FROM Donantes d
                           INNER JOIN Donaciones dn ON d.IdDonante = dn.IdDonante
                           GROUP BY d.Nombre
                           ORDER BY TotalDonado DESC";

            return ranking(ConexionDB.EjecutarConsulta(sql));
        }

        ~GestionONG()
        {
            try
            {
                DataTable donaciones = ObtenerDonaciones();

                string reporte =
                    $"=== REPORTE FINAL DE TRANSPARENCIA ===\n" +
                    $"Total donaciones registradas: {donaciones.Rows.Count}\n" +
                    $"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}\n";

                System.IO.File.AppendAllText("reporte_transparencia.txt", reporte);
            }
            catch
            {
            }
        }
        public DataTable BuscarDonantes(string nombre)
        {
            string sql = @"SELECT * FROM Donantes
                   WHERE Nombre LIKE @Nombre";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Nombre", "%" + nombre + "%")
    };

            return ConexionDB.EjecutarConsulta(sql, parametros);
        }
        public DataTable BuscarDonaciones(string nombre)
        {
            string sql = @"SELECT d.IdDonacion,
                          dn.Nombre AS Donante,
                          p.NombreProyecto AS Proyecto,
                          d.Monto,
                          d.Fecha,
                          d.MetodoPago
                   FROM Donaciones d
                   INNER JOIN Donantes dn ON d.IdDonante = dn.IdDonante
                   INNER JOIN Proyectos p ON d.IdProyecto = p.IdProyecto
                   WHERE dn.Nombre LIKE @Nombre";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Nombre", "%" + nombre + "%")
    };

            return ConexionDB.EjecutarConsulta(sql, parametros);
        }
        public void EditarBeneficiario(int id, Beneficiario b)
        {
            string sql = @"UPDATE Beneficiarios
                   SET Nombre=@Nombre,
                       Direccion=@Direccion,
                       Cedula=@Cedula,
                       Telefono=@Telefono,
                       IdProyecto=@IdProyecto
                   WHERE IdBeneficiario=@Id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@Direccion", b.Direccion),
        new SqlParameter("@Nombre", b.Nombre),
        new SqlParameter("@Cedula", b.Cedula),
        new SqlParameter("@Telefono", b.Telefono),
        new SqlParameter("@IdProyecto", b.IdProyecto),
        new SqlParameter("@Id", id)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        public void EliminarBeneficiario(int id)
        {
            string sql = "DELETE FROM Beneficiarios WHERE IdBeneficiario=@Id";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Id", id)
    };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        public DataTable BuscarBeneficiarios(string nombre)
        {
            string sql = @"SELECT b.IdBeneficiario,
                          b.Nombre,
                          b.Cedula,
                          b.Telefono,
                          p.NombreProyecto AS Proyecto
                   FROM Beneficiarios b
                   INNER JOIN Proyectos p
                        ON b.IdProyecto = p.IdProyecto
                   WHERE b.Nombre LIKE @Nombre";

            SqlParameter[] parametros =
            {
        new SqlParameter("@Nombre", "%" + nombre + "%")
    };

            return ConexionDB.EjecutarConsulta(sql, parametros);
        }

       
    }
}