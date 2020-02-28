using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCarrAluguel.Entidades
{
    public class Carros
    {
        public int Id { get; set; }
        public string NomeCarros { get; set; }

        public Carros()
        {

        }

        public Carros(int id, string nomeCarros)
        {
            Id = id;
            NomeCarros = nomeCarros;
        }
        public override string ToString()
        {
            return this.NomeCarros;

        }

     








    }
}
