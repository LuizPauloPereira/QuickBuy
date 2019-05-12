using QuickBuy.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        //Endereco de destino
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        //Forma de pagamento
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        /// <summary>
        /// Um Pedido deve ter pelo menos um ItemPedido ou muitos ItensPedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ItensPedido.Any())
                AdicionarCritica("Crítica: Pedido não pode ficar sem item de pedido");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");
        }
    }

}
