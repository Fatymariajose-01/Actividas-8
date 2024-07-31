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

  
}
