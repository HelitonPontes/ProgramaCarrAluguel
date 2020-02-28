using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCarrAluguel.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string telefone, string email, DateTime dataCadastro)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return this.Nome + this.Telefone + this.Email;
        }



    }
}
