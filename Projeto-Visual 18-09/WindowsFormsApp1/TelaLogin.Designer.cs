namespace WindowsFormsApp1
{
    partial class TelaLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.campoMatricula = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBoxAcesso = new System.Windows.Forms.PictureBox();
            this.progressBarCarregando = new System.Windows.Forms.ProgressBar();
            this.labelCarregando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(97, 279);
            this.labelMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(87, 20);
            this.labelMatricula.TabIndex = 1;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(118, 329);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(66, 20);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // campoMatricula
            // 
            this.campoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoMatricula.Location = new System.Drawing.Point(192, 279);
            this.campoMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.campoMatricula.MaxLength = 15;
            this.campoMatricula.Name = "campoMatricula";
            this.campoMatricula.Size = new System.Drawing.Size(164, 22);
            this.campoMatricula.TabIndex = 3;
            this.campoMatricula.Enter += new System.EventHandler(this.campoMatricula_enter);
            this.campoMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoMatricula_KeyPress);
            this.campoMatricula.Leave += new System.EventHandler(this.campoMatricula_leave);
            // 
            // campoSenha
            // 
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.Location = new System.Drawing.Point(192, 329);
            this.campoSenha.Margin = new System.Windows.Forms.Padding(4);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '♣';
            this.campoSenha.Size = new System.Drawing.Size(164, 22);
            this.campoSenha.TabIndex = 4;
            this.campoSenha.TextChanged += new System.EventHandler(this.campoSenha_TextChanged);
            this.campoSenha.Enter += new System.EventHandler(this.campoSenha_enter);
            this.campoSenha.Leave += new System.EventHandler(this.campoSenha_leave);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(101, 26);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(255, 230);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(101, 530);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(81, 36);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(275, 530);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(81, 36);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBoxAcesso
            // 
            this.pictureBoxAcesso.Location = new System.Drawing.Point(180, 421);
            this.pictureBoxAcesso.Name = "pictureBoxAcesso";
            this.pictureBoxAcesso.Size = new System.Drawing.Size(97, 94);
            this.pictureBoxAcesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcesso.TabIndex = 7;
            this.pictureBoxAcesso.TabStop = false;
            // 
            // progressBarCarregando
            // 
            this.progressBarCarregando.Location = new System.Drawing.Point(101, 367);
            this.progressBarCarregando.Name = "progressBarCarregando";
            this.progressBarCarregando.Size = new System.Drawing.Size(255, 23);
            this.progressBarCarregando.TabIndex = 8;
            this.progressBarCarregando.Visible = false;
            this.progressBarCarregando.Click += new System.EventHandler(this.progressBarCarregando_Click);
            // 
            // labelCarregando
            // 
            this.labelCarregando.AutoSize = true;
            this.labelCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarregando.Location = new System.Drawing.Point(189, 393);
            this.labelCarregando.Name = "labelCarregando";
            this.labelCarregando.Size = new System.Drawing.Size(88, 16);
            this.labelCarregando.TabIndex = 9;
            this.labelCarregando.Text = "Carregando...";
            this.labelCarregando.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 596);
            this.ControlBox = false;
            this.Controls.Add(this.labelCarregando);
            this.Controls.Add(this.progressBarCarregando);
            this.Controls.Add(this.pictureBoxAcesso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoMatricula);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.pictureBoxFoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaLogin";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox campoMatricula;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBoxAcesso;
        private System.Windows.Forms.ProgressBar progressBarCarregando;
        private System.Windows.Forms.Label labelCarregando;
        private System.Windows.Forms.Timer timer1;
    }
}