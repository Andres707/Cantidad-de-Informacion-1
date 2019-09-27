namespace Cantidad_de_Informacion
{
    /// <summary>
    ///     Definicion de la clase Element para la Cantidad de Informacion
    /// </summary>
    internal class Element
    {
        // Representa el caracter del analisis de la Cantidad de Informacion
        public char Caracter { get; set; }

        // Representa el numero de ocurrencias que tiene el caracter.
        public int Ocurrencias { get; set; }

        // Representa la probabilidad del caracter dentro del sistema
        public decimal Probabilidad { get; set; }

        // Representa la cantidad de informacion que aporta al sistema
        public decimal Informacion { get; set; }

        // Representa la entropia que genera dentro del sistema
        public decimal Entropia { get; set; }

        /// <summary>
        /// Define el constructor de un elemento inicial
        /// </summary>
        /// <param name="caracter">Caracter que sera guardado</param>
        public Element(char caracter)
        {
            Caracter = caracter;
            Ocurrencias = 1;
        }
    }
}