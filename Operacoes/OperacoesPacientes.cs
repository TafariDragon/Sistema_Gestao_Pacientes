using System;
namespace Sistema_Gestao_Pacientes.Operacoes
{
	public class OperacoesPacientes
	{
		public OperacoesPacientes()
		{
		}
        BaseDados bd = new BaseDados();

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


            
            bd.registarPaciente(paciente);




        }


        public void alterarDadosPaciente()
        {
            Paciente paciSub = new Paciente();

            Console.WriteLine("Introduza o numero unico do Paciente");
            int id = Convert.ToInt32(Console.ReadLine());


            if (bd.verificação_Paciente(id) == false)
            {
                 Console.WriteLine("Paciente não encontrado");
            }

            else {
                Console.WriteLine(bd.buscarPaciente(id).toString());
                paciSub = bd.buscarPaciente(id);
                Console.WriteLine("1-Alterar Nome");
                Console.WriteLine("2-Alterar Idade");
                Console.WriteLine("3-Alterar Numero de BI");
                Console.WriteLine("4-Alterar Data de Nascimento");
                Console.WriteLine("5-Aletrar Doênça");
                Console.WriteLine("6-Alterar Situacão");
                Console.WriteLine("0-Voltar ao menu Paciente");
                int opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Introduza o nome do Paciente");
                        string nome = Console.ReadLine();
                        paciSub.Nome = nome;
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id,paciSub);
                    break;

                    case 2:
                        Console.WriteLine("Introduza a Idade do Paciente");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        paciSub.Idade = idade;
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id, paciSub);
                    break;

                    case 3:
                        Console.WriteLine("Introduza o numero de BI do Paciente");
                        string bi = Console.ReadLine();
                        paciSub.BI = bi;
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id, paciSub);
                    break;

                    case 4:
                        Console.WriteLine("Introduza o Ano de Nascimento");
                        int ano = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduza o mês de Nascimento");
                        int mes = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduza o dia de Nascimento");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        paciSub.DataNasc = new DateTime(ano, mes, dia);
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id, paciSub);
                    break;

                    case 5:
                        Console.WriteLine("Introduza a Doenca do Paciente");
                        string doenca = Console.ReadLine();
                        paciSub.Doenca = doenca;
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id, paciSub);
                    break;

                    case 6:
                        Console.WriteLine("Introduza a Situação do Paciente");
                        string s = Console.ReadLine();
                        paciSub.Situacao = s;
                        Console.WriteLine(paciSub.toString());
                        bd.alterarDadosPaciente(id, paciSub);
                    break;

                    case 0:
                        Menus m = new Menus();
                        m.menuPacientes();
                    break;

                    default:
                        Console.WriteLine("Opção Invalida");
                    break;

                }


            }




        }



        public void removerPaciente()
        {
        }

        public void ListarTodosPaciente()
        {
        }


        public void procurarPaciente()
        {
            Console.WriteLine("Introduza o numero unico do Paciente");
            int id = Convert.ToInt32(Console.ReadLine());
            Menus m = new Menus();

            if (bd.verificação_Paciente(id) == false)
            {
                Console.WriteLine("Paciente não encontrado");
                m.menuPacientes();

            }
            else {
                Console.WriteLine(bd.buscarPaciente(id).toString());
                m.menuPacientes();
            }




        }
    }
}

