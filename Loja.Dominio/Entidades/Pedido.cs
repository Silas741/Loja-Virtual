using Loja.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereço { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagem();
            if (!pedidos.Any()) {
                AdicionarCritica("Critica - Pedido não pode ficar sem item de pedido");
                
            }
            if (string.IsNullOrEmpty(Cep)) {
                AdicionarCritica("Critica - Cep deve estar preenchido ");
            }
            if (FormaPagamentoId == 0) {
                AdicionarCritica("Critica - Não foi informado um método de pagamento");
            }
        }
    }
}