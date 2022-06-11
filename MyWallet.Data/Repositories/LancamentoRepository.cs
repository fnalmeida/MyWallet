using Data.DBContext;
using MyWallet.Domain;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class LancamentoRepository : ILancamentoRepository, IDisposable
    {

        AppDBContext _context;

        public LancamentoRepository(AppDBContext context)
        {
            _context = context;
        }

        public void Inserir(Lancamento lancamento)
        {
            _context.Lancamentos.Add(lancamento);
        }

        public void Atualizar(Lancamento lancamento)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Lancamento lancamento)
        {
            throw new NotImplementedException();
        }

        public Lancamento GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
