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

        /// <summary>
        ///     Probabilidad de ocurrencia (visual)
        /// </summary>
        /// <param name="element">Elemento para obtener probabilidad</param>
        /// <param name="cantidadTotal">Cantidad total de caracteres</param>
        /// <returns>Probabilidad en cadena de texto (visual)</returns>
        public static string probFraccion(this Element element, int cantidadTotal)
        {
            return element.Ocurrencias + "/" + cantidadTotal;
        }

        /// <summary>
        ///     Metodo para obtener la probabilidad de un elemento
        /// </summary>
        /// <param name="element">Elemento para obtener probabilidad</param>
        /// <param name="cantidadTotal">Cantidad total de caracteres</param>
        public static void probabilidad(this Element element, decimal cantidadTotal)
        {
            element.Probabilidad = element.Ocurrencias / cantidadTotal;
        }

        /// <summary>
        ///     Metodo para calcular la informacion que proporciona un elemento
        /// </summary>
        /// <param name="element">Elemento a analizar</param>
        public static void informacion(this Element element)
        {
            element.Informacion = (decimal) Math.Log(1.0 / (double) element.Probabilidad, 2);
        }

        /// <summary>
        ///     Metodo para calcular la entropia que proporciona un elemento
        /// </summary>
        /// <param name="element">Elemento a analizar</param>
        /// <returns>Entropia del elemento</returns>
        public static decimal entropia(this Element element)
        {
            element.Entropia = element.Informacion * element.Probabilidad;
            return element.Entropia;
        }
    }
}