using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCORE
{
    public class CursoInstructor
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
