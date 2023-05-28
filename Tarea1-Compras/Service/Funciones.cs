using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1_Compras.Entity;

namespace Tarea1_Compras.Service
{
    public class Funciones
    {
        public Cliente SolicitarDatosCliente()
        {
            Console.WriteLine("-*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("¡  ¡  ¡ B  I  E  N  V  E  N  I  D  O  <3  !  !  !");
            Console.WriteLine("-*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("Datos del cliente");
            Cliente cliente = new Cliente();

            try
            {
                Console.Write("Nombre: ");
                cliente.Nombre = Console.ReadLine();

                Console.Write("Numero Telefonico: ");
                cliente.Numero = Console.ReadLine();

                Console.Write("Correo electrónico: ");
                cliente.Correo = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar los datos del cliente.");
                Console.WriteLine($"Mensaje de error: {ex.Message}");
                Environment.Exit(0);
            }

            return cliente;
        }

        public int SolicitarPreciosArticulos()
        {
            Console.WriteLine("\nIngrese precio :");
            int suma = 0;

            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"Precio {i}: ");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    suma += precio;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar los precios.");
                Console.WriteLine($"Mensaje de error: {ex.Message}");
                Environment.Exit(0);
            }

            return suma;
        }

        public void ImprimirInformacionCliente(Cliente cliente)
        {
            Console.WriteLine("Datos del cliente:");
            Console.WriteLine($"Nombre: {cliente.Nombre}");
            Console.WriteLine($"Teléfono: {cliente.Numero}");
            Console.WriteLine($"Correo electrónico: {cliente.Correo}");
        }

        public void CalcularDescuentoOPromocion(int suma)
        {
            Console.WriteLine($"Total de la compra: {suma:C}");

            if (suma >= 5000 && suma <= 7998)
            {
                double descuento = suma * 0.1;
                Console.WriteLine($"¡ ¡ FELICIDADES Descuento del 10% ! ! : Precio final es de {descuento - suma:C}");
            }
            else if (suma >= 8000 && suma <= 9999)
            {
                Console.WriteLine("¡ ¡ FELICIDADES PROMOCION DE 3 MESES SIN INTERESES ! ! ");
            }
            else if (suma > 10000)
            {
                Console.WriteLine("¡ ¡ FELICIDADES ! ! PROMOCION elija entre 3 meses sin intereses o 6 meses sin intereses");
            }
        }
    }
}
