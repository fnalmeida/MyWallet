using MediatR;
using MyWallet.Domain.Commands.Lancamento;
using MyWallet.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Handlers
{
    public class ExcluirLancamentoHandle : IRequestHandler<ExcluirLancamentoRequest, string>
    {
        ILancamentoRepository _repository;

        public ExcluirLancamentoHandle(ILancamentoRepository repository)
        {
            _repository = repository;
        }

        public Task<string> Handle(ExcluirLancamentoRequest request, CancellationToken cancellationToken)
        {
            var lancamento = _repository.GetById(request.Id);

            _repository.Excluir(lancamento);

            return Task.FromResult("Lançamento excluído.");
        }
    }
}
