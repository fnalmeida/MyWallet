using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Commands.Lancamento
{
    public class ExcluirLancamentoRequest : IRequest<string>
    {
        public Guid Id;
    }
}
