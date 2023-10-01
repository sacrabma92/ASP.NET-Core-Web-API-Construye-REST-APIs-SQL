

using Microsoft.EntityFrameworkCore;
using NETCORE;

using (var db = new ApplicationDbContext())
{
    //var cursos = db.Curso.AsNoTracking(); // IQueryable
    //foreach (var curso in cursos)
    //{
    //    Console.WriteLine(curso.Titulo);
    //}

    var cursos = db.Curso
                    .Include(x => x.PrecioPromocion)
                    .AsNoTracking();
    foreach (var curso in cursos)
    {
        Console.WriteLine(curso.Titulo + " --- " + curso.PrecioPromocion.PrecioActual);
    }
}