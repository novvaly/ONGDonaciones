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
        // ============================================================
        // DONANTES
        // ============================================================

       
        // Inserta un nuevo donante en la base de datos.
        // Los campos opcionales (Cedula, Email, Telefono, Direccion) se
        // guardan como cadena vacía si vienen nulos, para evitar errores de null.
      
        public void RegistrarDonante(Donante d)
        {
            string sql = @"INSERT INTO Donantes (Nombre, Cedula, Email, Telefono, Direccion, FechaRegistro)
                           VALUES (@Nombre, @Cedula, @Email, @Telefono, @Direccion, @Fecha)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@Nombre", d.Nombre),
                new SqlParameter("@Cedula", d.Cedula ?? ""),
                new SqlParameter("@Email", d.Email ?? ""),
                new SqlParameter("@Telefono", d.Telefono ?? ""),
                new SqlParameter("@Direccion", d.Direccion ?? ""),
                new SqlParameter("@Fecha", d.FechaRegistro)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        
        // Actualiza los datos de un donante existente según su Id.
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
        // Elimina un donante de la base de datos según su Id.
        public void EliminarDonante(int id)
        {
            string sql = "DELETE FROM Donantes WHERE IdDonante=@Id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@Id", id)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        
        // Obtiene todos los donantes registrados.
       
        public DataTable ObtenerDonantes()
        {
            return ConexionDB.EjecutarConsulta("SELECT * FROM Donantes");
        }

        /// <summary>
        /// Busca donantes cuyo nombre contenga el texto indicado (búsqueda parcial, tipo "LIKE %texto%").
        /// </summary>
        /// <param name="nombre">Texto a buscar dentro del nombre del donante.</param>
        /// <returns>DataTable con los donantes que coinciden.</returns>
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


        // ============================================================
        // DONACIONES
        // ============================================================

        
        /// Registra una nueva donación asociada a un donante y a un proyecto
        public void RegistrarDonacion(Donacion donacion)
        {
            string sql = @"INSERT INTO Donaciones (IdDonante, IdProyecto, Monto, Fecha, MetodoPago)
                           VALUES (@IdDonante, @IdProyecto, @Monto, @Fecha, @MetodoPago)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@IdDonante", donacion.Donante.Id),
                new SqlParameter("@IdProyecto", donacion.IdProyecto),
                new SqlParameter("@Monto", donacion.Monto),
                new SqlParameter("@Fecha", donacion.Fecha),
                new SqlParameter("@MetodoPago", donacion.TipoDonacion)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

       
        /// Actualiza los datos de una donación existente
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

       
        // Elimina una donación de la base de datos según su Id
        public void EliminarDonacion(int id)
        {
            string sql = "DELETE FROM Donaciones WHERE IdDonacion=@Id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@Id", id)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        
        // Obtiene todas las donaciones, incluyendo el nombre del donante
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

        // Obtiene todas las donaciones asociadas a un proyecto específico.
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

        // Busca donaciones cuyo donante tenga un nombre que contenga el texto indicado
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

       
        // Genera un ---ranking de los 10 donantes que más han aportado en total,
        // ordenado de mayor a menor monto acumulado.
        // Usa una función lambda (Func) para procesar el DataTable devuelto por la consulta
        // y transformarlo en una lista de cadenas ya formateadas para mostrar en pantalla
        public List<string> ObtenerRankingDonantes()
        {
            // Función local que recibe la tabla cruda de la BD y arma el listado final.
            Func<DataTable, List<string>> ranking = (tabla) =>
            {
                return tabla.AsEnumerable()
                    .OrderByDescending(r => r.Field<decimal>("TotalDonado")) // Mayor a menor monto
                    .Take(10)                                               // Solo el top 10
                    .Select((r, i) => $"#{i + 1} {r["Nombre"]} - RD${r["TotalDonado"]:N2}")
                    .ToList();
            };

            // Suma el total donado por cada donante agrupando por nombre.
            string sql = @"SELECT d.Nombre, SUM(dn.Monto) AS TotalDonado
                           FROM Donantes d
                           INNER JOIN Donaciones dn ON d.IdDonante = dn.IdDonante
                           GROUP BY d.Nombre
                           ORDER BY TotalDonado DESC";

            return ranking(ConexionDB.EjecutarConsulta(sql));
        }


        // ============================================================
        // PROYECTOS
        // ============================================================

        /// <summary>
        /// Obtiene todos los proyectos registrados.
        /// </summary>
        /// <returns>DataTable con todas las filas de la tabla Proyectos.</returns>
        public DataTable ObtenerProyectos()
        {
            return ConexionDB.EjecutarConsulta("SELECT * FROM Proyectos");
        }


        // ============================================================
        // BENEFICIARIOS
        // ============================================================

        /// <summary>
        /// Registra un nuevo beneficiario y lo asigna a un proyecto.
        /// </summary>
        /// <param name="b">Objeto Beneficiario con los datos a registrar.</param>
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

        /// <summary>
        /// Actualiza los datos de un beneficiario existente.
        /// </summary>
        /// <param name="id">Id del beneficiario a editar.</param>
        /// <param name="b">Objeto Beneficiario con los nuevos datos.</param>
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
                new SqlParameter("@Nombre", b.Nombre),
                new SqlParameter("@Direccion", b.Direccion),
                new SqlParameter("@Cedula", b.Cedula),
                new SqlParameter("@Telefono", b.Telefono),
                new SqlParameter("@IdProyecto", b.IdProyecto),
                new SqlParameter("@Id", id)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        /// <summary>
        /// Elimina un beneficiario de la base de datos según su Id.
        /// </summary>
        /// <param name="id">Id del beneficiario a eliminar.</param>
        public void EliminarBeneficiario(int id)
        {
            string sql = "DELETE FROM Beneficiarios WHERE IdBeneficiario=@Id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@Id", id)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }

        /// <summary>
        /// Obtiene todos los beneficiarios junto con el nombre del proyecto
        /// al que están asignados (mediante JOIN con Proyectos).
        /// </summary>
        /// <returns>DataTable con el detalle completo de todos los beneficiarios.</returns>
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

        /// <summary>
        /// Busca beneficiarios cuyo nombre contenga el texto indicado (búsqueda parcial).
        /// </summary>
        /// <param name="nombre">Texto a buscar dentro del nombre del beneficiario.</param>
        /// <returns>DataTable con los beneficiarios que coinciden.</returns>
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


        // ============================================================
        // CERTIFICADOS
        // ============================================================

        /// <summary>
        /// Genera un certificado de donación, vinculándolo a una donación
        /// y a un donante específicos, con un código único y descripción.
        /// </summary>
        /// <param name="c">Objeto Certificado con los datos a registrar.</param>
        public void GenerarCertificado(Certificado c)
        {
            string sql = @"INSERT INTO Certificados (IdDonacion, IdDonante, FechaEmision, CodigoCertificado, Descripcion)
                           VALUES (@IdDonacion, @IdDonante, @Fecha, @Codigo, @Descripcion)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@IdDonacion", c.Donacion.IdDonacion),
                new SqlParameter("@IdDonante", c.Donante.Id),
                new SqlParameter("@Fecha", c.FechaEmision),
                new SqlParameter("@Codigo", c.CodigoCertificado),
                new SqlParameter("@Descripcion", c.Descripcion)
            };

            ConexionDB.EjecutarComando(sql, parametros);
        }


        // ============================================================
        // REPORTES / UTILIDADES
        // ============================================================

        /// <summary>
        /// Destructor de la clase. Se ejecuta cuando el recolector de basura
        /// libera el objeto (no hay momento exacto garantizado).
        /// Intenta generar un reporte final de transparencia con el total
        /// de donaciones registradas y lo agrega al archivo "reporte_transparencia.txt".
        /// El bloque try/catch evita que cualquier error aquí genere una excepción
        /// no controlada durante la finalización del objeto.
        /// </summary>
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
                // Se ignora cualquier error: un finalizador nunca debe lanzar excepciones.
            }
        }
    }
}