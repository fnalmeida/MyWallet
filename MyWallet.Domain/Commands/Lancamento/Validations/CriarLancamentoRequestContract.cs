using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Commands.Lancamento.Validations
{
    public class CriarLancamentoRequestContract : Contract<CriarLancamentoRequest>
    {
        public CriarLancamentoRequestContract(CriarLancamentoRequest criarLancamentoRequest)
        {
            if (criarLancamentoRequest.Vencimento < DateTime.Now)
                AddNotification("Vencimento", "Data de vencimento inválida");
        }
    }
}
