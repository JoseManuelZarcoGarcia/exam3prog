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
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Metodo que añade a la lista de ventas una nueva venta
        /// jzg - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        public List<VentasDto> anyadirVenta(List<VentasDto> listaVentas);
        /// <summary>
        /// Metodo que muestra por consola el importe total de sumar las vetas
        /// jzg - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarTotalVentas(List<VentasDto> listaVentas);

    }
}
