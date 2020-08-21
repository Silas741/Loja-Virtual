using Loja.Dominio.Entidades;
using Loja.Dominio.ObjetoValor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Repositorios.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> Itens { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

    }
}
