using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaCarrAluguel.Entidades;

namespace ProgramaCarrAluguel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CarroServicoLista CarroServico = new CarroServicoLista();

        Cliente cliente = new Cliente();

        Carros carros = new Carros();


        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = CarroServico.GetCarros();
        }

        public  void btnProcessarCliente_Click(object sender, EventArgs e)
        {
            string n = txtNome.Text;
            string t = txtTelefone.Text;
            string em = txtEmail.Text;
            string ct = cboCategoria.Text;
            DateTime data = DateTime.Now;

            Cliente cliente = new Cliente(n, t, em, data);

            lblNome.Text = cliente.Nome;
            lblTelefone.Text = cliente.Telefone;
            lblEmail.Text = cliente.Email;
            lblCategoria.Text = cboCategoria.Text;
            lblData.Text = Convert.ToString(cliente.DataCadastro);


            DateTime dr = Convert.ToDateTime(mtxtDataRetirada.Text);
            DateTime drt = Convert.ToDateTime(mtxtDataRetorno.Text);

          


            Aluguel aluguel = new Aluguel(cliente, carros, dr, drt);

            lbltext.Text = aluguel.Cliente.Nome;
            lblDuração.Text = Convert.ToString(aluguel.DuraçãoAluguelM());


            lblDataRetirada.Text = Convert.ToString(aluguel.DataRetirada);
            lblDataRetorno.Text = Convert.ToString(aluguel.DataRetorno);

            lblValorBase.Text = Convert.ToString("Aluguel R$"+aluguel.ValorBase);

            lblImposto.Text = Convert.ToString("Imposto R$ " + aluguel.ImpostoM());

            lblTotal.Text = Convert.ToString("Valor Total R$ " + aluguel.ValorTotaM());

           






        }

        public  void btnProcessarAluguel_Click(object sender, EventArgs e)
        {
            //DateTime dr = Convert.ToDateTime(mtxtDataRetirada.Text);
            //DateTime drt = Convert.ToDateTime(mtxtDataRetorno.Text);

            //Aluguel aluguel = new Aluguel(cliente, carros, dr, drt);

            //lblDataRetirada.Text = Convert.ToString(aluguel.DataRetirada);
            //lblDataRetorno.Text = Convert.ToString(aluguel.DataRetorno);

            //lbltext.Text = cliente.Nome;




        }
    }
}
