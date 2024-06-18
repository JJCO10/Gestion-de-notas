using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class EstudiantesService
    {

        private readonly EstudiantesRepository estudianteData;

        public EstudiantesService()
        {
            estudianteData = new EstudiantesRepository();
        }
        public Estudiante GetEstudianteById(string idEstudiante)
        {
            try
            {
                if (string.IsNullOrEmpty(idEstudiante))
                {
                    throw new ArgumentException("El ID del estudiante no puede ser nulo o vacío.");
                }

                return estudianteData.GetEstudianteById(idEstudiante);
            }
            catch (Exception ex)
            {
                // Manejo de errores específicos de la lógica de negocio
                Console.WriteLine($"Error en BLL: {ex.Message}");
                throw;
            }
        }

        public bool AddEstudiante(Estudiante estudiante)
        {
            try
            {
                if (estudiante == null)
                {
                    throw new ArgumentNullException(nameof(estudiante), "El objeto estudiante no puede ser nulo.");
                }

                // Puedes agregar más validaciones aquí
                if (string.IsNullOrEmpty(estudiante.IDEstudiante) || string.IsNullOrEmpty(estudiante.nombreCompleto))
                {
                    throw new ArgumentException("El ID del estudiante y el nombre completo no pueden ser nulos o vacíos.");
                }

                return estudianteData.AddEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                // Manejo de errores específicos de la lógica de negocio
                Console.WriteLine($"Error en BLL: {ex.Message}");
                throw;
            }
        }

        public bool UpdateEstudiante(Estudiante estudiante)
        {
            try
            {
                if (estudiante == null)
                {
                    throw new ArgumentNullException(nameof(estudiante), "El objeto estudiante no puede ser nulo.");
                }

                // Puedes agregar más validaciones aquí
                if (string.IsNullOrEmpty(estudiante.IDEstudiante))
                {
                    throw new ArgumentException("El ID del estudiante no puede ser nulo o vacío.");
                }

                return estudianteData.UpdateEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                // Manejo de errores específicos de la lógica de negocio
                Console.WriteLine($"Error en BLL: {ex.Message}");
                throw;
            }
        }

        public bool DeleteEstudiante(string idEstudiante)
        {
            try
            {
                if (string.IsNullOrEmpty(idEstudiante))
                {
                    throw new ArgumentException("El ID del estudiante no puede ser nulo o vacío.");
                }

                return estudianteData.DeleteEstudiante(idEstudiante);
            }
            catch (Exception ex)
            {
                // Manejo de errores específicos de la lógica de negocio
                Console.WriteLine($"Error en BLL: {ex.Message}");
                throw;
            }
        }
    }
}
