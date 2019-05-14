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

            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");


            Console.WriteLine("------Obtener todos los proyectos que empiecen por b------");
            var letb = from p in proy
                       where (p.Nombre.StartsWith("B"))
                       select p;
            project.Imprimir(letb.ToList());

            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");


            Console.WriteLine("----Obtener todos los proyectos cuyo codigo sea multiplo de 7---");
            var codsie = proy.Where(x => x.Codigo % 7 == 0).ToList();
            project.Imprimir(codsie);

            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");


            Console.WriteLine("-------Agrupar los proyectos que tengan una duración superior a 6 y menor a 10 y los que sean mayor a 10-------");
            var groupsProy = proy.GroupBy(x =>
            {
                if (x.Codigo < 6)
                {
                    return "Son menores de 6: ";
                }
                else if (x.Codigo >= 6 && x.Codigo < 10)
                {
                    return "Estan entres 6 y 10: ";
                }
                else if(x.Codigo >= 10)
                {
                    return "Es mayor a 10: ";
                }
                else
                {
                    return "No hace parte de los rangos";
                }

            });
            foreach (var grupoPro in groupsProy)
            {
                Console.WriteLine("Grupo de proyectos: " + grupoPro.Key + "---Cantidad---" + grupoPro.Count());
                foreach (var item in grupoPro)
                {
                    Console.WriteLine("El nombre del proyecto: "+ item.Nombre +
                        "\r\n" + "Codigo Proyecto: " + item.Duracion);
                }
            }

            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");


            Console.WriteLine("----------Obtener el promedio de la duracion de todos los proyectos---------");
            var avgDuracion = proy.Average(x => x.Duracion);
            Console.WriteLine("El promedio de la duración de los proyectos es: " + avgDuracion);


            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");



            Console.WriteLine("------Obtener el nombre del proyecto con más duración-----");
            var maxDura = proy.Max(x => x.Duracion );
            var nom = (from p in proy
                       where (p.Duracion==maxDura)
                       select p.Nombre).FirstOrDefault();
            Console.WriteLine($"El proyecto con más duración es  { nom} Con una duracion de { maxDura}");

            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");

            Console.WriteLine("-----Seleccionar el nombre y el area del proyecto con duracion mayor a 6-----");
            var selDura = proy.Where(X => X.Duracion > 6).Select(x =>
            new
            {
                Area = x.Area,
                Nombre = x.Nombre
            }).ToList();
            project.Imprimir(selDura);
            



        }
    }
}
