﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesSerie : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesSerie telaconfiguracoesserie;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesSerie getInstancia()
        {
            if (telaconfiguracoesserie == null)
            {
                telaconfiguracoesserie = new telaConfiguracoesSerie();
            }
            return telaconfiguracoesserie;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesSerie()
        {
            InitializeComponent();
        }

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

            //return SelecionaForm(aux);
        }

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

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaConfiguracoesSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        #region Controle dos textos e das ações dos botões de ação inferiores

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Voltar";
        }

        /// <summary>
        /// Oculta o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Retorna para tela anterior ocultando a atual e chamando a instância da última tela acessada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Salvar Informações";
        }

        #endregion

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Remover Série cadastrada!";
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        private void ucMenuDireita1_EventoAbrirSerie()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesSerie telaconfserie = telaConfiguracoesSerie.getInstancia();
            telaconfserie.Show();
        }

        private void ucMenuDireita1_EventoAbrirAtividade()
        {
            this.Hide();
            Program.ultimaTela = 10;
            ckbTerca telaconfatv = ckbTerca.getInstancia();
            telaconfatv.Show();
        }

        private void ucMenuDireita1_EventoAbrirDesconto()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesDescontoMatricula telaconfdesconto = telaConfiguracoesDescontoMatricula.getInstancia();
            telaconfdesconto.Show();
        }

        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesserie);
        }

        private void ucMenuDireita1_Load(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaconfiguracoesserie);
        }


    }
}