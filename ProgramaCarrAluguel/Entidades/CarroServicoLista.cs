using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaCarrAluguel.Entidades;

namespace ProgramaCarrAluguel.Entidades
{
    public class CarroServicoLista
    {
        public List<Carros> GetCarros()
        {
            var listacarros = new List<Carros>();

            var carro1 = new Carros(1, "Civic");
            listacarros.Add(carro1);

            var carro2 = new Carros(2, "Corolla");
            listacarros.Add(carro2);

            var carro3 = new Carros(3, "Duster");
            listacarros.Add(carro3);

            var carro4 = new Carros(4, "Frontier");
            listacarros.Add(carro4);




            return listacarros;
        }

       
    }
}
