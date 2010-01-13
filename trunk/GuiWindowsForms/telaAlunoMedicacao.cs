﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloAluno.Processos;

namespace GuiWindowsForms
{
    public partial class telaAlunoMedicacao : Form
    {
        IAlunoProcesso alunoControlador = AlunoProcesso.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMedicacao telaalunomedicacao;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA ALUNO RESPONSAVEL
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMedicacao getInstancia()
        {
            if (telaalunomedicacao == null)
            {
                telaalunomedicacao = new telaAlunoMedicacao();
            }
            return telaalunomedicacao;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMedicacao()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, avita que a tela seja descarregada da memória
        /// </summary>
        public new void Show()
        {
            if (IsShown)
                base.Show();
            else
            {
                base.Show();
                IsShown = true;
            }

        }
        #endregion

        #region BUTTON DESCONECTAR
        /// <summary>
        /// Botão para esconder a tela e voltar para a tela de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
        #endregion

        #region MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoMedicacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 7)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 7)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }

        #endregion

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        #endregion

        #region USER CONTROLS - Menu Lateral
        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunomedicacao);
        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - NOME

                //if (String.IsNullOrEmpty(txtAlergico.Text))
                //{
                //    errorProviderTela.SetError(txtAlergico, "Informe a alergia");
                //    txtAlergico.Clear();
                //    return;
                //}
                telaAluno.aluno.Alergico = txtAlergico.Text;


                #endregion

                #region VALIDA - FATOR RH

                if (rdbPositivo.Checked == false && rdbNegativo.Checked == false)
                {
                    errorProviderTela.SetError(rdbNegativo, "Informe o fator rh");
                    return;
                }
                if (rdbNegativo.Checked == true)
                {
                    telaAluno.aluno.FatorRh = 0;
                }
                else
                {
                    telaAluno.aluno.FatorRh = 1;
                }

                #endregion

                #region VALIDA - NOME

                //if (String.IsNullOrEmpty(txtNomeMedico.Text))
                //{
                //    errorProviderTela.SetError(txtNomeMedico, "Informe o nome do médico");
                //    txtNomeMedico.Clear();
                //    return;
                //}
                telaAluno.aluno.NomeMedico = txtNomeMedico.Text;

                #endregion

                #region VALIDA - FONE 

                //if (mskFone.MaskCompleted == false)
                //{
                //    errorProviderTela.SetError(mskFone, "Informe o fone");
                //    return;
                //}
                telaAluno.aluno.FoneMedico = mskFone.Text;

                #endregion

                #region VALIDA - HOSPITAL

                //if (String.IsNullOrEmpty(txtHospital.Text))
                //{
                //    errorProviderTela.SetError(txtHospital, "Informe o hospital");
                //    txtHospital.Clear();
                //    return;
                //}
                telaAluno.aluno.Hospital = txtHospital.Text;

                #endregion

                #region VALIDA - PLANO DE SAÚDE

                //if (String.IsNullOrEmpty(txtPlanoSaude.Text))
                //{
                //    errorProviderTela.SetError(txtPlanoSaude, "Informe o plano de saúde");
                //    txtPlanoSaude.Clear();
                //    return;
                //}
                telaAluno.aluno.PlanoSaude = txtPlanoSaude.Text;

                #endregion

                #region VALIDA - DESCRIÇÃO MÉDICA

                //if (String.IsNullOrEmpty(txtDescricaoMedica.Text))
                //{
                //    errorProviderTela.SetError(txtDescricaoMedica, "Informe a descrição médica");
                //    txtDescricaoMedica.Clear();
                //    return;
                //}
                telaAluno.aluno.DescricaoMedica = txtDescricaoMedica.Text;

                #endregion

                #region VALIDA - SITUAÇÃO ESPECIAL

                //if (String.IsNullOrEmpty(txtSituacaoEspecial.Text))
                //{
                //    errorProviderTela.SetError(txtSituacaoEspecial, "Informe a situação especial");
                //    txtSituacaoEspecial.Clear();
                //    return;
                //}
                telaAluno.aluno.SituacaoEspecial = txtSituacaoEspecial.Text;

                #endregion

                telaAluno.aluno.GrupoSanguineo = cmbGrupoSanguineo.Text;

                alunoControlador.Alterar(telaAluno.aluno);
                alunoControlador.Confirmar();
                
            }
            catch (Exception ex)
            { 
            
            }

        }
        #endregion

        #region STRING PARA ALIMENTAR COMBOBOX

        string[] gruposanguineo = { "O", "A", "AB", "B" };

        #endregion

        #region LIMPAR ERRO PROVIDER
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbGrupoSanguineo_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbPositivo_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbNegativo_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtNomeMedico_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFone_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtHospital_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtPlanoSaude_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtDescricaoMedica_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtSituacaoEspecial_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

        #region LOAD
        private void telaAlunoMedicacao_Load(object sender, EventArgs e)
        {
            limparTela();
            cmbGrupoSanguineo.DataSource = gruposanguineo;
            uMenuImagem1.carregaAluno(telaAluno.aluno);
            carregarAlunoMedicacao();
        }
        #endregion

        /// <summary>
        /// Carrega os dados de medicação do aluno.
        /// </summary>
        public void carregarAlunoMedicacao()
        {
            txtAlergico.Text = telaAluno.aluno.Alergico;
            txtDescricaoMedica.Text = telaAluno.aluno.DescricaoMedica;
            txtHospital.Text = telaAluno.aluno.Hospital;
            txtNomeMedico.Text = telaAluno.aluno.NomeMedico;
            txtPlanoSaude.Text = telaAluno.aluno.PlanoSaude;
            txtSituacaoEspecial.Text = telaAluno.aluno.SituacaoEspecial;
            mskFone.Text = telaAluno.aluno.FoneMedico;
            cmbGrupoSanguineo.Text = telaAluno.aluno.GrupoSanguineo;
            if (rdbNegativo.Checked == true)
            {
                rdbNegativo.Select();
            }
            else
            {
                rdbPositivo.Select();
            }
        }

        /// <summary>
        /// Limpa os dados da tela de aluno medicação.
        /// </summary>
        public void limparTela()
        {
            txtAlergico.Clear();
            txtDescricaoMedica.Clear();
            txtHospital.Clear();
            txtNomeMedico.Clear();
            txtPlanoSaude.Clear();
            txtSituacaoEspecial.Clear();
            mskFone.Clear();
            rdbPositivo.Checked = false;
            rdbNegativo.Checked = false;
            cmbGrupoSanguineo.Select();
        }

    }
}