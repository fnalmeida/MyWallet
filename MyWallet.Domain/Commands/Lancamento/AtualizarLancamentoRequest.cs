using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Commands.Lancamento
{
    public class AtualizarLancamentoRequest : CommandBase, IRequest<string>
    {
        public Guid Id { get; set; }

        public string Tipo { get; set; }

        public Decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }

        public string Repeticao { get; set; }

        public string Descricao { get; set; }

        public AtualizarLancamentoRequest(Guid id, string tipo, decimal valor, DateTime vencimento, string repeticao, string descricao)
        {
            Id = id;
            Tipo = tipo;
            Valor = valor;
            Vencimento = vencimento;
            Repeticao = repeticao;
            Descricao = descricao;
        }

        public override bool EhValido()
        {
            return base.EhValido();
        }
    }
}
