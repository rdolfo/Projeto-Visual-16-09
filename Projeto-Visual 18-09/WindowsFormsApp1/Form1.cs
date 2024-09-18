using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        // Variavel global da classe que tem acesso a todos os metodos dessa classe
        Pessoa p = new Pessoa();

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (FileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                string caminho = FileDialogFoto.FileName;
                pictureBoxFoto.ImageLocation = caminho;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            this.Hide();
            tela.Show();
        }

        private void btnTelaFinanceiro_Click(object sender, EventArgs e)
        {
            TelaFinanceiro telinha = new TelaFinanceiro();
            this.Hide();
            telinha.Show();
        }

        private void campoNome_Enter(object sender, EventArgs e)
        {
            campoNome.BackColor = Color.Yellow;
        }

        private void campoNome_Leave(object sender, EventArgs e)
        {
            campoNome.BackColor = Color.White;
        }

        private void campoApelido_Enter(object sender, EventArgs e)
        {
            campoApelido.BackColor = Color.Yellow;
        }

        private void campoApelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoApelido_Leave(object sender, EventArgs e)
        {
            campoApelido.BackColor = Color.White;
        }

        private void campoCodigo_Enter(object sender, EventArgs e)
        {
            campoCodigo.BackColor = Color.Yellow;
        }

        private void campoCodigo_Leave(object sender, EventArgs e)
        {
            campoCodigo.BackColor = Color.White;
        }

        private void campoMatricula_Enter(object sender, EventArgs e)
        {
            campoMatricula.BackColor = Color.Yellow;
        }

        private void campoMatricula_Leave(object sender, EventArgs e)
        {
            campoMatricula.BackColor = Color.White;
        }

        private void campoRG_Enter(object sender, EventArgs e)
        {
            campoRG.BackColor = Color.Yellow;
        }

        private void campoRG_Leave(object sender, EventArgs e)
        {
            campoRG.BackColor = Color.White;
        }

        private void campoNascimento_Enter(object sender, EventArgs e)
        {
            campoNascimento.BackColor = Color.Yellow;
        }

        private void campoNascimento_Leave(object sender, EventArgs e)
        {
            campoNascimento.BackColor = Color.White;
        }

        private void campoCPF_Enter(object sender, EventArgs e)
        {
            campoCPF.BackColor = Color.Yellow;
        }

        private void campoCPF_Leave(object sender, EventArgs e)
        {
            campoCPF.BackColor = Color.White;
        }

        private void campoCEP_Enter(object sender, EventArgs e)
        {
            campoCEP.BackColor = Color.Yellow;
        }

        private void campoCEP_Leave(object sender, EventArgs e)
        {
            campoCEP.BackColor = Color.White;
        }

        private void campoEndereco_Enter(object sender, EventArgs e)
        {
            campoEndereco.BackColor = Color.Yellow;
        }

        private void campoEndereco_Leave(object sender, EventArgs e)
        {
            campoEndereco.BackColor = Color.White;
        }

        private void campoBairro_Enter(object sender, EventArgs e)
        {
            campoBairro.BackColor = Color.Yellow;
        }

        private void campoBairro_Leave(object sender, EventArgs e)
        {
            campoBairro.BackColor = Color.White;
        }

        private void comboBoxUF_Enter(object sender, EventArgs e)
        {
            comboBoxUF.BackColor = Color.Yellow;
        }

        private void comboBoxUF_Leave(object sender, EventArgs e)
        {
            comboBoxUF.BackColor = Color.White;
        }

        private void campoCidade_Enter(object sender, EventArgs e)
        {
            campoCidade.BackColor = Color.Yellow;
        }

        private void campoCidade_Leave(object sender, EventArgs e)
        {
            campoCidade.BackColor = Color.White;
        }

        private void campoTelefone_Enter(object sender, EventArgs e)
        {
            campoTelefone.BackColor = Color.Yellow;
        }

        private void campoTelefone_Leave(object sender, EventArgs e)
        {
            campoTelefone.BackColor = Color.White;
        }

        private void campoCelular_Enter(object sender, EventArgs e)
        {
            campoCelular.BackColor = Color.Yellow;
        }

        private void campoCelular_Leave(object sender, EventArgs e)
        {
            campoCelular.BackColor = Color.White;
        }

        private void campoEmail_Enter(object sender, EventArgs e)
        {
            campoEmail.BackColor = Color.Yellow;
        }

        private void campoEmail_Leave(object sender, EventArgs e)
        {
            campoEmail.BackColor = Color.White;
        }

        private void comboBoxPerfil_Enter(object sender, EventArgs e)
        {
            comboBoxPerfil.BackColor = Color.Yellow;
        }

        private void comboBoxPerfil_Leave(object sender, EventArgs e)
        {
            comboBoxPerfil.BackColor = Color.White;
        }

        private void campoObservacao_Enter(object sender, EventArgs e)
        {
            campoObservacao.BackColor = Color.Yellow;
        }

        private void campoObservacao_Leave(object sender, EventArgs e)
        {
            campoObservacao.BackColor = Color.White;
        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<string> vazios = new List<string>();
            if (campoNome.Text.Trim() == "") vazios.Add("Nome");
            else p.SetNome(campoNome.Text);

            if (campoApelido.Text.Trim() == "") vazios.Add("Apelido");
            else p.SetApelido(campoApelido.Text);

            if (campoCodigo.Text.Trim() == "") vazios.Add("Codigo");
            else p.SetCodigo(int.Parse(campoCodigo.Text));

            if (campoMatricula.Text.Trim() == "") vazios.Add("Matricula");
            else p.SetMatricula(campoMatricula.Text);


            p.SetRG(campoRG.Text);

            p.SetCPF(campoCPF.Text);

            if (campoNascimento.Text.Trim() == "") vazios.Add("Data de nascimento");
            else p.SetDataNasc(campoNascimento.Text);

            if (campoEndereco.Text.Trim() == "") vazios.Add("Endereço");
            else p.SetEndereco(campoEndereco.Text);

            if (campoBairro.Text.Trim() == "") vazios.Add("Bairro");
            else p.SetBairro(campoBairro.Text);

            if (comboBoxUF.Text.Trim() == "") vazios.Add("UF");
            else p.SetUF(comboBoxUF.Text);


            if (campoCEP.Text.Trim() == "") vazios.Add("CEP");
            else p.SetCEP(campoCEP.Text);

            if (campoCidade.Text.Trim() == "") vazios.Add("Cidade");
            else p.SetCidade(campoCidade.Text);

            if (campoTelefone.Text.Trim() == "") vazios.Add("Telefone");
            else p.SetTelefone(campoTelefone.Text);

            if (campoCelular.Text.Trim() == "") vazios.Add("Celular");
            else p.SetCelular(campoCelular.Text);

            if (campoEmail.Text.Trim() == "") vazios.Add("Email");
            else p.SetEmail(campoEmail.Text);

            if (comboBoxPerfil.Text.Trim() == "") vazios.Add("Perfil");
            else p.SetPerfil(comboBoxPerfil.Text);

            if (campoObservacao.Text.Trim() == "") vazios.Add("Observação");
            else p.SetObs(campoObservacao.Text);

            if (pictureBoxFoto.ImageLocation == null) vazios.Add("Foto");
            else p.SetFoto(pictureBoxFoto.ImageLocation);

            if (vazios.Count > 0)
            {
                string msg = "Os campos:\n";
                foreach (var item in vazios)
                {
                    msg += item + "\n";
                }

                
                MessageBox.Show(msg + "estão vazios");

            }
        }
    }
}
