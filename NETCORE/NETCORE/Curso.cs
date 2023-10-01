using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCORE
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        //public byte[] FotoPublicacion { get; set; }
        public Precio PrecioPromocion { get; set; }
        public List<Comentario> ComentarioLista { get; set; }
        public List<CursoInstructor> InstructoresLink { get; set; }
    }
}
