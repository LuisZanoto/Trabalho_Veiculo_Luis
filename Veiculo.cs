using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Veiculo
{

    protected string marca;
    protected string modelo;
    protected string cor;
    protected int ano;
    protected int nroPortas;
    protected int chassi;
    protected string proprietario;
    protected int velocidadeMaxima;
    protected int velocidadeAtual;
    protected int nroMarchas;
    protected int marchaAtual;

    public string  Marca{ get { return marca; } set{ marca = value; } }
    public string Modelo { get { return modelo; } set { modelo = value; } }

    public string Cor { get { return cor; } set { cor = value; } }
    public int Ano { get { return ano; } set { ano = value; } }
    public int NroPortas { get { return nroPortas ; } set { nroPortas  = value; } }
    public int Chassi { get { return chassi ; } set { chassi  = value; } }
    public string Proprietario { get { return proprietario; } set { proprietario = value; } }
    public int VelocidadeMaxima { get { return velocidadeMaxima; } set { velocidadeMaxima = value; } }
    public int VelocidadeAtual { get { return velocidadeAtual; } set { velocidadeAtual = value; } }
    public int NroMarchas { get { return nroMarchas; } set { nroMarchas = value; } }
    public int MarchaAtual { get { return marchaAtual; } set { marchaAtual = value; } }

    public void Acelerar(int incre)
    {
        this.velocidadeAtual = velocidadeAtual + incre;
    }

    public void Frear()
    {
        this.velocidadeAtual = 0;
    }

    public void AlterarMarcha(int marcha)
    {
        try
        {
            if(marcha < 0 || marcha > 6)
            {
                throw new Exception("Marcha Inválida !");
            }

            if (marcha == 0 && this.velocidadeAtual != 0)
            {
                throw new Exception("Reduza a velocidade para 0 km/h para engatar a marcha ré !");
            }

            this.marchaAtual = marcha; // altera somente se estiver dentro dos padrões

        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message,
                    "Tratamento de Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        
    }


    public void ImprimirDados()
    {
        Console.WriteLine("Marca : " + marca);
        Console.WriteLine("Modelo : " + modelo );
        Console.WriteLine("Cor : " + cor);
        Console.WriteLine("Ano : " + ano );
        Console.WriteLine("Numero de Portas : " + nroPortas);
        Console.WriteLine("Chassi : " + chassi);
        Console.WriteLine("Proprietario : " + proprietario);
        Console.WriteLine("Velocidade Maxima : " + velocidadeMaxima);
        Console.WriteLine("Velocidade Atual : " + velocidadeAtual);
        Console.WriteLine("Quantidade de Marchas : " + nroMarchas);
        Console.WriteLine("Marcha Atual : " + marchaAtual);
        Console.WriteLine("____________________________________________________\n");
       


    }
}

