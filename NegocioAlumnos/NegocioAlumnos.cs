using EntidadAlumno;
using System.Data.SqlClient;
using System.Configuration;
using DatosAlumnos;
using System;
using EntidadPermiso;
using System.Data;

namespace Negocio
{
    public class NegocioAlumnos
    {
        public static int insertar(Alumno a)
        {
            if (String.IsNullOrEmpty(a.Nombre))
            {
                return 0;
            }
            if (a.Dni =="")
            {
                return 0;
            }
            if (a.FechaNacimiento == null)
            {
                a.FechaNacimiento = DateTime.Now;
            }
            try
            {
                return AlumnosDatos.insertar(a);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static int editar(Alumno a)
        {
            if (String.IsNullOrEmpty(a.Nombre))
            {
                return 0;
            }
            if (a.Dni == "")
            {
                return 0;
            }
            if (a.FechaNacimiento == null)
            {
                a.FechaNacimiento = DateTime.Now;
            }
            try
            {
                return AlumnosDatos.modificar(a);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int buscar(Alumno a)
        {
            if (a.Dni == "")
            {
                return 1;
            }
            try
            {
                return AlumnosDatos.buscar(a);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int registrarEstado(string dni, string estado, DateTime fecha)
            {
            
            try
            {
                return AlumnosDatos.registrarEstado(dni, estado, fecha);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int buscarCargo(Permisos p) 
        {
            try
            {
                return AlumnosDatos.buscarCargo(p);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static DataTable buscarinasistencias() 
        {
            return AlumnosDatos.buscarinasistencias();
        }
    }
   
}
