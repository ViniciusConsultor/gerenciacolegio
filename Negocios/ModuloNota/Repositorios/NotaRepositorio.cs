using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloNota.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloNota.Repositorios
{
    public class NotaRepositorio : INotaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region M�todos da Interface

        public List<Nota> Consultar()
        {
            return db.Nota.ToList();
        }

        public List<Nota> Consultar(Nota nota, TipoPesquisa tipoPesquisa)
        {
            List<Nota> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (nota.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.ID == nota.ID
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.ID == nota.ID
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }



                        if (nota.Aprovado.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.ProfessorDisciplinaSalaID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Rec.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.RecFinal.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vp.HasValue)
                        {
                            if (pesquisa)
                            {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                                select d).ToList());
                            }else{resultado=((from d in resultado
                                                where
                                                d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                                select d).ToList());}
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc1 <= 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.Vc1 == nota.Vc1
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.Vc1 == nota.Vc1
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc2 <= 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.Vc2 == nota.Vc2
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.Vc2 == nota.Vc2
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in resultado
                                                    where
                                                    d.Status.HasValue && d.Status.Value == nota.Status.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado=((from d in resultado
                                                    where
                                                    d.Status.HasValue && d.Status.Value == nota.Status.Value
                                                    select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (nota.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.ID == nota.ID
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.ID == nota.ID
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }



                        if (nota.Aprovado.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.ProfessorDisciplinaSalaID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Rec.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.RecFinal.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vp.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc1 <= 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Vc1 == nota.Vc1
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                             where
                                             d.Vc1 == nota.Vc1
                                             select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc2 <= 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Vc2 == nota.Vc2
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.Vc2 == nota.Vc2
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from d in Consultar()
                                                    where
                                                    d.Status.HasValue && d.Status.Value == nota.Status.Value
                                                    select d).ToList());
                            }
                            else
                            {
                                resultado = ((from d in Consultar()
                                              where
                                              d.Status.HasValue && d.Status.Value == nota.Status.Value
                                              select d).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                default:
                    break;
            }

            return resultado;
        }

        public void Incluir(Nota nota)
        {
            try
            {
                db.Nota.InsertOnSubmit(nota);
            }
            catch (Exception)
            {

                throw new NotaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Nota nota)
        {
            try
            {
                Nota notaAux = new Nota();
                notaAux.ID = nota.ID;

                List<Nota> resultado = this.Consultar(notaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new NotaNaoExcluidaExcecao();

                notaAux = resultado[0];

                db.Nota.DeleteOnSubmit(notaAux);
            }
            catch (Exception)
            {

                throw new NotaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Nota nota)
        {
            try
            {
                Nota notaAux = new Nota();
                notaAux.ID = nota.ID;

                List<Nota> resultado = this.Consultar(notaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new NotaNaoAlteradaExcecao();

                notaAux = resultado[0];

                notaAux.ProfessorDisciplinaSalaID = nota.ProfessorDisciplinaSalaID;
                notaAux.Aprovado = nota.Aprovado;
                notaAux.Rec = nota.Rec;
                notaAux.RecFinal = nota.RecFinal;
                notaAux.Vc1 = nota.Vc1;
                notaAux.Vc2 = nota.Vc2;
                notaAux.Vp = nota.Vp;
                notaAux.Status = nota.Status;
                Confirmar();

            }
            catch (Exception)
            {

                throw new NotaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}