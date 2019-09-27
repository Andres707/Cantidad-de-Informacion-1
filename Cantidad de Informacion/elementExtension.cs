using System;

namespace Cantidad_de_Informacion
{
    /// <summary>
    ///     Definicion de clase elementExtension para extensiones de la clase ELement
    /// </summary>
    internal static class elementExtension
    {
        /// <summary>
        ///     Metodo actualizar para aumentar el numero de ocurrencias de un elemento
        /// </summary>
        /// <param name="element">Elemento que se actualizara</param>
        /// <returns>Elemento actualizado en concurrencias</returns>
        public static Element actualizar(this Element element)
        {
            element.Ocurrencias += 1;
            return element;
        }

        public static string probFraccion(this Element element, int cantidadTotal)
        {
            return element.Ocurrencias + "/" + cantidadTotal;
        }

        public static void probabilidad(this Element element, decimal cantidadTotal)
        {
            element.Probabilidad = element.Ocurrencias / cantidadTotal;
        }

        public static void informacion(this Element element)
        {
            element.Informacion = (decimal) Math.Log( 1.0 / (double) element.Probabilidad, 2);
        }

        public static decimal entropia(this Element element)
        {
            element.Entropia = element.Informacion * element.Probabilidad;
            return element.Entropia;
        }
    }
}