using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForms.EntitiesAgenda
{
    public class Pessoa
    {
        private string email;
        private string nome;
        private string endereco;
        private string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }


        public Pessoa()
        {

        }

        public Pessoa(string nome, string endereco,
                      string telefone, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
    }
}
