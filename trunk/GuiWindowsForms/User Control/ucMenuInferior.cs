﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class ucMenuInferior : UserControl
    {

        //public string TituloCadastrar { get; set; }
        public ucMenuInferior()
        {
            InitializeComponent();
            //TituloCadastrar = "Salvar Informações";
        }
        public Button BotaoCadastrar
        {
            get
            {
                return btnSalvar;
            }

        }

        #region BUTTON VOLTAR

        public delegate void delegateVoltar();
        public event delegateVoltar EventoVoltar;


        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Voltar";
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (EventoVoltar != null)
                EventoVoltar();
        }


        #endregion

        #region BUTTON SALVAR

        public delegate void delegateCadastrar();
        public event delegateCadastrar EventoCadastrar;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (EventoCadastrar != null)
                EventoCadastrar();
        }

        public void exibirMensagem(String texto)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = texto;
        }

        public void ocultarMensagem()
        {
            lblInfoControles.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Salvar Informações";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        #endregion

        #region BUTTON ALTERAR

        public delegate void delegateAlterar();
        public event delegateAlterar EventoAlterar;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (EventoAlterar != null)
                EventoAlterar();
        }

        public void exibirBotaoAlterar()
        {
            btnAlterar.Visible = true;
        }

        #endregion

        #region BUTTON INCLUIR

        public delegate void delegateIncluir();
        public event delegateIncluir EventoIncluir;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (EventoIncluir != null)
                EventoIncluir();
        }

        public void exibirBotaoIncluir()
        {
            btnIncluir.Visible = true;
        }

        #endregion

        #region BUTTON EXCLUIR

        public delegate void delegateDeletar();
        public event delegateDeletar EventoDeletar;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (EventoDeletar != null)
                EventoDeletar();
        }

        public void exibirBotaoDeletar()
        {
            btnExcluir.Visible = true;
        }

        #endregion

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void btnIncluir_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Alterar Informações";
        }

        private void btnIncluir_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Cadastrar";
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Excluir";
        }
    }
}
