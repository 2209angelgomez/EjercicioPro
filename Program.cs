using System;
using System.Linq;

namespace EjercicioPproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--EJERCICIO---");
            Proyecto project = new Proyecto();
            project.proyectos = project.AgregarProyecto2();
            var proy = project.proyectos;
            Console.ReadKey();

            Console.WriteLine("----------obtener todos los proyectos cuya duración sea superior a 6 y menor a 12--------");
            var supinf = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            project.Imprimir(supinf);

            Console.WriteLine("------obtener todos los proyectos que empiecen por b------");
            var letb = from p in proy
                       where (p.Nombre.StartsWith("B"))
                       select p;
            project.Imprimir(letb.ToList());
            Console.ReadLine();

            Console.WriteLine("obtener todos los proyectos cuyo codigo sea multiplo de 7"

        }
    }
}
