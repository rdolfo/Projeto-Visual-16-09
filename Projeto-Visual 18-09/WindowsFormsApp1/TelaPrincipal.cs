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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro tela1 = new TelaCadastro();
            this.Hide();
            tela1.Show();

            
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            TelaFinanceiro tela2 = new TelaFinanceiro();
            this.Hide();
            tela2.Show();
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            TelaTurmas tela3 = new TelaTurmas();
            this.Hide();
            tela3.Show();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            this.Hide();
            tela.Show();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            TelaInteracao tela = new TelaInteracao();
            this.Hide();
            tela.Show();
        }
    }
}
