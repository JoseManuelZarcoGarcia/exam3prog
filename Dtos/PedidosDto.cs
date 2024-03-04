using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Dtos
{
    /// <summary>
    /// Clase que representa los objetos Pedidos
    /// jzg - 040324
    /// </summary>
    internal class PedidosDto
    {
        //atributos
        long idPedido;
        string nombreProducto = "aaa";
        long cantidadProducto = 0;
        DateTime fechaVenta = DateTime.Now;

        

        //getter and setter
        public long IdPedido { get => idPedido; set => idPedido = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public long CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }


        //constructores
        public PedidosDto(long idPedido, string nombreProducto, long cantidadProducto, DateTime fechaVenta)
        {
            this.idPedido = idPedido;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaVenta = fechaVenta;
        }

        public PedidosDto() { } 
    }
}
