using System;
using Sistema_Gestao_Pacientes.Operacoes;
using MySql.Data.MySqlClient;

namespace Sistema_Gestao_Pacientes
{
	public class BaseDados
	{
        string connectionString;

        public BaseDados()
		{
           connectionString = "Server=LocalHost;Database=BDHospital;User=root;Password=;";
        }


        public void registarPaciente(Paciente paciente)
        {
            using MySqlConnection conexao = new MySqlConnection(connectionString);
            conexao.Open();

            string query = "INSERT INTO Paciente (Nome, Idade, BI, Data_Nascimento, Doenca, Situacao) " +
                "VALUES (@Nome, @Idade, @BI, @Data_Nascimento, @Doenca, @Situacao)";


            using MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
            cmd.Parameters.AddWithValue("@Idade", paciente.Idade);
            cmd.Parameters.AddWithValue("@BI", paciente.BI);
            cmd.Parameters.AddWithValue("@Data_Nascimento", paciente.DataNasc);
            cmd.Parameters.AddWithValue("@Doenca", paciente.Doenca);
            cmd.Parameters.AddWithValue("@Situacao", paciente.Situacao);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Paciente registrado com sucesso!");

            // Fechar a conexão
            conexao.Close();

            Menus m = new Menus();
            m.menuPacientes();

        }


    }
}

