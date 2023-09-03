using EntidadAlumno;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadPermiso;
using System.Data;

namespace DatosAlumnos
{
    public class AlumnosDatos
    {
        public static int insertar(Alumno a)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("alumnosInsert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", a.Nombre);
                command.Parameters.AddWithValue("@apellido", a.Apellido);
                command.Parameters.AddWithValue("@dni", a.Dni);
                command.Parameters.AddWithValue("@fechaNacimiento", a.FechaNacimiento);
                command.Parameters.AddWithValue("@email", a.Email);
                command.Parameters.AddWithValue("@domicilio", a.Domicilio);
                command.Parameters.AddWithValue("@telefono", a.Telefono);
                command.Parameters.AddWithValue("@curso", a.Curso);
                command.Parameters.AddWithValue("@division", a.division);
                try
                {
                    connection.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }
                return idAlumnoCreado;

            }
        }
        public static int modificar(Alumno a)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("modificar_alumno", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_dni", a.Dni);
                command.Parameters.AddWithValue("@p_nombre", a.Nombre);
                command.Parameters.AddWithValue("@p_apellido", a.Apellido);
                command.Parameters.AddWithValue("@p_fecha_nacimiento", a.FechaNacimiento);
                command.Parameters.AddWithValue("@p_email", a.Email);
                command.Parameters.AddWithValue("@p_domicilio", a.Domicilio);
                command.Parameters.AddWithValue("@p_telefono", a.Telefono);
                command.Parameters.AddWithValue("@p_curso", a.Curso);
                command.Parameters.AddWithValue("@p_division", a.division);
                try
                {
                    connection.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception)
                {
                    throw;
                    connection.Close();
                }
                return idAlumnoCreado;
                connection.Close();
            }

        }
        public static int buscar(Alumno a)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand("BuscarAlumno", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@dni", Convert.ToDouble(a.Dni));
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Alumno busqueda = new Alumno();
                    a.Nombre = Convert.ToString(reader["nombre"]);
                    a.Apellido = Convert.ToString(reader["apellido"]);
                    a.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    a.Email = Convert.ToString(reader["email"]);
                    a.Domicilio = Convert.ToString(reader["Domicilio"]);
                    a.Telefono = Convert.ToString(reader["telefono"]);
                    a.Curso = Convert.ToString(reader["curso"]);
                    a.division = Convert.ToString(reader["division"]);
                    a.Id = Convert.ToInt32(reader["id"]);
                    connection.Close();
                    reader.Close();
                }
            }
            return idAlumnoCreado;

        }
        public static int registrarEstado(string dni, string estado, DateTime fecha)
        {
            int idAlumnoCreado = 0;
            double dniTraido = Convert.ToDouble(dni);
            string estadotraido = estado;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand command = new SqlCommand("InsertarAsistencia", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dni", dniTraido);
                command.Parameters.AddWithValue("@asistencia", estadotraido);
                command.Parameters.AddWithValue("@fecha", fecha);
                try
                {

                    connection.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception)
                {
                    throw;
                }
                return idAlumnoCreado;
            }


        }
        public static int buscarCargo(Permisos p)
        {
            int idAlumnoCreado = 0;



            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("VerificarUsuario", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DNI", p.dni);
                command.Parameters.AddWithValue("@contraseña", p.pass);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    p.Desc = Convert.ToString(reader["cargo"]);
                    connection.Close();
                    reader.Close();

                }
                return idAlumnoCreado;
            }

        }
        public static DataTable buscarinasistencias()
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("MostrarAlumnosAusentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Aquí debes cerrar la conexión a tu base de datos
                return dt;


            }
        }
    }
}
