using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Pessoa
    {
        

        private string nome, apelido;
        private int codigo;
        private string matricula;
        private string data_nasc, rg, cpf;
        private string endereco, bairro, cep, uf, cidade;
        private string email, telefone, celular;
        private string perfil, obs;
        private string foto;

        // Metodos e funções
        // Metodos get(inserir dados) set(retonar daods)

        // Metodos Get e Set para o Nome
        

        public void SetNome(string name)
        {
            this.nome = name;
        }
        public string GetNome()
        {
            return this.nome;
        }
        
        
        // Metodos Get e Set para Apelido
        public void SetApelido(string nickname)
        {
            this.apelido = nickname;
        }

        public string GetApelido()
        {
            return this.apelido;
        }

        
       
        

        // Métodos Get e Set para Código
        public void SetCodigo(int code)
        {
            this.codigo = code;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }

        // Métodos Get e Set para Matrícula
        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string GetMatricula()
        {
            return this.matricula;
        }

        // Métodos Get e Set para Data de Nascimento
        public void SetDataNasc(string dataNasc)
        {
            this.data_nasc = dataNasc;
        }

        public string GetDataNasc()
        {
            return this.data_nasc;
        }

        // Métodos Get e Set para RG
        public void SetRG(string rg)
        {
            this.rg = rg;
        }

        public string GetRG()
        {
            return this.rg;
        }

        // Métodos Get e Set para CPF
        public void SetCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCPF()
        {
            return this.cpf;
        }

        // Métodos Get e Set para Endereço
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetEndereco()
        {
            return this.endereco;
        }

        // Métodos Get e Set para Bairro
        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        // Métodos Get e Set para CEP
        public void SetCEP(string cep)
        {
            this.cep = cep;
        }

        public string GetCEP()
        {
            return this.cep;
        }

        // Métodos Get e Set para UF
        public void SetUF(string uf)
        {
            this.uf = uf;
        }

        public string GetUF()
        {
            return this.uf;
        }

        // Metodos get e set para cidade

        public void SetCidade(string city)
        {
            this.cidade = city;
        }
        public string GetCidade()
        {
            return this.cidade;
        }

        // Métodos Get e Set para Email
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return this.email;
        }

        // Métodos Get e Set para Telefone
        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetTelefone()
        {
            return this.telefone;
        }

        // Métodos Get e Set para Celular
        public void SetCelular(string celular)
        {
            this.celular = celular;
        }

        public string GetCelular()
        {
            return this.celular;
        }

        // Métodos Get e Set para Perfil
        public void SetPerfil(string perfil)
        {
            this.perfil = perfil;
        }

        public string GetPerfil()
        {
            return this.perfil;
        }

        // Métodos Get e Set para Observação
        public void SetObs(string obs)
        {
            this.obs = obs;
        }

        public string GetObs()
        {
            return this.obs;
        }

        // Métodos Get e Set para Foto
        public void SetFoto(string foto)
        {
            this.foto = foto;
        }

        public string GetFoto()
        {
            return this.foto;
        }

        public bool ValidaCPF()
        {
            string str = cpf.Replace(".", "");
            str = str.Replace("-", "");

            string valida = "";

            List<char> dig = new List<char>(str.ToCharArray());

            int soma1 = 0;
            int soma2 = 0;

            for (int i = 0; i < dig.Count-2; i++)
            {
                valida += dig[i];
                soma1 += (dig[i] * (i + 1)) % 11;
            }

            soma1 = soma1 % 11;
            if (soma1 == 10) soma1 = 0;

            

            




        }

    }
}
