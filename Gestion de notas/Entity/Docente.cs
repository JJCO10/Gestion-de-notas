using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Docente
    {
        public string IDDocente { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string IDEspecialidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string IDUsuario { get; set; }
    }
}
