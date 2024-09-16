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
    public partial class TelaInteracao : Form
    {
        public TelaInteracao()
        {
            InitializeComponent();
        }

        // Aqui podemos adicionar variáveis globais
        Dictionary<string, string> dados;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            this.Hide();
            principal.Show();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Musicas";

            ClasseMusicas ClasseLegal = new ClasseMusicas();

            ClasseLegal.caminho = path;

            dados = ClasseLegal.Funcao_Adiciona_Musicas();

            foreach(KeyValuePair<string, string> d in dados)
            {
                listaMusicas.Items.Add(d.Key);
            }

            
        }

        private void listaMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = dados[listaMusicas.SelectedItem.ToString()];

            axWindowsMediaPlayer1.URL = nome;

        }
    }
}
