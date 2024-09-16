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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void campoMatricula_enter(object sender, EventArgs e)
        {
            campoMatricula.BackColor = Color.Yellow;
            string caminho = Application.StartupPath + "\\Imagens\\Principal.jpg";
            pictureBoxFoto.ImageLocation = caminho;
        }

        private void campoMatricula_leave(object sender, EventArgs e)
        {
            campoMatricula.BackColor = Color.White;
        }

        private void campoSenha_leave(object sender, EventArgs e)
        {
            campoSenha.BackColor = Color.White;
            string caminho = Application.StartupPath + "\\Imagens\\Principal.jpg";
            pictureBoxFoto.ImageLocation = caminho;
        }

        private void campoSenha_enter(object sender, EventArgs e)
        {
            campoSenha.BackColor = Color.Yellow;
            string caminho = Application.StartupPath + "\\Imagens\\Senha.jpg";
            pictureBoxFoto.ImageLocation = caminho;
        }

        private void campoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cont =  campoMatricula.Text.Length;
            string caminho = Application.StartupPath + "\\Imagens\\" + cont + ".jpg";
            pictureBoxFoto.ImageLocation = caminho;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            progressBarCarregando.Visible = true;
            labelCarregando.Visible = true;

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBarCarregando.Value < 100)
            {
                progressBarCarregando.Value += 10;
            }

            if(progressBarCarregando.Value >= 100)
            {
                progressBarCarregando.Value = 0;
                timer1.Enabled = false;

                string caminho;

                if (campoMatricula.Text == "BA123" && campoSenha.Text == "123")
                {
                    caminho = Application.StartupPath + "\\Imagens\\Yes.jpg";
                }
                else
                {
                    caminho = Application.StartupPath + "\\Imagens\\NO.jpg";
                }
                pictureBoxAcesso.ImageLocation = caminho;

            }


            
        }

        private void progressBarCarregando_Click(object sender, EventArgs e)
        {

        }
    }
}
