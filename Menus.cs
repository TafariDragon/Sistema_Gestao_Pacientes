using System;
namespace Sistema_Gestao_Pacientes
{
	public class Menus
	{
		public Menus()
		{
		}


		public void menuPrincipal()
		{

            System.Console.WriteLine("============================");
            System.Console.WriteLine("= 1-Gestão Pacientes       =");
			System.Console.WriteLine("= 2-Gestão Medicamentos    =");
			System.Console.WriteLine("= 0-Sair                   =");
            System.Console.WriteLine("============================");
            System.Console.WriteLine("");
			string opcao = Console.ReadLine();
			int op = int.Parse(opcao);

			switch (op)
			{

				case 1:
					menuPacientes();
				break;

                case 2:
                    menuMedicamentos();
                break;

                case 0:
                   
                break;

				default:
					Console.WriteLine("Fora de opção");
				break;

            }

        }


		public void menuPacientes()
		{

            System.Console.WriteLine("********************************");
            System.Console.WriteLine("* 1-Registar Paciente          *");
            System.Console.WriteLine("* 2-Alter Dados Do Paciente    *");
            System.Console.WriteLine("* 3-Remover Paciente           *");
            System.Console.WriteLine("* 4-Listar Todos os Pacinetes  *");
            System.Console.WriteLine("* 5-Procurar Paciente          *");
            System.Console.WriteLine("* 0-Menu Principal             *");
            System.Console.WriteLine("********************************");
            System.Console.WriteLine("");
            string opcao = Console.ReadLine();
            int op = int.Parse(opcao);

            switch (op)
            {

                case 1:
                     
                break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;

                case 5:

                break;

                case 0:
                    menuPrincipal();
                break;

                default:
                    Console.WriteLine("Fora de opção");
                break;

            }




        }



        public void menuMedicamentos()
        {

            System.Console.WriteLine("***********************************");
            System.Console.WriteLine("* 1-Registar Medicamento          *");
            System.Console.WriteLine("* 2-Alter Dados Do Medicamento    *");
            System.Console.WriteLine("* 3-Remover Medicamento           *");
            System.Console.WriteLine("* 4-Listar Todos os Medicamentos  *");
            System.Console.WriteLine("* 5-Procurar Medicamento          *");
            System.Console.WriteLine("* 0-Menu Principal                *");
            System.Console.WriteLine("***********************************");
            System.Console.WriteLine("");
            string opcao = Console.ReadLine();
            int op = int.Parse(opcao);

            switch (op)
            {

                case 1:

                break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;

                case 5:

                break;

                case 0:
                    menuPrincipal();
                break;

                default:
                    Console.WriteLine("Fora de opção");
                break;

            }


        }
	}
}

