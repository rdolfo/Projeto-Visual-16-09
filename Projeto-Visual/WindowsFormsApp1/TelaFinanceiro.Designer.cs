namespace WindowsFormsApp1
{
    partial class TelaFinanceiro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFinanceiro = new System.Windows.Forms.Panel();
            this.rotuloFinanceiro = new System.Windows.Forms.Label();
            this.rotuloCodAluno = new System.Windows.Forms.Label();
            this.campoCodAluno = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBoxSituacao = new System.Windows.Forms.GroupBox();
            this.radioButtonAtrasado = new System.Windows.Forms.RadioButton();
            this.radioButtonEmDia = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBoxMensalidades = new System.Windows.Forms.GroupBox();
            this.checkBoxDezembro = new System.Windows.Forms.CheckBox();
            this.checkBoxNovembro = new System.Windows.Forms.CheckBox();
            this.checkBoxOutubro = new System.Windows.Forms.CheckBox();
            this.checkBoxSetembro = new System.Windows.Forms.CheckBox();
            this.checkBoxAgosto = new System.Windows.Forms.CheckBox();
            this.checkBoxJulho = new System.Windows.Forms.CheckBox();
            this.checkBoxJunho = new System.Windows.Forms.CheckBox();
            this.checkBoxMaio = new System.Windows.Forms.CheckBox();
            this.checkBoxAbril = new System.Windows.Forms.CheckBox();
            this.checkBoxMarco = new System.Windows.Forms.CheckBox();
            this.checkBoxFevereiro = new System.Windows.Forms.CheckBox();
            this.checkBoxJaneiro = new System.Windows.Forms.CheckBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panelFinanceiro.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxSituacao.SuspendLayout();
            this.groupBoxMensalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFinanceiro
            // 
            this.panelFinanceiro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFinanceiro.Controls.Add(this.rotuloFinanceiro);
            this.panelFinanceiro.Location = new System.Drawing.Point(2, 3);
            this.panelFinanceiro.Name = "panelFinanceiro";
            this.panelFinanceiro.Size = new System.Drawing.Size(794, 104);
            this.panelFinanceiro.TabIndex = 0;
            // 
            // rotuloFinanceiro
            // 
            this.rotuloFinanceiro.AutoSize = true;
            this.rotuloFinanceiro.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloFinanceiro.Location = new System.Drawing.Point(10, 22);
            this.rotuloFinanceiro.Name = "rotuloFinanceiro";
            this.rotuloFinanceiro.Size = new System.Drawing.Size(266, 56);
            this.rotuloFinanceiro.TabIndex = 0;
            this.rotuloFinanceiro.Text = "Financeiro";
            // 
            // rotuloCodAluno
            // 
            this.rotuloCodAluno.AutoSize = true;
            this.rotuloCodAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCodAluno.Location = new System.Drawing.Point(14, 19);
            this.rotuloCodAluno.Name = "rotuloCodAluno";
            this.rotuloCodAluno.Size = new System.Drawing.Size(86, 16);
            this.rotuloCodAluno.TabIndex = 1;
            this.rotuloCodAluno.Text = "Cód. Aluno:";
            // 
            // campoCodAluno
            // 
            this.campoCodAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodAluno.Location = new System.Drawing.Point(106, 16);
            this.campoCodAluno.Name = "campoCodAluno";
            this.campoCodAluno.Size = new System.Drawing.Size(140, 22);
            this.campoCodAluno.TabIndex = 2;
            this.campoCodAluno.Enter += new System.EventHandler(this.campoCodAluno_Enter);
            this.campoCodAluno.Leave += new System.EventHandler(this.campoCodAluno_Leave);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPrincipal.Controls.Add(this.groupBoxSituacao);
            this.panelPrincipal.Controls.Add(this.btnVoltar);
            this.panelPrincipal.Controls.Add(this.groupBoxMensalidades);
            this.panelPrincipal.Controls.Add(this.campoNome);
            this.panelPrincipal.Controls.Add(this.labelNome);
            this.panelPrincipal.Controls.Add(this.btnPesquisar);
            this.panelPrincipal.Controls.Add(this.rotuloCodAluno);
            this.panelPrincipal.Controls.Add(this.campoCodAluno);
            this.panelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(2, 113);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(794, 447);
            this.panelPrincipal.TabIndex = 3;
            // 
            // groupBoxSituacao
            // 
            this.groupBoxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxSituacao.Controls.Add(this.radioButtonAtrasado);
            this.groupBoxSituacao.Controls.Add(this.radioButtonEmDia);
            this.groupBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSituacao.Location = new System.Drawing.Point(17, 177);
            this.groupBoxSituacao.Name = "groupBoxSituacao";
            this.groupBoxSituacao.Size = new System.Drawing.Size(200, 87);
            this.groupBoxSituacao.TabIndex = 8;
            this.groupBoxSituacao.TabStop = false;
            this.groupBoxSituacao.Text = "Situação do Aluno:";
            // 
            // radioButtonAtrasado
            // 
            this.radioButtonAtrasado.AutoSize = true;
            this.radioButtonAtrasado.Location = new System.Drawing.Point(10, 47);
            this.radioButtonAtrasado.Name = "radioButtonAtrasado";
            this.radioButtonAtrasado.Size = new System.Drawing.Size(88, 20);
            this.radioButtonAtrasado.TabIndex = 1;
            this.radioButtonAtrasado.TabStop = true;
            this.radioButtonAtrasado.Text = "Atrasado";
            this.radioButtonAtrasado.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmDia
            // 
            this.radioButtonEmDia.AutoSize = true;
            this.radioButtonEmDia.Location = new System.Drawing.Point(10, 21);
            this.radioButtonEmDia.Name = "radioButtonEmDia";
            this.radioButtonEmDia.Size = new System.Drawing.Size(75, 20);
            this.radioButtonEmDia.TabIndex = 0;
            this.radioButtonEmDia.TabStop = true;
            this.radioButtonEmDia.Text = "Em Dia";
            this.radioButtonEmDia.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(711, 416);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBoxMensalidades
            // 
            this.groupBoxMensalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBoxMensalidades.Controls.Add(this.checkBoxDezembro);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxNovembro);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxOutubro);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxSetembro);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxAgosto);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxJulho);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxJunho);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxMaio);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxAbril);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxMarco);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxFevereiro);
            this.groupBoxMensalidades.Controls.Add(this.checkBoxJaneiro);
            this.groupBoxMensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMensalidades.Location = new System.Drawing.Point(17, 59);
            this.groupBoxMensalidades.Name = "groupBoxMensalidades";
            this.groupBoxMensalidades.Size = new System.Drawing.Size(769, 112);
            this.groupBoxMensalidades.TabIndex = 6;
            this.groupBoxMensalidades.TabStop = false;
            this.groupBoxMensalidades.Text = "Mensalidades";
            // 
            // checkBoxDezembro
            // 
            this.checkBoxDezembro.AutoSize = true;
            this.checkBoxDezembro.Location = new System.Drawing.Point(521, 74);
            this.checkBoxDezembro.Name = "checkBoxDezembro";
            this.checkBoxDezembro.Size = new System.Drawing.Size(97, 20);
            this.checkBoxDezembro.TabIndex = 18;
            this.checkBoxDezembro.Text = "Dezembro";
            this.checkBoxDezembro.UseVisualStyleBackColor = true;
            this.checkBoxDezembro.CheckedChanged += new System.EventHandler(this.checkBoxDezembro_CheckedChanged);
            // 
            // checkBoxNovembro
            // 
            this.checkBoxNovembro.AutoSize = true;
            this.checkBoxNovembro.Location = new System.Drawing.Point(521, 47);
            this.checkBoxNovembro.Name = "checkBoxNovembro";
            this.checkBoxNovembro.Size = new System.Drawing.Size(98, 20);
            this.checkBoxNovembro.TabIndex = 17;
            this.checkBoxNovembro.Text = "Novembro";
            this.checkBoxNovembro.UseVisualStyleBackColor = true;
            this.checkBoxNovembro.CheckedChanged += new System.EventHandler(this.checkBoxNovembro_CheckedChanged);
            // 
            // checkBoxOutubro
            // 
            this.checkBoxOutubro.AutoSize = true;
            this.checkBoxOutubro.Location = new System.Drawing.Point(521, 21);
            this.checkBoxOutubro.Name = "checkBoxOutubro";
            this.checkBoxOutubro.Size = new System.Drawing.Size(80, 20);
            this.checkBoxOutubro.TabIndex = 16;
            this.checkBoxOutubro.Text = "Outubro";
            this.checkBoxOutubro.UseVisualStyleBackColor = true;
            this.checkBoxOutubro.CheckedChanged += new System.EventHandler(this.checkBoxOutubro_CheckedChanged);
            // 
            // checkBoxSetembro
            // 
            this.checkBoxSetembro.AutoSize = true;
            this.checkBoxSetembro.Location = new System.Drawing.Point(332, 74);
            this.checkBoxSetembro.Name = "checkBoxSetembro";
            this.checkBoxSetembro.Size = new System.Drawing.Size(93, 20);
            this.checkBoxSetembro.TabIndex = 15;
            this.checkBoxSetembro.Text = "Setembro";
            this.checkBoxSetembro.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgosto
            // 
            this.checkBoxAgosto.AutoSize = true;
            this.checkBoxAgosto.Location = new System.Drawing.Point(332, 48);
            this.checkBoxAgosto.Name = "checkBoxAgosto";
            this.checkBoxAgosto.Size = new System.Drawing.Size(75, 20);
            this.checkBoxAgosto.TabIndex = 14;
            this.checkBoxAgosto.Text = "Agosto";
            this.checkBoxAgosto.UseVisualStyleBackColor = true;
            // 
            // checkBoxJulho
            // 
            this.checkBoxJulho.AutoSize = true;
            this.checkBoxJulho.Location = new System.Drawing.Point(332, 21);
            this.checkBoxJulho.Name = "checkBoxJulho";
            this.checkBoxJulho.Size = new System.Drawing.Size(63, 20);
            this.checkBoxJulho.TabIndex = 13;
            this.checkBoxJulho.Text = "Julho";
            this.checkBoxJulho.UseVisualStyleBackColor = true;
            // 
            // checkBoxJunho
            // 
            this.checkBoxJunho.AutoSize = true;
            this.checkBoxJunho.Location = new System.Drawing.Point(170, 74);
            this.checkBoxJunho.Name = "checkBoxJunho";
            this.checkBoxJunho.Size = new System.Drawing.Size(67, 20);
            this.checkBoxJunho.TabIndex = 12;
            this.checkBoxJunho.Text = "Junho";
            this.checkBoxJunho.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaio
            // 
            this.checkBoxMaio.AutoSize = true;
            this.checkBoxMaio.Location = new System.Drawing.Point(170, 48);
            this.checkBoxMaio.Name = "checkBoxMaio";
            this.checkBoxMaio.Size = new System.Drawing.Size(60, 20);
            this.checkBoxMaio.TabIndex = 11;
            this.checkBoxMaio.Text = "Maio";
            this.checkBoxMaio.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbril
            // 
            this.checkBoxAbril.AutoSize = true;
            this.checkBoxAbril.Location = new System.Drawing.Point(170, 21);
            this.checkBoxAbril.Name = "checkBoxAbril";
            this.checkBoxAbril.Size = new System.Drawing.Size(58, 20);
            this.checkBoxAbril.TabIndex = 10;
            this.checkBoxAbril.Text = "Abril";
            this.checkBoxAbril.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarco
            // 
            this.checkBoxMarco.AutoSize = true;
            this.checkBoxMarco.Location = new System.Drawing.Point(10, 74);
            this.checkBoxMarco.Name = "checkBoxMarco";
            this.checkBoxMarco.Size = new System.Drawing.Size(69, 20);
            this.checkBoxMarco.TabIndex = 9;
            this.checkBoxMarco.Text = "Março";
            this.checkBoxMarco.UseVisualStyleBackColor = true;
            // 
            // checkBoxFevereiro
            // 
            this.checkBoxFevereiro.AutoSize = true;
            this.checkBoxFevereiro.Location = new System.Drawing.Point(10, 48);
            this.checkBoxFevereiro.Name = "checkBoxFevereiro";
            this.checkBoxFevereiro.Size = new System.Drawing.Size(93, 20);
            this.checkBoxFevereiro.TabIndex = 8;
            this.checkBoxFevereiro.Text = "Fevereiro";
            this.checkBoxFevereiro.UseVisualStyleBackColor = true;
            // 
            // checkBoxJaneiro
            // 
            this.checkBoxJaneiro.AutoSize = true;
            this.checkBoxJaneiro.Location = new System.Drawing.Point(10, 21);
            this.checkBoxJaneiro.Name = "checkBoxJaneiro";
            this.checkBoxJaneiro.Size = new System.Drawing.Size(78, 20);
            this.checkBoxJaneiro.TabIndex = 7;
            this.checkBoxJaneiro.Text = "Janeiro";
            this.checkBoxJaneiro.UseVisualStyleBackColor = true;
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(375, 16);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(320, 22);
            this.campoNome.TabIndex = 5;
            this.campoNome.Enter += new System.EventHandler(this.campoNome_Enter);
            this.campoNome.Leave += new System.EventHandler(this.campoNome_Leave);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(252, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(117, 16);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome do Aluno:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(701, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // TelaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelFinanceiro);
            this.Name = "TelaFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFinanceiro";
            this.panelFinanceiro.ResumeLayout(false);
            this.panelFinanceiro.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBoxSituacao.ResumeLayout(false);
            this.groupBoxSituacao.PerformLayout();
            this.groupBoxMensalidades.ResumeLayout(false);
            this.groupBoxMensalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFinanceiro;
        private System.Windows.Forms.Label rotuloFinanceiro;
        private System.Windows.Forms.Label rotuloCodAluno;
        private System.Windows.Forms.TextBox campoCodAluno;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBoxMensalidades;
        private System.Windows.Forms.CheckBox checkBoxDezembro;
        private System.Windows.Forms.CheckBox checkBoxNovembro;
        private System.Windows.Forms.CheckBox checkBoxOutubro;
        private System.Windows.Forms.CheckBox checkBoxSetembro;
        private System.Windows.Forms.CheckBox checkBoxAgosto;
        private System.Windows.Forms.CheckBox checkBoxJulho;
        private System.Windows.Forms.CheckBox checkBoxJunho;
        private System.Windows.Forms.CheckBox checkBoxMaio;
        private System.Windows.Forms.CheckBox checkBoxAbril;
        private System.Windows.Forms.CheckBox checkBoxMarco;
        private System.Windows.Forms.CheckBox checkBoxFevereiro;
        private System.Windows.Forms.CheckBox checkBoxJaneiro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonEmDia;
        private System.Windows.Forms.RadioButton radioButtonAtrasado;
    }
}