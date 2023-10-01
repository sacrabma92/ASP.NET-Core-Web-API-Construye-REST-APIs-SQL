using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCORE
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Grado { get; set; }
        public byte[] FotoPerfil { get; set; }
        public List<CursoInstructor> CursoLink { get; set; }
    }
}
