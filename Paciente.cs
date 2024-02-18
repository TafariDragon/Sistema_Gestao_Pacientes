using System;
namespace Sistema_Gestao_Pacientes
{
	public class Paciente
	{

		private string nome;
		private int idade;
        private int id;
		private string bi;
		private DateTime dataNasc;
		private string doenca;
		private string situacao;


		public Paciente(int id,string nome,int idade,string bi,DateTime dataNasc,string doenca,string situacao)
		{

            this.id = id;
			this.nome = nome;
			this.idade = idade;
			this.bi = bi;
			this.dataNasc = dataNasc;
			this.doenca = doenca;
			this.situacao = situacao;
		}

        public Paciente()
        {
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Getter e Setter para 'Idade'
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        // Getter e Setter para 'BI'
        public string BI
        {
            get { return bi; }
            set { bi = value; }
        }

        // Getter e Setter para 'DataNasc'
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        // Getter e Setter para 'Doenca'
        public string Doenca
        {
            get { return doenca; }
            set { doenca = value; }
        }

        // Getter e Setter para 'Situacao'
        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }


        public int Id
        {

            get { return id; }
            set { id = value; }

        }



        public string toString()
        {

            string p = nome + " " + idade + " " + bi + " " + dataNasc + " " + doenca + " " + situacao;
            return p;
        }

    }
}

