﻿namespace GuiWindowsForms
{
    partial class uMenuImagem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblFoneEmerg = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtivo.ForeColor = System.Drawing.Color.Green;
            this.lblAtivo.Location = new System.Drawing.Point(149, 167);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 19);
            this.lblAtivo.TabIndex = 136;
            this.lblAtivo.Text = "Ativo";
            // 
            // lblFoneEmerg
            // 
            this.lblFoneEmerg.AutoSize = true;
            this.lblFoneEmerg.BackColor = System.Drawing.Color.Transparent;
            this.lblFoneEmerg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFoneEmerg.ForeColor = System.Drawing.Color.Yellow;
            this.lblFoneEmerg.Location = new System.Drawing.Point(149, 134);
            this.lblFoneEmerg.Name = "lblFoneEmerg";
            this.lblFoneEmerg.Size = new System.Drawing.Size(98, 19);
            this.lblFoneEmerg.TabIndex = 135;
            this.lblFoneEmerg.Text = "Fone Emerg";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblResponsavel.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsavel.Location = new System.Drawing.Point(149, 105);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(155, 19);
            this.lblResponsavel.TabIndex = 134;
            this.lblResponsavel.Text = "Nome Responsável";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(149, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 133;
            this.label2.Text = "Série";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.Color.Yellow;
            this.lblMatricula.Location = new System.Drawing.Point(149, 46);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(80, 19);
            this.lblMatricula.TabIndex = 132;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeAluno.Location = new System.Drawing.Point(149, 13);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(124, 19);
            this.lblNomeAluno.TabIndex = 131;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(3, 13);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 130;
            this.pctImagem.TabStop = false;
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarImagem.BackgroundImage = global::GuiWindowsForms.Properties.Resources.adicionar_final_32x32;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(45, 153);
            this.btnAdicionarImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(34, 34);
            this.btnAdicionarImagem.TabIndex = 129;
            this.btnAdicionarImagem.Tag = "";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // uMenuImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.lblFoneEmerg);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Name = "uMenuImagem";
            this.Size = new System.Drawing.Size(438, 201);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblFoneEmerg;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Button btnAdicionarImagem;
    }
}
