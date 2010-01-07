using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavelAluno.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloResponsavelAluno.Repositorios
{
    public class ResponsavelAlunoRepositorio : IResponsavelAlunoRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region M�todos da Interface

        public List<ResponsavelAluno> Consultar()
        {
            return db.ResponsavelAluno.ToList();
        }

        public List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno, TipoPesquisa tipoPesquisa)
        {
            List<ResponsavelAluno> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (responsavelAluno.AlunoID != 0)
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.AlunoID == responsavelAluno.AlunoID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResponsavelID != 0)
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.ResponsavelID == responsavelAluno.ResponsavelID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.GrauParentescoID != 0)
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.GrauParentescoID == responsavelAluno.GrauParentescoID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavelAluno.Restricoes))
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.Restricoes.Contains(responsavelAluno.Restricoes)
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Status.HasValue)
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.Status.HasValue && ra.Status.Value == responsavelAluno.Status.Value
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResideCom.HasValue)
                        {
                            resultado.AddRange((from ra in resultado
                                                where
                                                ra.ResideCom.HasValue && ra.ResideCom.Value == responsavelAluno.ResideCom.Value
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (responsavelAluno.AlunoID != 0)
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.AlunoID == responsavelAluno.AlunoID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResponsavelID != 0)
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.ResponsavelID == responsavelAluno.ResponsavelID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.GrauParentescoID != 0)
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.GrauParentescoID == responsavelAluno.GrauParentescoID
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavelAluno.Restricoes))
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Restricoes.Contains(responsavelAluno.Restricoes)
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Status.HasValue)
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Status.HasValue && ra.Status.Value == responsavelAluno.Status.Value
                                                select ra).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResideCom.HasValue)
                        {
                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.ResideCom.HasValue && ra.ResideCom.Value == responsavelAluno.ResideCom.Value
                                                select ra).ToList());
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

        public void Incluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                db.ResponsavelAluno.InsertOnSubmit(responsavelAluno);
            }
            catch (Exception)
            {
                
                throw new ResponsavelAlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                ResponsavelAluno responsavelAlunoAux = new ResponsavelAluno();
                responsavelAlunoAux.AlunoID = responsavelAluno.AlunoID;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;

                List<ResponsavelAluno> resultado = this.Consultar(responsavelAlunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelAlunoNaoExcluidoExcecao();

                responsavelAlunoAux = resultado[0];

                db.ResponsavelAluno.DeleteOnSubmit(responsavelAlunoAux);
            }
            catch (Exception)
            {
                
               throw new ResponsavelAlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(ResponsavelAluno responsavelAluno)
        {
            try
            {
                ResponsavelAluno responsavelAlunoAux = new ResponsavelAluno();
                responsavelAlunoAux.AlunoID = responsavelAluno.AlunoID;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;

                List<ResponsavelAluno> resultado = this.Consultar(responsavelAlunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelAlunoNaoAlteradoExcecao();

                responsavelAlunoAux = resultado[0];

                responsavelAlunoAux.AlunoID = responsavelAluno.AlunoID;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;
                responsavelAlunoAux.GrauParentescoID = responsavelAluno.GrauParentescoID;
                responsavelAlunoAux.ResideCom = responsavelAluno.ResideCom;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;
                responsavelAlunoAux.Restricoes = responsavelAluno.Restricoes;
                responsavelAlunoAux.Status = responsavelAluno.Status;

            }
            catch (Exception)
            {
                
                 throw new ResponsavelAlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion




    }
}