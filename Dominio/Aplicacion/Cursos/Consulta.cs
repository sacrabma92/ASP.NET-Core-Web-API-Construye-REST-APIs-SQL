using Dominio.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Cursos
{
    public class Consulta
    {
        public class ListaCursos : IRequest<List<Curso>> { }

        public class Manejador : IRequestHandler<ListaCursos, List<Curso>>
        {
            private readonly ApplicationDbContext _context;

            public Manejador(ApplicationDbContext context)
            {
                _context = context;
            }
            public Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                var cursos = _context.Curso.ToListAsync();
                return cursos;
            }
        }
    }
}
