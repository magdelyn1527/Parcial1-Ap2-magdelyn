﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DAL
{
    public class Repositorio<TEntity> : CRepositorio<TEntity> where TEntity : class
    {
        SistemaPresupuestoDB Contex = null;
        public Repositorio()
        {
            Contex = new SistemaPresupuestoDB();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Contex.Set<TEntity>();
            }
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> Busqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(Busqueda);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(TEntity Entidad)
        {
            try
            {
                EntitySet.Add(Entidad);
                Contex.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }


            //return false;
        }

        public bool Modificar(TEntity Entidad)
        {
            bool Resultado = false;

            try
            {
                EntitySet.Attach(Entidad);
                Contex.Entry<TEntity>(Entidad).State = EntityState.Modified;
                Resultado = Contex.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return Resultado;
        }

        public bool Eliminar(TEntity Entidad)
        {
            bool Resultado = false;

            try
            {
                EntitySet.Attach(Entidad);
                EntitySet.Remove(Entidad);
                Resultado = Contex.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return Resultado;
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> Busqueda)
        {
            List<TEntity> Resultado = null;

            try
            {
                Resultado = EntitySet.Where(Busqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Resultado;
        }

        public List<TEntity> ListaGet()
        {
            using (var Conex = new SistemaPresupuestoDB())
            {
                try
                {
                    return EntitySet.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }

        TEntity CRepositorio<TEntity>.Guardar(TEntity Entidad)
        {
            throw new NotImplementedException();
        }
    }
}

    {
    }
}
