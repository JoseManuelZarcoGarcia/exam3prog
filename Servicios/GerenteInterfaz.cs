using jzarciaE3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Servicios
{
    /// <summary>
    /// interfaz que implementas los metodos de los empleados
    /// jzg - 040324
    /// </summary>
    internal interface GerenteInterfaz
    {
        /// <summary>
        /// metod qu muestra todas las ventas
        /// jzg - 040324
        /// </summary>
        /// <param name="ventas"></param>
        public void mostrarVentas(List<VentasDto> ventas);

        /// <summary>
        /// metodo que añade un nuevo pedido
        /// jzg - 040324
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void anyadirVenta(List<PedidosDto> listaPedidos);

    }
}
