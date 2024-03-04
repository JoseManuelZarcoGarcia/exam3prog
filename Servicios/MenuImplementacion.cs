using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("---------------------");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Menu Gerente");
            Console.WriteLine("2. Menu Empleado");
            Console.WriteLine("---------------------");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

        public int mostrarMenuGerente()
        {
            int opcionSeleccionada;

            Console.WriteLine("---------------------");
            Console.WriteLine("0. Mostrar ventas del dia");
            Console.WriteLine("1. Crear pedido para proveedores");
            Console.WriteLine("---------------------");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

        public int mostrarMenuGerente2()
        {
            int opcionSeleccionada;

            Console.WriteLine("---------------------");
            Console.WriteLine("0. Mostrar ventas del dia");
            Console.WriteLine("1. Crear pedido para proveedores");
            Console.WriteLine("---------------------");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

        public int mostrarMenuEmpleado()
        {
            int opcionSeleccionada;

            Console.WriteLine("---------------------");
            Console.WriteLine("0. Anyadri venta");
            Console.WriteLine("1. Cálculo total de ventas diario");
            Console.WriteLine("---------------------");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

    }
}
