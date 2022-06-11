using MyWallet.Domain.Entities;
using NUnit.Framework;
using System;

namespace MyWallet.Test
{
    public class LancamentoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CriarLancamentoTest()
        {
      
            var l = new Lancamento(Domain.ValueObjects.EnumTipoLancamento.ENTRADA, DateTime.Now, 10000);
            Assert.Pass();
        }

        [Test]
        public void CriarLancamentoComTodosCampos()
        {
            var l = new Lancamento(Domain.ValueObjects.EnumTipoLancamento.SAIDA, 100, DateTime.Now, null, null);
            Assert.Pass();
        }

        [Test]
        public void LancamentoComVencimentoRetroativoTest()
        {
             var l = new Lancamento(Domain.ValueObjects.EnumTipoLancamento.SAIDA, 100, DateTime.Now.AddDays(-1), null, null);
             Assert.Pass();
        }

        


    }
}