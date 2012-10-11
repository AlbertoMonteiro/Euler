using System;
using System.Linq;
using Euler.Solvers;
using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public class DadoSolverDoProjetoEuler
    {
        [Test]
        public void PossoResolverOProblema001()
        {
            ISolver resolvedorProblema1 = new Problema1();

            Assert.AreEqual(233168, resolvedorProblema1.Solve());
        }

        [Test]
        public void PossoResolverOProblema002()
        {
            ISolver resolvedorProblema2 = new Problema2();

            Assert.AreEqual(4613732, resolvedorProblema2.Solve());
        }

        [Test]
        public void PossoResolverOProblema003()
        {
            ISolver resolvedorProblema3 = new Problema3();

            Assert.AreEqual(6857, resolvedorProblema3.Solve());
        }

        [Test]
        public void PossoResolverOProblema005()
        {
            ISolver resolvedorProblema5 = new Problema5();

            int resultado = Convert.ToInt32(resolvedorProblema5.Solve());

            Assert.AreEqual(232792560, resultado);
        }

        [Test]
        public void PossoResolverOProblema006()
        {
            ISolver problema6 = new Problema6();

            int resultado = Convert.ToInt32(problema6.Solve());

            Assert.AreEqual(25164150, resultado);
        }

        [Test]
        public void PossoResolverOProblema007()
        {
            ISolver problema7 = new Problema7();

            int resultado = Convert.ToInt32(problema7.Solve());

            Assert.AreEqual(104743, resultado);
        }

        [Test, Ignore]
        public void PossoResolverOProblema008()
        {
            ISolver problema8 = new Problema8();

            int resultado = Convert.ToInt32(problema8.Solve());

            Assert.AreEqual(104743, resultado);
        }

        [Test]
        public void PossoResolverOProblema011()
        {
            ISolver problema11 = new Problema11();

            int resultado = Convert.ToInt32(problema11.Solve());

            Assert.AreEqual(70600674, resultado);
        }

        [Test]
        public void PossoResolverOProblema012()
        {
            ISolver problema12 = new Problema12();

            int resultado = Convert.ToInt32(problema12.Solve());

            Assert.AreEqual(76576500, resultado);
        }

        [Test]
        public void PossoResolverOProblema014()
        {
            ISolver problema14 = new Problema14();

            int resultado = Convert.ToInt32(problema14.Solve());

            Assert.AreEqual(837799, resultado);
        }

        [Test]
        public void PossoResolverOProblema015()
        {
            ISolver problema15 = new Problema15(2);

            int resultado = Convert.ToInt32(problema15.Solve());

            Assert.AreEqual(6, resultado);
        }

        [Test]
        public void PossoResolverOProblema017()
        {
            ISolver problema17 = new Problema17();

            int resultado = Convert.ToInt32(problema17.Solve());

            Assert.AreEqual(21124, resultado);
        }

        [Test]
        public void PossoResolverOProblema019()
        {
            ISolver problema19 = new Problema19();

            int resultado = Convert.ToInt32(problema19.Solve());

            Assert.AreEqual(171, resultado);
        }

        [Test]
        public void PossoResolverOProblema020()
        {
            ISolver problema20 = new Problema20();

            int resultado = Convert.ToInt32(problema20.Solve());

            Assert.AreEqual(648, resultado);
        }

        [Test]
        public void PossoResolverOProblema021()
        {
            ISolver problema21 = new Problema21(1, 10000 - 1);

            int resultado = Convert.ToInt32(problema21.Solve());

            Assert.AreEqual(31626, resultado);
        }

        [Test]
        public void PossoResolverOProblema022()
        {
            ISolver problema22 = new Problema22();

            int resultado = Convert.ToInt32(problema22.Solve());

            Assert.AreEqual(871198282, resultado);
        }
    }
}
