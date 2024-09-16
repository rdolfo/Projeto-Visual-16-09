namespace WindowsFormsApp1
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.rotuloCadastro = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.campoObservacao = new System.Windows.Forms.TextBox();
            this.rotuloObservacao = new System.Windows.Forms.Label();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.Perfil = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.rotuloEmail = new System.Windows.Forms.Label();
            this.campoCelular = new System.Windows.Forms.MaskedTextBox();
            this.campoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rotuloCelular = new System.Windows.Forms.Label();
            this.rotuloTelefone = new System.Windows.Forms.Label();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.rotuloCidade = new System.Windows.Forms.Label();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.rotuloEstado = new System.Windows.Forms.Label();
            this.campoCEP = new System.Windows.Forms.MaskedTextBox();
            this.rotuloCEP = new System.Windows.Forms.Label();
            this.campoBairro = new System.Windows.Forms.TextBox();
            this.rotuloBairro = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.rotuloEndereco = new System.Windows.Forms.Label();
            this.campoNascimento = new System.Windows.Forms.MaskedTextBox();
            this.rotuloNascimento = new System.Windows.Forms.Label();
            this.campoRG = new System.Windows.Forms.TextBox();
            this.rotuloRG = new System.Windows.Forms.Label();
            this.campoCPF = new System.Windows.Forms.MaskedTextBox();
            this.rotuloCPF = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.rotuloFoto = new System.Windows.Forms.Label();
            this.campoMatricula = new System.Windows.Forms.TextBox();
            this.rotuloMatricula = new System.Windows.Forms.Label();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.rotuloCodigo = new System.Windows.Forms.Label();
            this.campoApelido = new System.Windows.Forms.TextBox();
            this.rotuloApelido = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.rotuloNome = new System.Windows.Forms.Label();
            this.FileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.panelCadastro.SuspendLayout();
            this.panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCadastro.Controls.Add(this.rotuloCadastro);
            this.panelCadastro.Location = new System.Drawing.Point(2, 2);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(930, 97);
            this.panelCadastro.TabIndex = 0;
            // 
            // rotuloCadastro
            // 
            this.rotuloCadastro.AutoSize = true;
            this.rotuloCadastro.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCadastro.Location = new System.Drawing.Point(9, 16);
            this.rotuloCadastro.Name = "rotuloCadastro";
            this.rotuloCadastro.Size = new System.Drawing.Size(511, 56);
            this.rotuloCadastro.TabIndex = 0;
            this.rotuloCadastro.Text = "Cadastro de Pessoas";
            // 
            // panelDados
            // 
            this.panelDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDados.Controls.Add(this.btnVoltar);
            this.panelDados.Controls.Add(this.btnSalvar);
            this.panelDados.Controls.Add(this.campoObservacao);
            this.panelDados.Controls.Add(this.rotuloObservacao);
            this.panelDados.Controls.Add(this.comboBoxPerfil);
            this.panelDados.Controls.Add(this.Perfil);
            this.panelDados.Controls.Add(this.campoEmail);
            this.panelDados.Controls.Add(this.rotuloEmail);
            this.panelDados.Controls.Add(this.campoCelular);
            this.panelDados.Controls.Add(this.campoTelefone);
            this.panelDados.Controls.Add(this.rotuloCelular);
            this.panelDados.Controls.Add(this.rotuloTelefone);
            this.panelDados.Controls.Add(this.campoCidade);
            this.panelDados.Controls.Add(this.rotuloCidade);
            this.panelDados.Controls.Add(this.comboBoxUF);
            this.panelDados.Controls.Add(this.rotuloEstado);
            this.panelDados.Controls.Add(this.campoCEP);
            this.panelDados.Controls.Add(this.rotuloCEP);
            this.panelDados.Controls.Add(this.campoBairro);
            this.panelDados.Controls.Add(this.rotuloBairro);
            this.panelDados.Controls.Add(this.campoEndereco);
            this.panelDados.Controls.Add(this.rotuloEndereco);
            this.panelDados.Controls.Add(this.campoNascimento);
            this.panelDados.Controls.Add(this.rotuloNascimento);
            this.panelDados.Controls.Add(this.campoRG);
            this.panelDados.Controls.Add(this.rotuloRG);
            this.panelDados.Controls.Add(this.campoCPF);
            this.panelDados.Controls.Add(this.rotuloCPF);
            this.panelDados.Controls.Add(this.btnCarregar);
            this.panelDados.Controls.Add(this.pictureBoxFoto);
            this.panelDados.Controls.Add(this.rotuloFoto);
            this.panelDados.Controls.Add(this.campoMatricula);
            this.panelDados.Controls.Add(this.rotuloMatricula);
            this.panelDados.Controls.Add(this.campoCodigo);
            this.panelDados.Controls.Add(this.rotuloCodigo);
            this.panelDados.Controls.Add(this.campoApelido);
            this.panelDados.Controls.Add(this.rotuloApelido);
            this.panelDados.Controls.Add(this.campoNome);
            this.panelDados.Controls.Add(this.rotuloNome);
            this.panelDados.Location = new System.Drawing.Point(2, 96);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(930, 512);
            this.panelDados.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(842, 431);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 34);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(660, 431);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // campoObservacao
            // 
            this.campoObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoObservacao.Location = new System.Drawing.Point(90, 401);
            this.campoObservacao.Multiline = true;
            this.campoObservacao.Name = "campoObservacao";
            this.campoObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.campoObservacao.Size = new System.Drawing.Size(509, 82);
            this.campoObservacao.TabIndex = 36;
            this.campoObservacao.Enter += new System.EventHandler(this.campoObservacao_Enter);
            this.campoObservacao.Leave += new System.EventHandler(this.campoObservacao_Leave);
            // 
            // rotuloObservacao
            // 
            this.rotuloObservacao.AutoSize = true;
            this.rotuloObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloObservacao.Location = new System.Drawing.Point(-3, 431);
            this.rotuloObservacao.Name = "rotuloObservacao";
            this.rotuloObservacao.Size = new System.Drawing.Size(96, 16);
            this.rotuloObservacao.TabIndex = 35;
            this.rotuloObservacao.Text = "Observação:";
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Funcionário"});
            this.comboBoxPerfil.Location = new System.Drawing.Point(90, 374);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(274, 21);
            this.comboBoxPerfil.TabIndex = 34;
            this.comboBoxPerfil.Enter += new System.EventHandler(this.comboBoxPerfil_Enter);
            this.comboBoxPerfil.Leave += new System.EventHandler(this.comboBoxPerfil_Leave);
            // 
            // Perfil
            // 
            this.Perfil.AllowDrop = true;
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil.Location = new System.Drawing.Point(24, 375);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(47, 16);
            this.Perfil.TabIndex = 33;
            this.Perfil.Text = "Perfil:";
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(89, 339);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(510, 22);
            this.campoEmail.TabIndex = 32;
            this.campoEmail.Enter += new System.EventHandler(this.campoEmail_Enter);
            this.campoEmail.Leave += new System.EventHandler(this.campoEmail_Leave);
            // 
            // rotuloEmail
            // 
            this.rotuloEmail.AutoSize = true;
            this.rotuloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloEmail.Location = new System.Drawing.Point(20, 339);
            this.rotuloEmail.Name = "rotuloEmail";
            this.rotuloEmail.Size = new System.Drawing.Size(55, 16);
            this.rotuloEmail.TabIndex = 31;
            this.rotuloEmail.Text = "E-Mail:";
            // 
            // campoCelular
            // 
            this.campoCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCelular.Location = new System.Drawing.Point(263, 307);
            this.campoCelular.Mask = "(99)99999-9999";
            this.campoCelular.Name = "campoCelular";
            this.campoCelular.Size = new System.Drawing.Size(100, 22);
            this.campoCelular.TabIndex = 30;
            this.campoCelular.Enter += new System.EventHandler(this.campoCelular_Enter);
            this.campoCelular.Leave += new System.EventHandler(this.campoCelular_Leave);
            // 
            // campoTelefone
            // 
            this.campoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.Location = new System.Drawing.Point(90, 307);
            this.campoTelefone.Mask = "(99)9999-9999";
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(87, 22);
            this.campoTelefone.TabIndex = 29;
            this.campoTelefone.Enter += new System.EventHandler(this.campoTelefone_Enter);
            this.campoTelefone.Leave += new System.EventHandler(this.campoTelefone_Leave);
            // 
            // rotuloCelular
            // 
            this.rotuloCelular.AutoSize = true;
            this.rotuloCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCelular.Location = new System.Drawing.Point(197, 307);
            this.rotuloCelular.Name = "rotuloCelular";
            this.rotuloCelular.Size = new System.Drawing.Size(60, 16);
            this.rotuloCelular.TabIndex = 28;
            this.rotuloCelular.Text = "Celular:";
            // 
            // rotuloTelefone
            // 
            this.rotuloTelefone.AutoSize = true;
            this.rotuloTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloTelefone.Location = new System.Drawing.Point(11, 307);
            this.rotuloTelefone.Name = "rotuloTelefone";
            this.rotuloTelefone.Size = new System.Drawing.Size(73, 16);
            this.rotuloTelefone.TabIndex = 27;
            this.rotuloTelefone.Text = "Telefone:";
            // 
            // campoCidade
            // 
            this.campoCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCidade.Location = new System.Drawing.Point(254, 262);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.Size = new System.Drawing.Size(344, 22);
            this.campoCidade.TabIndex = 26;
            this.campoCidade.Enter += new System.EventHandler(this.campoCidade_Enter);
            this.campoCidade.Leave += new System.EventHandler(this.campoCidade_Leave);
            // 
            // rotuloCidade
            // 
            this.rotuloCidade.AutoSize = true;
            this.rotuloCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCidade.Location = new System.Drawing.Point(187, 267);
            this.rotuloCidade.Name = "rotuloCidade";
            this.rotuloCidade.Size = new System.Drawing.Size(61, 16);
            this.rotuloCidade.TabIndex = 25;
            this.rotuloCidade.Text = "Cidade:";
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUF.Location = new System.Drawing.Point(89, 263);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(81, 21);
            this.comboBoxUF.TabIndex = 24;
            this.comboBoxUF.SelectedIndexChanged += new System.EventHandler(this.comboBoxUF_SelectedIndexChanged);
            this.comboBoxUF.Enter += new System.EventHandler(this.comboBoxUF_Enter);
            this.comboBoxUF.Leave += new System.EventHandler(this.comboBoxUF_Leave);
            // 
            // rotuloEstado
            // 
            this.rotuloEstado.AutoSize = true;
            this.rotuloEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloEstado.Location = new System.Drawing.Point(20, 267);
            this.rotuloEstado.Name = "rotuloEstado";
            this.rotuloEstado.Size = new System.Drawing.Size(31, 16);
            this.rotuloEstado.TabIndex = 23;
            this.rotuloEstado.Text = "UF:";
            // 
            // campoCEP
            // 
            this.campoCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCEP.Location = new System.Drawing.Point(457, 159);
            this.campoCEP.Mask = "99,999-999";
            this.campoCEP.Name = "campoCEP";
            this.campoCEP.Size = new System.Drawing.Size(73, 22);
            this.campoCEP.TabIndex = 22;
            this.campoCEP.Enter += new System.EventHandler(this.campoCEP_Enter);
            this.campoCEP.Leave += new System.EventHandler(this.campoCEP_Leave);
            // 
            // rotuloCEP
            // 
            this.rotuloCEP.AutoSize = true;
            this.rotuloCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCEP.Location = new System.Drawing.Point(410, 162);
            this.rotuloCEP.Name = "rotuloCEP";
            this.rotuloCEP.Size = new System.Drawing.Size(41, 16);
            this.rotuloCEP.TabIndex = 21;
            this.rotuloCEP.Text = "CEP:";
            // 
            // campoBairro
            // 
            this.campoBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoBairro.Location = new System.Drawing.Point(90, 231);
            this.campoBairro.Name = "campoBairro";
            this.campoBairro.Size = new System.Drawing.Size(508, 22);
            this.campoBairro.TabIndex = 20;
            this.campoBairro.Enter += new System.EventHandler(this.campoBairro_Enter);
            this.campoBairro.Leave += new System.EventHandler(this.campoBairro_Leave);
            // 
            // rotuloBairro
            // 
            this.rotuloBairro.AutoSize = true;
            this.rotuloBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloBairro.Location = new System.Drawing.Point(17, 234);
            this.rotuloBairro.Name = "rotuloBairro";
            this.rotuloBairro.Size = new System.Drawing.Size(49, 16);
            this.rotuloBairro.TabIndex = 19;
            this.rotuloBairro.Text = "Bairro";
            // 
            // campoEndereco
            // 
            this.campoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEndereco.Location = new System.Drawing.Point(90, 195);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(509, 22);
            this.campoEndereco.TabIndex = 18;
            this.campoEndereco.Enter += new System.EventHandler(this.campoEndereco_Enter);
            this.campoEndereco.Leave += new System.EventHandler(this.campoEndereco_Leave);
            // 
            // rotuloEndereco
            // 
            this.rotuloEndereco.AutoSize = true;
            this.rotuloEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloEndereco.Location = new System.Drawing.Point(6, 198);
            this.rotuloEndereco.Name = "rotuloEndereco";
            this.rotuloEndereco.Size = new System.Drawing.Size(78, 16);
            this.rotuloEndereco.TabIndex = 17;
            this.rotuloEndereco.Text = "Endereço:";
            // 
            // campoNascimento
            // 
            this.campoNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNascimento.Location = new System.Drawing.Point(164, 159);
            this.campoNascimento.Mask = "99/99/9999";
            this.campoNascimento.Name = "campoNascimento";
            this.campoNascimento.Size = new System.Drawing.Size(73, 22);
            this.campoNascimento.TabIndex = 16;
            this.campoNascimento.Enter += new System.EventHandler(this.campoNascimento_Enter);
            this.campoNascimento.Leave += new System.EventHandler(this.campoNascimento_Leave);
            // 
            // rotuloNascimento
            // 
            this.rotuloNascimento.AutoSize = true;
            this.rotuloNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloNascimento.Location = new System.Drawing.Point(6, 162);
            this.rotuloNascimento.Name = "rotuloNascimento";
            this.rotuloNascimento.Size = new System.Drawing.Size(148, 16);
            this.rotuloNascimento.TabIndex = 15;
            this.rotuloNascimento.Text = "Data de Nascimento";
            // 
            // campoRG
            // 
            this.campoRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRG.Location = new System.Drawing.Point(89, 123);
            this.campoRG.Name = "campoRG";
            this.campoRG.Size = new System.Drawing.Size(510, 22);
            this.campoRG.TabIndex = 14;
            this.campoRG.Enter += new System.EventHandler(this.campoRG_Enter);
            this.campoRG.Leave += new System.EventHandler(this.campoRG_Leave);
            // 
            // rotuloRG
            // 
            this.rotuloRG.AutoSize = true;
            this.rotuloRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloRG.Location = new System.Drawing.Point(10, 129);
            this.rotuloRG.Name = "rotuloRG";
            this.rotuloRG.Size = new System.Drawing.Size(33, 16);
            this.rotuloRG.TabIndex = 13;
            this.rotuloRG.Text = "RG:";
            // 
            // campoCPF
            // 
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCPF.Location = new System.Drawing.Point(299, 159);
            this.campoCPF.Mask = "000,000,000-00";
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(94, 22);
            this.campoCPF.TabIndex = 12;
            this.campoCPF.Enter += new System.EventHandler(this.campoCPF_Enter);
            this.campoCPF.Leave += new System.EventHandler(this.campoCPF_Leave);
            // 
            // rotuloCPF
            // 
            this.rotuloCPF.AutoSize = true;
            this.rotuloCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCPF.Location = new System.Drawing.Point(253, 162);
            this.rotuloCPF.Name = "rotuloCPF";
            this.rotuloCPF.Size = new System.Drawing.Size(40, 16);
            this.rotuloCPF.TabIndex = 11;
            this.rotuloCPF.Text = "CPF:";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(660, 361);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(257, 30);
            this.btnCarregar.TabIndex = 10;
            this.btnCarregar.Text = "&Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // rotuloFoto
            // 
            this.rotuloFoto.AutoSize = true;
            this.rotuloFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloFoto.Location = new System.Drawing.Point(769, 19);
            this.rotuloFoto.Name = "rotuloFoto";
            this.rotuloFoto.Size = new System.Drawing.Size(38, 16);
            this.rotuloFoto.TabIndex = 8;
            this.rotuloFoto.Text = "Foto";
            // 
            // campoMatricula
            // 
            this.campoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoMatricula.Location = new System.Drawing.Point(369, 93);
            this.campoMatricula.Name = "campoMatricula";
            this.campoMatricula.Size = new System.Drawing.Size(229, 22);
            this.campoMatricula.TabIndex = 7;
            this.campoMatricula.Enter += new System.EventHandler(this.campoMatricula_Enter);
            this.campoMatricula.Leave += new System.EventHandler(this.campoMatricula_Leave);
            // 
            // rotuloMatricula
            // 
            this.rotuloMatricula.AutoSize = true;
            this.rotuloMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloMatricula.Location = new System.Drawing.Point(289, 96);
            this.rotuloMatricula.Name = "rotuloMatricula";
            this.rotuloMatricula.Size = new System.Drawing.Size(74, 16);
            this.rotuloMatricula.TabIndex = 6;
            this.rotuloMatricula.Text = "Matrícula:";
            // 
            // campoCodigo
            // 
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Location = new System.Drawing.Point(90, 93);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(180, 22);
            this.campoCodigo.TabIndex = 5;
            this.campoCodigo.Enter += new System.EventHandler(this.campoCodigo_Enter);
            this.campoCodigo.Leave += new System.EventHandler(this.campoCodigo_Leave);
            // 
            // rotuloCodigo
            // 
            this.rotuloCodigo.AutoSize = true;
            this.rotuloCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloCodigo.Location = new System.Drawing.Point(10, 96);
            this.rotuloCodigo.Name = "rotuloCodigo";
            this.rotuloCodigo.Size = new System.Drawing.Size(61, 16);
            this.rotuloCodigo.TabIndex = 4;
            this.rotuloCodigo.Text = "Código:";
            // 
            // campoApelido
            // 
            this.campoApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoApelido.Location = new System.Drawing.Point(89, 54);
            this.campoApelido.Name = "campoApelido";
            this.campoApelido.Size = new System.Drawing.Size(509, 22);
            this.campoApelido.TabIndex = 3;
            this.campoApelido.TextChanged += new System.EventHandler(this.campoApelido_TextChanged);
            this.campoApelido.Enter += new System.EventHandler(this.campoApelido_Enter);
            this.campoApelido.Leave += new System.EventHandler(this.campoApelido_Leave);
            // 
            // rotuloApelido
            // 
            this.rotuloApelido.AutoSize = true;
            this.rotuloApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloApelido.Location = new System.Drawing.Point(10, 57);
            this.rotuloApelido.Name = "rotuloApelido";
            this.rotuloApelido.Size = new System.Drawing.Size(65, 16);
            this.rotuloApelido.TabIndex = 2;
            this.rotuloApelido.Text = "Apelido:";
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(89, 19);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(509, 22);
            this.campoNome.TabIndex = 1;
            this.campoNome.Enter += new System.EventHandler(this.campoNome_Enter);
            this.campoNome.Leave += new System.EventHandler(this.campoNome_Leave);
            // 
            // rotuloNome
            // 
            this.rotuloNome.AutoSize = true;
            this.rotuloNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotuloNome.Location = new System.Drawing.Point(10, 22);
            this.rotuloNome.Name = "rotuloNome";
            this.rotuloNome.Size = new System.Drawing.Size(52, 16);
            this.rotuloNome.TabIndex = 0;
            this.rotuloNome.Text = "Nome:";
            // 
            // FileDialogFoto
            // 
            this.FileDialogFoto.FileName = "openFileDialog1";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::WindowsFormsApp1.Properties.Resources.d4f;
            this.pictureBoxFoto.Location = new System.Drawing.Point(660, 38);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(261, 317);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 9;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.panelCadastro);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Cadastro";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label rotuloCadastro;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.TextBox campoApelido;
        private System.Windows.Forms.Label rotuloApelido;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label rotuloNome;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.Label rotuloCodigo;
        private System.Windows.Forms.Label rotuloFoto;
        private System.Windows.Forms.TextBox campoMatricula;
        private System.Windows.Forms.Label rotuloMatricula;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.OpenFileDialog FileDialogFoto;
        private System.Windows.Forms.MaskedTextBox campoCPF;
        private System.Windows.Forms.Label rotuloCPF;
        private System.Windows.Forms.MaskedTextBox campoNascimento;
        private System.Windows.Forms.Label rotuloNascimento;
        private System.Windows.Forms.TextBox campoRG;
        private System.Windows.Forms.Label rotuloRG;
        private System.Windows.Forms.MaskedTextBox campoCEP;
        private System.Windows.Forms.Label rotuloCEP;
        private System.Windows.Forms.TextBox campoBairro;
        private System.Windows.Forms.Label rotuloBairro;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Label rotuloEndereco;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.Label rotuloEstado;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.Label rotuloCidade;
        private System.Windows.Forms.MaskedTextBox campoTelefone;
        private System.Windows.Forms.Label rotuloCelular;
        private System.Windows.Forms.Label rotuloTelefone;
        private System.Windows.Forms.MaskedTextBox campoCelular;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label rotuloEmail;
        private System.Windows.Forms.TextBox campoObservacao;
        private System.Windows.Forms.Label rotuloObservacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
    }
}

