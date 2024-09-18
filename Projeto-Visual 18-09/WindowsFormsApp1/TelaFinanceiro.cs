using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaFinanceiro : Form
    {
        public TelaFinanceiro()
        {
            InitializeComponent();
        }


        private void checkBoxNovembro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOutubro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDezembro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void campoCodAluno_Enter(object sender, EventArgs e)
        {
            campoCodAluno.BackColor = Color.Yellow;
        }

        private void campoCodAluno_Leave(object sender, EventArgs e)
        {
            campoCodAluno.BackColor = Color.White;
        }

        private void campoNome_Enter(object sender, EventArgs e)
        {
            campoNome.BackColor = Color.Yellow;
        }

        private void campoNome_Leave(object sender, EventArgs e)
        {
            campoNome.BackColor= Color.White;
        }
    }
}
