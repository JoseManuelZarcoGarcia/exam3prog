using jzarciaE3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Servicios
{
    internal class GerenteImplementacion : GerenteInterfaz
    {

        public void anyadirVenta(List<PedidosDto> listaPedidos)
        {
            PedidosDto pedido = new PedidosDto();
            /*
            Console.WriteLine("Anyada un importe: ");
            pedido.CantidadImporte = Convert.ToInt32(Console.ReadLine());
            pedido.IdVenta = crearId(listaPedidos);
            */
            Console.WriteLine("Este metodo esta en mantenimiento");
        }

        /// <summary>
        /// medodo que crea id para los pedidos
        /// jzg - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private long crearId(List<PedidosDto> listaPedidos)
        {
            int tamanyoLista = listaPedidos.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = listaPedidos[tamanyoLista - 1].IdPedido + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaId;
        }

        public void mostrarVentas(List<VentasDto> ventas)
        {

            Console.WriteLine("Escriba la fecha en formato: ddMMyyyy");
            string nombreFichero = Console.ReadLine();
            string rutaFichero = "C:\\Users\\csi22-jzarcia" + nombreFichero + ".txt";
            StreamWriter sw = new StreamWriter(rutaFichero);

            foreach (VentasDto ventasDto in ventas)
            {
                sw.WriteLine(rutaFichero, true);
                
                Console.WriteLine("……….");
                Console.WriteLine("Venta número: {0}", ventasDto.IdVenta);
                Console.WriteLine("Euros: {0} euros", ventasDto.CantidadImporte);
                Console.WriteLine("Instante de compra: {0}", ventasDto.FechaVenta);
                Console.WriteLine("……….");
                
                sw.Close();
            }
        }

    }
}
