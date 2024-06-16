using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Nota
    {
        public string IDNota { get; set; }
        public decimal notaEstudiante { get; set; }
        public string Observacion { get; set; }
        public string IDEstudiante { get; set; }
        public string IDMateria { get; set; }
        public string IDPeriodo { get; set; }
    }
}
