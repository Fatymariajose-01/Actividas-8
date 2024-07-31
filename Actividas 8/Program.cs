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
    }

}
