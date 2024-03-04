using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Dtos
{
    /// <summary>
    /// Clase que representa los objetos Ventas
    /// jzg - 040324
    /// </summary>
    internal class VentasDto
    {

        //Atributos

        long idVenta;
        long cantidadImporte = 0;
        DateTime fechaVenta = DateTime.Now;


        //Getter and Setter
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public long CantidadImporte { get => cantidadImporte; set => cantidadImporte = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }


        //Constructores
        public VentasDto(long idVenta, long cantidadImporte, DateTime fechaVenta)
        {
            this.idVenta = idVenta;
            this.cantidadImporte = cantidadImporte;
            this.fechaVenta = fechaVenta;
        }
        
        public VentasDto() { }


  
    }
}
