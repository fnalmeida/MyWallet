using MediatR;
using MyWallet.Domain.Commands.Lancamento.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Commands.Lancamento
{
    public class CriarLancamentoRequest : CommandBase, IRequest<string> 
    {
        public CriarLancamentoRequest(string tipo, decimal valor, DateTime vencimento, string repeticao, string descricao)
        {
            Tipo = tipo;
            Valor = valor;
            Vencimento = vencimento;
            Repeticao = repeticao;
            Descricao = descricao;
        }

        public string Tipo { get; set; }

        public Decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }

        public string Repeticao { get; set; }

        public string Descricao { get; set; }


        public override bool EhValido()
        {
            AddNotifications(new CriarLancamentoRequestContract(this));
            return this.IsValid;
        }
    }
}
