using MediatR;
using MyWallet.Domain.Commands.Lancamento;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Handlers
{
    public class CriarLancamentoHandle : IRequestHandler<CriarLancamentoRequest, string>
    {
        ILancamentoRepository _repository;

        public CriarLancamentoHandle(ILancamentoRepository repository)
        {
            _repository = repository;
        }

        public Task<string> Handle(CriarLancamentoRequest request, CancellationToken cancellationToken)
        {
            //var lancamento = new Lancamento()
            //{
            //    Valor = request.Valor,
            //    Descricao = request.Descricao,
            //    //Repeticao = request.Repeticao,
            //    //Tipo = request.Tipo,
            //    Vencimento = request.Vencimento
            //};

            //_repository.Inserir(lancamento);
            //_repository.Save();

            return Task.FromResult("Lançamento inserido.");
        }
    }
}
