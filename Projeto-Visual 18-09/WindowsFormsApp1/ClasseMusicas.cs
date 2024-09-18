using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    internal class ClasseMusicas
    {
        public string caminho;

        Dictionary<string, string> ListaMusicas= new Dictionary<string, string>();

        public Dictionary<string, string> Funcao_Adiciona_Musicas()
        {
            string[] Arquivos = Directory.GetFiles(caminho);

            foreach(string i in Arquivos)
            {
                // C:\Bin\Debug\Franco.mp3
                // C:\Bin\Debug\WesleySafadao.mp3
                string[] nome = i.Split('\\');
                string nomeMusica = nome[nome.Length - 1];
                ListaMusicas.Add(nomeMusica, i);
            }

            return ListaMusicas;
        }

    }
}
