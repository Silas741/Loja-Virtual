using Loja.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Dominio.Entidades
{
    public class Pedido
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

        public int FormaPagamentoID { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> pedidos { get; set; }
    }
}