using MediatR;
using MyWallet.Domain.Commands.Lancamento;
using MyWallet.Domain.Interfaces.Repositories;
using MyWallet.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Handlers
{
    public class AtualizarLancamentoHandle : IRequestHandler<AtualizarLancamentoRequest, string>
    {
        ILancamentoRepository _repository;

        public AtualizarLancamentoHandle(ILancamentoRepository repository)
        {
            _repository = repository;
        }

        public Task<string> Handle(AtualizarLancamentoRequest request, CancellationToken cancellationToken)
        {
            var lancamento = _repository.GetById(request.Id);


            var tipo = EnumHelper.ToEnum<EnumTipoLancamento>(request.Tipo);

            var repeticao = EnumHelper.ToEnum<EnumRepeticaoLancamento>(request.Repeticao);

            lancamento.AtualizarDadosDoLancamento(tipo, request.Vencimento, request.Valor, repeticao, request.Descricao                
                );

            //_repository.Save(lancamento);

            return Task.FromResult("Lançamento atualizado.");
        }
    }
}
