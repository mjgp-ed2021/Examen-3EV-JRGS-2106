using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaListaValoresCorrectos()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int suspensosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesEsperados = 2;
            int sobresalientesEsperados = 1;

        }

        [TestMethod]
        public void PruebaListaVacia()
        {
            List<int> listaVacia = new List<int>();
            double mediaNotas;

            try
            {
                mediaNotas = CalculaEstadisticas(listaVacia);
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        [TestMethod]
        public void PruebaValoresNegativos()
        {
            List<int> listaNotasMal = new List<int>();
            double mediaNotas;

            listaNotasMal.Add(-1);

            try
            {
                mediaNotas = CalculaEstadisticas(listaNotasMal);
            }
            catch (Exception error )
            {

                throw;
            }
        }

        public void PruebaValorMayor10()
        {
            List<int> listaNotasMal = new List<int>();
            double mediaNotas;

            listaNotasMal.Add(11);

            try
            {
                mediaNotas = CalculaEstadisticas(listaNotasMal);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
