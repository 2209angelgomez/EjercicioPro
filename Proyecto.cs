using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPproyecto
{
    class Proyecto
    {
        //obtener todos los proyectos cuya duración sea superior a 6 y menor a 12
        //obtener todos los proyectos que empiecen por b
        //obtener todos los proyectos cuyo codigo sea multiplo de 7
        //agrupar los proyectos que tengan una duración superior a 6 y menor a 10 y los que sean mayor a 10
        //obtener el promedio de la duracion de todos los proyectos
        //obtener el nombre del proyecto con más duración 
        //seleccionar el nombre y el area del proyecto con duracion mayor a 6
        //verificar si existe un proyecto con una duración superior a 24
        //sumar las duraciones de los proyectos cuyo codigo sea superior a 20
        // tomar los 2 primeros proyectos cuyo codigo sea superior a 30


        public List<Proyecto> proyectos = new List<Proyecto>();

        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        //public List<Proyecto> AgregarProyecto()
        //{
        //    Console.WriteLine("Escriba (Y) para ingresar");
        //    var res = Console.ReadLine();
        //    while (res == "Y")
        //    {
        //        Console.WriteLine("Escriba el nombre del proyecto");
        //        var nom = Console.ReadLine();
        //        Console.WriteLine("Escriba el codigo del proyecto");
        //        var cod = Console.ReadLine();
        //        var miProyecto = new Proyecto()
        //        {

        //        };
        //        proyectos.Add(miProyecto);
        //        Console.WriteLine("Escriba (Y) para ingresar");
        //        res = Console.ReadLine();
        //    }
        //    return proyectos;
        //}

        public List<Proyecto> AgregarProyecto2()
        {
            var proys = new List<Proyecto>()
            {
                new Proyecto()
                {
                    Nombre = "Bancaria",
                    Codigo = 7,
                    Area = "Comercio",
                    Duracion = 12
                },

                new Proyecto()
                {
                    Nombre = "Mercadeo",
                    Codigo = 23,
                    Area = "Talento Humano",
                    Duracion = 6
                },

                new Proyecto()
                {
                    Nombre = "Atención Primaria",
                    Codigo = 23,
                    Area = "AIPI",
                    Duracion = 32
                },

                new Proyecto()
                {
                    Nombre = "Analisis y Desarrollo de Sistemas de Información",
                    Codigo = 25,
                    Area = "Sistemas",
                    Duracion = 18
                },

                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 27,
                    Area = "Sistemas",
                    Duracion = 9
                },

                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 27,
                    Area = "Sistemas",
                    Duracion = 7
                },
                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 34,
                    Area = "Sistemas",
                    Duracion = 10
                },
                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 24,
                    Area = "Sistemas",
                    Duracion = 9
                },
                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 33,
                    Area = "Sistemas",
                    Duracion = 5
                },
                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 40,
                    Area = "Sistemas",
                    Duracion = 7
                }

            };
            return proys;
        }

        public void Imprimir(List<Proyecto> proy)
        {
            
            foreach (var item in proy)
            {
                Console.WriteLine($"    Nombre {item.Nombre}");
                Console.WriteLine($"    Codigo {item.Codigo}");
                Console.WriteLine($"    Area {item.Area}");
                Console.WriteLine($"    Duracion {item.Duracion}");
                Console.WriteLine("---------------------------------------");

            }
        }
        
        

    }

   
}
