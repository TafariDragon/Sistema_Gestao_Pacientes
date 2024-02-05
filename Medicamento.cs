using System;
namespace Sistema_Gestao_Pacientes
{
	public class Medicamento
	{

		private string nome;
		private double preco;
		private string fabricante;



		public Medicamento()
		{
		}


		public string Nome
		{
			get { return nome;}
			set { nome = value; }
		}


        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

    }
}

