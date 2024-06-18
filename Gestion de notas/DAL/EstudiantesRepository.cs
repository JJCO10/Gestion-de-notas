using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class EstudiantesRepository
    {
        static string cadenaConexion;

        public EstudiantesRepository() 
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cadenaConexion);
        }

        public Estudiante GetEstudianteById(string idEstudiante)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SP_CRUD_ESTUDIANTES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@procedimiento", 1);
                        command.Parameters.AddWithValue("@IDEstudiante", idEstudiante);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Estudiante
                                {
                                    IDEstudiante = reader["IDEstudiante"].ToString(),
                                    nombreCompleto = reader["NombreCompleto"].ToString(),
                                    fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    Direccion = reader["Direccion"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString(),
                                    IDGrado = reader["IDGrado"].ToString(),
                                    IDUsuario = reader["IDUsuario"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores SQL
                Console.WriteLine($"Error SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public bool AddEstudiante(Estudiante estudiante)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SP_CRUD_ESTUDIANTES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@procedimiento", 2);
                        command.Parameters.AddWithValue("@IDEstudiante", estudiante.IDEstudiante);
                        command.Parameters.AddWithValue("@NombreCompleto", estudiante.nombreCompleto);
                        command.Parameters.AddWithValue("@FechaNAcimiento", estudiante.fechaNacimiento);
                        command.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                        command.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                        command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                        command.Parameters.AddWithValue("@IDGrado", estudiante.IDGrado);
                        command.Parameters.AddWithValue("@IDUsuario", estudiante.IDUsuario);

                        var result = command.ExecuteScalar();
                        return result == null;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores SQL
                Console.WriteLine($"Error SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public bool UpdateEstudiante(Estudiante estudiante)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SP_CRUD_ESTUDIANTES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@procedimiento", 3);
                        command.Parameters.AddWithValue("@IDEstudiante", estudiante.IDEstudiante);
                        command.Parameters.AddWithValue("@NombreCompleto", estudiante.nombreCompleto);
                        command.Parameters.AddWithValue("@FechaNAcimiento", estudiante.fechaNacimiento);
                        command.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                        command.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                        command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                        command.Parameters.AddWithValue("@IDGrado", estudiante.IDGrado);
                        command.Parameters.AddWithValue("@IDUsuario", estudiante.IDUsuario);

                        var result = command.ExecuteScalar();
                        return result == null;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores SQL
                Console.WriteLine($"Error SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public bool DeleteEstudiante(string idEstudiante)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SP_CRUD_ESTUDIANTES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@procedimiento", 4);
                        command.Parameters.AddWithValue("@IDEstudiante", idEstudiante);

                        var result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores SQL
                Console.WriteLine($"Error SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }
    }
}
