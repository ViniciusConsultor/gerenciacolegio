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
    public partial class telaLogin : Form
    {
        private static telaLogin telalogin;

        public static telaLogin getInstancia()
        {
            if (telalogin == null)
            {
                telalogin = new telaLogin();
            }
            return telalogin;
        }

        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            #region Validação dos campos de login e senha

            try
            {
                lblErro.Visible = false;

                if (String.IsNullOrEmpty(txtLogin.Text))
                {
                    txtLogin.BackColor = System.Drawing.Color.LawnGreen;
                    throw new Exception("Favor digitar um login. O campo não pode estar vazio!");
                }
                else if (txtLogin.Text.Length < 8 || txtLogin.Text.Length > 20)
                {
                    txtLogin.BackColor = System.Drawing.Color.LawnGreen;
                    throw new Exception("O login deve conter entre 8 e 20 dígitos.");
                }
                else
                {
                    if(String.IsNullOrEmpty(txtSenha.Text))
                    {
                        txtSenha.BackColor = System.Drawing.Color.LawnGreen;
                        throw new Exception("Favor digitar uma senha. O campo não pode estar vazio!");
                    }
                    else if (txtSenha.Text.Length < 8 || txtSenha.Text.Length > 20)
                    {
                        txtSenha.BackColor = System.Drawing.Color.LawnGreen;
                        throw new Exception("O login deve conter entre 8 e 20 dígitos.");
                    }
                    else
                    {
                        telaAlunoPrincipal telaAlunoPrincipal = telaAlunoPrincipal.getInstancia();
                        telaAlunoPrincipal.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message; 
            }

            #endregion
        }


        #region Métodos que controlam a mudança de cor dos campos quando selecionados ou não

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        #endregion
    }
}
