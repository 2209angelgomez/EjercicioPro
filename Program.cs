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



            Console.WriteLine("-----OBTENER TODOS LOS PROYECTOS CUYA DURACIÓN SEA SUPERIOR A 6 Y MENOR A 12-----");
            Console.WriteLine("");
            var supinf = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            project.Imprimir(supinf);

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("-----OBTENER TODOS LOS PROYECTOS QUE EMPIECEN POR B-----");
            Console.WriteLine("");
            var letb = from p in proy
                       where (p.Nombre.StartsWith("B"))
                       select p;
            project.Imprimir(letb.ToList());

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("-----OBTENER TODOS LOS PROYECTOS CUYO CÓDIGO SEA MÚLTIPLO DE 7-----");
            Console.WriteLine("");
            var codsie = proy.Where(x => x.Codigo % 7 == 0).ToList();
            project.Imprimir(codsie);

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("-----AGRUPAR LOS PROYECTOS QUE TENGAN UNA DURACIÓN SUPERIOR A 6 Y MENOR A 10 Y LOS QUE SEAN MAYOR A 10-----");
            Console.WriteLine("");
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

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("-----OBTENER EL PROMEDIO DE LA DURACIÓN DE TODOS LOS PROYECTOS-----");
            Console.WriteLine("");
            var avgDuracion = proy.Average(x => x.Duracion);
            Console.WriteLine("El promedio de la duración de los proyectos es: " + avgDuracion);

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");



            Console.WriteLine("-----OBTENER EL NOMBRE DEL PROYECTO CON MÁS DURACIÓN-----");
            Console.WriteLine("");
            var maxDura = proy.Max(x => x.Duracion );
            var nom = (from p in proy
                       where (p.Duracion==maxDura)
                       select p.Nombre).FirstOrDefault();
            Console.WriteLine($"El proyecto con más duración es  { nom} Con una duracion de { maxDura}");

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");

            Console.WriteLine("-----SELECCIONAR EL NOMBRE Y EL ÁREA DEL PROYECTO CON DURACIÓN MAYOR A 6-----");
            Console.WriteLine("");
            var selDura = proy.Where(X => X.Duracion > 6).Select(x =>
            new
            {
                Area = x.Area,
                Nombre = x.Nombre
            }).ToList();

            foreach (var item in selDura)
            {
                Console.WriteLine("Nombre de proyecto " + item.Nombre + "\r\n" + "Area: " + item.Area);
            }

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");

            Console.WriteLine("-----VERIFICAR SI EXISTE UN PROYECTO CON UNA DURACIÓN SUPERIOR A 24-----");
            Console.WriteLine("");
            var proSup = proy.Where(x => x.Duracion > 24);

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("-----SUMAR LAS DURACIONES DE LOS PROYECTOS CUYO CÓDIGO SEA SUPERIOR A 20-----");
            Console.WriteLine("");
            var sumPro = proy.Where(x => x.Codigo > 20).Sum(x => x.Codigo);
            Console.WriteLine("Suma de los codigos de proyectos mayores a 20: " + sumPro);

            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("");

            Console.WriteLine("-----TOMAR LOS 2 PRIMEROS PROYECTOS CUYO CÓDIGO SEA SUPERIOR A 30-----");
            Console.WriteLine("");
            var codSup = proy.Where(x => x.Codigo > 30).Take(2).ToList();
            project.Imprimir(codSup);
            


        }
    }
}
