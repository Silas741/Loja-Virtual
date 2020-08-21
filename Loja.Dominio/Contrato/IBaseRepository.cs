using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Dominio.Contrato
{
  public interface IBaseRepository<TEntity> : IDisposable where TEntity :class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);

        void remover(TEntity entity);
    }
}
