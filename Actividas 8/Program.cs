using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorDeRecetas
{
    public class Receta
    {
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Instrucciones { get; set; }

        public Receta(string nombre, string ingredientes, string instrucciones)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Instrucciones = instrucciones;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nIngredientes: {Ingredientes}\nInstrucciones: {Instrucciones}";
        }
    }

    public class GestorDeRecetas
    {
        public List<Receta> recetas = new List<Receta>();

        public void AgregarReceta(Receta receta)
        {
            recetas.Add(receta);
            Console.WriteLine("Receta agregada con éxito.");
        }

        public Receta BuscarRecetaPorNombre(string nombre)
        {
            return recetas.FirstOrDefault(r => r.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public void ListarTodasLasRecetas()
        {
            if (recetas.Count > 0)
            {
                Console.WriteLine("Todas las Recetas:");
                foreach (var receta in recetas)
                {
                    Console.WriteLine(receta);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay recetas registradas.");
            }
        }
        class Programa
        {
            static void Main(string[] args)
            {
                GestorDeRecetas gestor = new GestorDeRecetas();
                bool ejecutando = true;

                while (ejecutando)
                {
                    Console.WriteLine("Gestor de Recetas");
                    Console.WriteLine("1. Agregar Receta");
                    Console.WriteLine("2. Buscar Receta por Nombre");
                    Console.WriteLine("3. Listar Todas las Recetas");
                    Console.WriteLine("4. Salir");
                    Console.Write("Elija una opción: ");

                    int opcion;
                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarReceta(gestor);
                                break;
                            case 2:
                                BuscarRecetaPorNombre(gestor);
                                break;
                            case 3:
                                gestor.ListarTodasLasRecetas();
                                break;
                            case 4:
                                ejecutando = false;
                                Console.WriteLine("Saliendo...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente nuevamente.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                    }
                }
            }


        }
        static void AgregarReceta(GestorDeRecetas gestor)
        {
            Console.Write("Ingrese el nombre de la receta: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese los ingredientes: ");
            string ingredientes = Console.ReadLine();

            Console.Write("Ingrese las instrucciones: ");
            string instrucciones = Console.ReadLine();

            Receta receta = new Receta(nombre, ingredientes, instrucciones);
            gestor.AgregarReceta(receta);
        }
        static void BuscarRecetaPorNombre(GestorDeRecetas gestor)
        {
            Console.Write("Ingrese el nombre de la receta para buscar: ");
            string nombre = Console.ReadLine();

            Receta receta = gestor.BuscarRecetaPorNombre(nombre);
            if (receta != null)
            {
                Console.WriteLine("Receta encontrada:");
                Console.WriteLine(receta);
            }
            else
            {
                Console.WriteLine("Receta no encontrada.");
            }
        }

    }
}
