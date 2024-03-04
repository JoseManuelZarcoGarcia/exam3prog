using jzarciaE3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {

        public List<VentasDto> anyadirVenta(List<VentasDto> listaVentas)
        {
            VentasDto venta = new VentasDto();

            Console.WriteLine("Anyada un importe: ");
            venta.CantidadImporte = Convert.ToInt32(Console.ReadLine());
            venta.IdVenta = crearId(listaVentas);

            listaVentas.Add(venta);

            return listaVentas;
        }

        /// <summary>
        /// medodo que crea id para las ventas
        /// jzg - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private long crearId(List<VentasDto> listaVentas)
        {
            int tamanyoLista = listaVentas.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = listaVentas[tamanyoLista - 1].IdVenta + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaId;
        }

        public void mostrarTotalVentas(List<VentasDto> listaVentas)
        {
            long total = calculoTotalVentas(listaVentas);
            Console.WriteLine("Escriba la fecha en formato: dd-MM-yyyy");

            
            DateTime fechaInicio = listaVentas[0].FechaVenta;
            string fechaFinal = Console.ReadLine();
            DateTime fechaFinalParse = DateTime.Parse(fechaFinal);
            TimeSpan tiempoTrascurrido = DateTime.Now - fechaFinalParse;
            int horas = tiempoTrascurrido.Hours;
            int minutos = tiempoTrascurrido.Minutes;
            int seguntos = tiempoTrascurrido.Seconds;
            Console.WriteLine("Total ventas: {0} euros", total);
            Console.WriteLine("Tiempo transcurrido: {0} horas {1} minutos y {2} segundos", horas, minutos, seguntos);
        }

        /// <summary>
        /// metodo que suma todas las ventas
        /// jzg - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private long calculoTotalVentas(List<VentasDto> listaVentas)
        {

            long total = 0;
            foreach(VentasDto ventas in listaVentas)
            {
                total = total + ventas.CantidadImporte;
            }

            return total;
        }



    }
}
