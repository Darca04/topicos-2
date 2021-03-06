﻿
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestsSumas
    {
        [TestMethod]
        public void UnoMasCuatro()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("1", 10);
            Numero elSegundoOperando = new Numero("4", 10);
            Numero elResultadoEsperado = new Numero("5", 10);
            Numero elResultadoReal;

            //invoque al metodo que se prueba
            var laReferecia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferecia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que el esperado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);

        }

        [TestMethod]
        public void SumaConDecimales()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("1.3", 10);
            Numero elSegundoOperando = new Numero("-9.5", 10);
            Numero elResultadoEsperado = new Numero("-8.2", 10);
            Numero elResultadoReal;

            //invoque al metodo que se prueba
            var laReferecia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferecia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que el esperado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);

        }
    }
}
