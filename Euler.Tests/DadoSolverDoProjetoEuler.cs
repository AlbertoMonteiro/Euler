using System;
using Euler.Solvers;
using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public class DadoSolverDoProjetoEuler
    {
        [Test]
        public void PossoResolverOProblema1()
        {
            ISolver resolvedorProblema1 = new Problema1();

            Assert.AreEqual(233168, resolvedorProblema1.Solve());
        }

        [Test]
        public void PossoResolverOProblema2()
        {
            ISolver resolvedorProblema2 = new Problema2();

            Assert.AreEqual(4613732, resolvedorProblema2.Solve());
        }

        [Test]
        public void PossoResolverOProblema3()
        {
            ISolver resolvedorProblema3 = new Problema3();

            Assert.AreEqual(6857, resolvedorProblema3.Solve());
        }

        [Test]
        public void PossoResolverOProblema5()
        {
            ISolver resolvedorProblema5 = new Problema5();

            int resultado = Convert.ToInt32(resolvedorProblema5.Solve());

            Assert.AreEqual(232792560, resultado);
        }

        [Test]
        public void PossoResolverOProblema6()
        {
            ISolver problema6 = new Problema6();

            int resultado = Convert.ToInt32(problema6.Solve());

            Assert.AreEqual(25164150, resultado);
        }

        [Test]
        public void PossoResolverOProblema7()
        {
            ISolver problema7 = new Problema7();

            int resultado = Convert.ToInt32(problema7.Solve());

            Assert.AreEqual(104743, resultado);
        }

        [Test, Ignore]
        public void PossoResolverOProblema8()
        {
            ISolver problema8 = new Problema8();

            int resultado = Convert.ToInt32(problema8.Solve());

            Assert.AreEqual(104743, resultado);
        }

        [Test]
        public void PossoResolverOProblema11()
        {
            ISolver problema11 = new Problema11();

            int resultado = Convert.ToInt32(problema11.Solve());

            Assert.AreEqual(70600674, resultado);
        }

        [Test]
        public void PossoResolverOProblema12()
        {
            ISolver problema12 = new Problema12();

            int resultado = Convert.ToInt32(problema12.Solve());

            Assert.Pass(resultado.ToString());
        }
    }
}
