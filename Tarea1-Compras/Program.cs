using System;
using Tarea1_Compras.Entity;
using Tarea1_Compras.Service;

namespace Tarea1_Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Funciones funciones = new Funciones();
            Cliente cliente = funciones.SolicitarDatosCliente();
            int suma = funciones.SolicitarPreciosArticulos();
            funciones.ImprimirInformacionCliente(cliente);
            funciones.CalcularDescuentoOPromocion(suma);
        }
    }
}
