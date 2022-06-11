using MyWallet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Interfaces.Repositories
{
    public interface ILancamentoRepository
    {
        void Inserir(Lancamento lancamento);
        void Save();
        void Atualizar(Lancamento lancamento);
        void Excluir(Lancamento lancamento);
        Lancamento GetById(Guid id);
    }
}
