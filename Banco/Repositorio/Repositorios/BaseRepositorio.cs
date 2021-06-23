﻿using Domínio.Interfaces;
using Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly BancoContexto BancoContexto;
        public BaseRepositorio(BancoContexto bancoContexto)
        {
            BancoContexto = bancoContexto;
        }

        public TEntity ObterPorId(int id)
        {
            return BancoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return BancoContexto.Set<TEntity>().ToList();
        }

        public void Adicionar(TEntity entity)
        {
            BancoContexto.Set<TEntity>().Add(entity);
            BancoContexto.SaveChanges();
        }
        public void Atualizar(TEntity entity)
        {
            BancoContexto.Set<TEntity>().Update(entity);
            BancoContexto.SaveChanges();
        }

        public void Remover(TEntity entity)
        {
            BancoContexto.Remove(entity);
            BancoContexto.SaveChanges();
        }

        public void Dispose()
        {
            BancoContexto.Dispose();
        }


    }
}
