using System;
namespace Sistema_Gestao_Pacientes.Operacoes
{
	public class OperacoesPacientes
	{
		public OperacoesPacientes()
		{
		}


		public void registrarPaciente()
		{
            /* Para get faz -> paciente.Nome;
             * Para get faz -> paciente.Nome=Joao;
             */
            Paciente paciente = new Paciente();
            Console.WriteLine("Introduza o nome do Paciente");
            paciente.Nome = Console.ReadLine();

            Console.WriteLine("Introduza a Idade do Paciente");
            paciente.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza o bi do Paciente");
            paciente.BI = Console.ReadLine();

            Console.WriteLine("Introduza o Ano de Nascimento");
            int ano = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Introduza o mês de Nascimento");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza o dia de Nascimento");
            int dia = Convert.ToInt32(Console.ReadLine());
            paciente.DataNasc = new DateTime(ano, mes, dia);

            Console.WriteLine("Introduza a doênça do Paciente");
            paciente.Doenca = Console.ReadLine();

            Console.WriteLine("Introduza a situação do Paciente");
            paciente.Situacao = Console.ReadLine();


            BaseDados bd = new BaseDados();
            bd.registarPaciente(paciente);




        }
    }
}

