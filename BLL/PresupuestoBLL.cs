using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entidades;
using System.Linq.Expressions;

namespace BLL
{
    public class PresupuestoBLL
    {
        public static bool Guardar(Presupuesto presupuesto)
        {
            using (var reposi = new Repositorio<Presupuesto>())
            {
                try
                {
                    if (Buscar(a => a.IdPresupuesto == presupuesto.IdPresupuesto) == null)
                    {
                        return reposi.Guardar(presupuesto);
                    }
                    else
                    {
                        return reposi.Modificar(presupuesto);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Presupuesto presupuesto)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Presupuesto>())
            {
                modifica = reposi.Modificar(presupuesto);
            }

            return modifica;
        }

        public static bool Eliminar(Presupuesto presupuesto)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Presupuesto>())
            {
                eliminado = reposi.Eliminar(presupuesto);
            }
            return eliminado;
        }

        public static Presupuesto Buscar(Expression<Func<Entidades.Presupuesto, bool>> Busqueda)
        {
            Presupuesto Result = null;
            using (var repoitorio = new Repositorio<Presupuesto>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Presupuesto> Listar(Expression<Func<Presupuesto, bool>> busqueda)
        {
            List<Presupuesto> Result = null;
            using (var repoitorio = new Repositorio<Presupuesto>())
            {
                try
                {
                    Result = repoitorio.Lista(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Presupuesto> ListarTodo()
        {
            List<Presupuesto> Result = null;
            using (var repoitorio = new Repositorio<Presupuesto>())
            {
                try
                {
                    Result = repoitorio.ListaGet().ToList();
                }
                catch { }
                return Result;
            }
        }

    }
}

    }
}
