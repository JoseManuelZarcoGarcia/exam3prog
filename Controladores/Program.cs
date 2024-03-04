using jzarciaE3.Dtos;
using jzarciaE3.Servicios;

namespace jzarciaE3.Controladores
{
    /// <summary>
    /// Clase principal por la que empieza el programa
    /// jzg - 040324
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal por la que empieza el programa
        /// jzg - 040324
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();
            GerenteInterfaz gi = new GerenteImplementacion();
            List<VentasDto> listaVentas = new List<VentasDto> ();
            List<PedidosDto> listaPedidos = new List<PedidosDto>();

            do
            {
                opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {
                    

                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        opcionSeleccionada = mi.mostrarMenuGerente();

                        switch (opcionSeleccionada)
                        {
                            case 0:
                                gi.mostrarVentas(listaVentas);
                                break;
                            case 1:
                                bool cerrarPedido = false;
                                
                                do
                                {
                                    Console.WriteLine("Desea anyadir un producto? si/no");
                                    string respuesta = Console.ReadLine();
                                    if(respuesta == "si")
                                    {
                                        Console.WriteLine("Esta seccion esta en produccion");
                                        //gi.mostrarVentas(listaVentas);
                                    }
                                    else
                                    {
                                        cerrarPedido= true;
                                    }
                                } while (!cerrarPedido);
                                break;

                            default:
                                Console.WriteLine("No es una opcion valida");
                                break;

                        }

                        break;
                    case 2:
                        opcionSeleccionada = mi.mostrarMenuEmpleado();

                        switch (opcionSeleccionada)
                        {
                            case 0:
                                ei.anyadirVenta(listaVentas);
                                break; 
                            case 1:
                                ei.mostrarTotalVentas(listaVentas);
                                break;

                            default:
                                Console.WriteLine("No es una opcion valida");
                                break;

                        }

                        break;
                    
                    default:
                        Console.WriteLine("No es una opcion valida");
                        break;
                }

            } while (!cerrarMenu); 

        }

    }

}