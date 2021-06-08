using System;
using System.Collections.Generic;

namespace Examen3EV_NS
{
    /// <summary>
    /// Clase que calcula las estadísticas de un conjunto de notas
    /// </summary>
    public class EstadisticasNotasMJGP2021 
    {
        private int suspensos;
        private int aprobados;
        private int notables;
        private int sobresalientes;

        private double media;

        public int Suspensos { get => suspensos; set => suspensos = value; }
        public int Aprobados { get => aprobados; set => aprobados = value; }
        public int Notables { get => notables; set => notables = value; }
        public int Sobresalientes { get => sobresalientes; set => sobresalientes = value; }
        public double Media { get => media; set => media = value; }

        /// <summary>
        /// Constructor sin parámetros.
        /// Los miembros se inicializan a 0.
        /// </summary>
        public EstadisticasNotasMJGP2021()
        {
            suspensos = aprobados = notables = sobresalientes = 0;
            media = 0.0;
        }

        /// <summary>
        /// Constructor con parámetros.
        /// Calcula las estadísticas al crear el objeto.
        /// </summary>
        /// <remarks>Este cálculo se realiza utilizando el método: calcEst, que valida los datos de la lista.</remarks>
        /// <param name="listaNotas">Lista de tipo entero</param>
        public EstadisticasNotasMJGP2021(List<int> listaNotas)
        {
            media = CalculaEstadisticas(listaNotas);
        }

        /// <summary>
        /// Método que calcula las estadísticas, nota media
        /// y el número de suspensos/aprobados/notables/sobresalientes
        /// </summary>
        /// <remarks>Valida que la lista no esté vacía y que los enteros estén entr 1 y 10.</remarks>
        /// <param name="listaNotas">Lista de valores enteros.</param>
        /// <returns>Si falla devuelve -1, en caso contrario devuelve la media.</returns>
        public double CalculaEstadisticas(List<int> listaNotas)
        {
            media = 0.0;

            try
            {
                // TODO: hay que modificar el tratamiento de errores para generar excepciones
                if (listaNotas.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                    return -1;

                for (int i = 0; i < 10; i++)
                    if (listaNotas[i] < 0 || listaNotas[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                        return -1;

                for (int i = 0; i < listaNotas.Count; i++)
                {
                    if (listaNotas[i] < 5) suspensos++;              // Por debajo de 5 suspenso
                    else if (listaNotas[i] >= 5 && listaNotas[i] < 7) aprobados++;// Nota para aprobar: 5
                    else if (listaNotas[i] >= 7 && listaNotas[i] < 9) notables++;// Nota para notable: 7
                    else if (listaNotas[i] > 9) sobresalientes++;         // Nota para sobresaliente: 9

                    media = media + listaNotas[i];
                }

                media = media / listaNotas.Count;
            }
            catch (Exception error)
            {
                throw;
            }

            return media;
        }
    }
}
