using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCarrAluguel.Entidades
{
    class Aluguel
    {
        public Cliente Cliente { get; set; }
        public Carros Carros { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataRetorno { get; set; }
        public const double ValorHora = 10.00;
        public const double ValorDia = 130.00;
        public double ValorBase { get; set; }
        public double Imposto { get; set; }
        public double DuraçãoAluguel { get; set; }
        public double ValorTotal { get; set; }

        public Aluguel()
        {

        }

        public Aluguel(Cliente cliente, Carros carros, DateTime dataRetirada, DateTime dataRetorno)
        {
            Cliente = cliente;
            Carros = carros;
            DataRetirada = dataRetirada;
            DataRetorno = dataRetorno;
        }

        public override string ToString()
        {
            return this.Cliente.Nome + Carros.NomeCarros + this.DataRetirada + this.DataRetorno;

        }

        public double DuraçãoAluguelM()
        {
            TimeSpan duração = DataRetorno.Subtract(DataRetirada);
            DuraçãoAluguel = duração.TotalHours;



            if (duração.TotalHours <= 12)
            {
                DuraçãoAluguel = Math.Ceiling(duração.TotalHours);
                ValorBase = ValorHora * DuraçãoAluguel;
            }
            else
            {
                DuraçãoAluguel = Math.Ceiling(duração.TotalDays);
                ValorBase = ValorDia * DuraçãoAluguel;
            }

            return ValorBase;
        }

        public double ImpostoM()
        {
            if (DuraçãoAluguelM() <= 100)
            {
                Imposto = DuraçãoAluguelM() * 0.2;
            }
            else
            {
                Imposto = DuraçãoAluguelM() * 0.15;
            }

            return Imposto;

        }

        public double ValorTotaM()
        {

            ValorTotal = DuraçãoAluguelM() + ImpostoM();


            return ValorTotal;
        }


    }
}
