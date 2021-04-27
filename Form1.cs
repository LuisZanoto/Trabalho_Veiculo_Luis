using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Veiculo_Luis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int gerarChassi() // gerar numero de chassi automaticamente
        {
            Random o_Rand = new Random();
            int vlrRand;
            vlrRand = o_Rand.Next(40000, 999999);
            return vlrRand;
        }

        private void BtnVeiculo_Click(object sender, EventArgs e)
        {
           

            Veiculo o_Veiculo = new Veiculo();

            o_Veiculo.Marca = "Chevrolet";
            o_Veiculo.Modelo = "Corsa";
            o_Veiculo.Ano = 2020;
            o_Veiculo.Cor = "Branca";
            o_Veiculo.NroPortas = 5;
            o_Veiculo.Chassi = gerarChassi ();
            o_Veiculo.VelocidadeMaxima = 180;
            o_Veiculo.NroMarchas = 6;
            o_Veiculo.Proprietario = "Luis Zanoto";


            o_Veiculo.AlterarMarcha(1);
            o_Veiculo.Acelerar(10);
            o_Veiculo.Frear();
            o_Veiculo.Acelerar(10);
            o_Veiculo.Acelerar(10);
            o_Veiculo.Acelerar(10);
            o_Veiculo.AlterarMarcha(2);
            o_Veiculo.Acelerar(10);
            o_Veiculo.Acelerar(10);
            o_Veiculo.AlterarMarcha(3);

            //o_Veiculo.AlterarMarcha(0); // para gerar erro de marcha ré 

            //o_Veiculo.AlterarMarcha(7); // para gerar erro de marcha inválida 

            o_Veiculo.ImprimirDados();
            o_Veiculo.Frear();
            o_Veiculo.AlterarMarcha(0); // teste marcha ré
            o_Veiculo.ImprimirDados(); 
        }
    }
}
