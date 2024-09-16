using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class TelaTurmas : Form
    {
        public TelaTurmas()
        {
            InitializeComponent();
        }

        private void labelModalidade_Click(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void labelValor_Click(object sender, EventArgs e)
        {

        }

        private void tabPageTurmas_Click(object sender, EventArgs e)
        {

        }

        private void labelInicioTreino_Click(object sender, EventArgs e)
        {

        }

        private void labelRepeticao_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
