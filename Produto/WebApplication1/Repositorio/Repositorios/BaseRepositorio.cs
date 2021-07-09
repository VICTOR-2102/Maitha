using Dominio.Interfaces;
using Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Repositorios
{

    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly ProdutoContexto ProdutoContexto;
        public BaseRepositorio(ProdutoContexto produtoContexto)
        {
            produtoContexto = produtoContexto;
        }

        public TEntity ObterPorId(int id)
        {
            return ProdutoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ProdutoContexto.Set<TEntity>().ToList();
        }

        public void Adicionar(TEntity entity)
        {
            ProdutoContexto.Set<TEntity>().Add(entity);
            ProdutoContexto.SaveChanges();
        }
        public void Atualizar(TEntity entity)
        {
            ProdutoContexto.Set<TEntity>().Update(entity);
            ProdutoContexto.SaveChanges();
        }

        public void Remover(TEntity entity)
        {
            ProdutoContexto.Remove(entity);
            ProdutoContexto.SaveChanges();
        }

        public void Dispose()
        {
            ProdutoContexto.Dispose();
        }


    }
}
