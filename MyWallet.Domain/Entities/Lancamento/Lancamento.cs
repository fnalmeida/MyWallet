using MyWallet.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace MyWallet.Domain.Entities
{
    public class Lancamento : Entity
    {
        public Lancamento(EnumTipoLancamento tipo,
                          DateTime vencimento,
                          Decimal valor)
        {
            Tipo = Tipo;
            Vencimento = vencimento;
            Valor = valor;
        }

        public Lancamento(EnumTipoLancamento Tipo,
                          Decimal Valor,
                          DateTime Vencimento,
                          EnumRepeticaoLancamento? Repeticao,
                          string? Descricao)
        {
        }

        #region Propriedades

        [Required]
        public EnumTipoLancamento Tipo { get; private set; }

        [Required]
        public decimal Valor { get; private set; }

        [Required]
        public DateTime Vencimento { get; private set; }

        public EnumRepeticaoLancamento? Repeticao { get; private set; }

        public string? Descricao { get; private set; }

        public bool Concluido { get; private set; }

        #endregion


        #region Metodos

        public void RepetirLancamento(EnumRepeticaoLancamento repeticaoLancamento)
        {
            Repeticao = repeticaoLancamento;
        }

        public void InserirDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void ConcluirLancamento(bool concluir)        
        {
            Concluido = concluir;
        }
        
        public void AtualizarDadosDoLancamento(EnumTipoLancamento? tipo, DateTime vencimento, decimal valor, EnumRepeticaoLancamento? repeticao, string? descricao)
        {
            Tipo = Tipo;
            Vencimento = vencimento;
            Valor = valor;
            repeticao = repeticao;
            Descricao = descricao;
        }

        #endregion



    }
}