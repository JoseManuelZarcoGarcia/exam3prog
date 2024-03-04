using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaE3.Servicios
{
    /// <summary>
    /// clase que implementa los distinto menus de la app
    /// jzg - 040324
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que implementa el menu principal
        /// jzg - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();
        /// <summary>
        /// metodo que implementa el menu del gerente
        /// jzg - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuGerente();
        /// <summary>
        /// metodo que implementa el menu del empleado
        /// jzg - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuEmpleado();

    }
}
