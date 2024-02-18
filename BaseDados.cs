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


        public bool verificação_Paciente(int id)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                // Cria um comando SQL para verificar se o paciente existe
                string query = "SELECT COUNT(*) FROM Paciente WHERE idPaciente = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                // Executa o comando e obtém o número de registros encontrados
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados
                connection.Close();
            }

            return false;


        }


        public void alterarDadosPaciente(int id ,Paciente paciente)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Monta a consulta SQL de atualização
                string query = "UPDATE Paciente SET Nome = @nome, Idade = @idade, BI = @bi, Data_Nascimento = @dataNasc, Doenca = @doenca, Situacao = @situacao WHERE idPaciente = @id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Adiciona os parâmetros à consulta
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nome", paciente.Nome);
                command.Parameters.AddWithValue("@idade", paciente.Idade);
                command.Parameters.AddWithValue("@bi", paciente.BI);
                command.Parameters.AddWithValue("@dataNasc", paciente.DataNasc);
                command.Parameters.AddWithValue("@doenca", paciente.Doenca);
                command.Parameters.AddWithValue("@situacao", paciente.Situacao);

                // Executa a consulta de atualização
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Dados do paciente atualizados com sucesso.");
                }
                else
                {
                    Console.WriteLine("Nenhum paciente foi atualizado. Verifique se o ID do paciente está correto.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        public Paciente buscarPaciente(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            Paciente paciente = new Paciente();
            try
            {
                connection.Open();

                string query = "SELECT * FROM Paciente WHERE idPaciente = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                // Executa a consulta
                MySqlDataReader reader = command.ExecuteReader();

                // Verifica se há linhas retornadas
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Aqui você pode acessar os dados do paciente
                        int pacienteId = reader.GetInt32("idPaciente");
                        paciente.Nome = reader.GetString("Nome");
                        paciente.Idade = reader.GetInt32("Idade");
                        paciente.BI = reader.GetString("BI");
                        paciente.DataNasc = reader.GetDateTime("Data_Nascimento");
                        paciente.Doenca= reader.GetString("Doenca");
                        paciente.Situacao = reader.GetString("Situacao");

                       
                    }
                }
                else
                {
                    Console.WriteLine("Paciente não encontrado.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return paciente;

        }


        public List<Paciente> getallPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM Paciente";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        // Preencha os detalhes do paciente
                        Id = reader.GetInt32("idPaciente"),
                        Nome = reader.GetString("Nome"),
                        Idade = reader.GetInt32("Idade"),
                        BI = reader.GetString("BI"),
                        DataNasc = reader.GetDateTime("Data_Nascimento"),
                        Doenca = reader.GetString("Doenca"),
                        Situacao = reader.GetString("Situacao")
                    };
                    pacientes.Add(paciente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return pacientes;

        }



        public void removerPaciente(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Monta a consulta SQL de exclusão
                string query = "DELETE FROM Paciente WHERE idPaciente = @id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Adiciona o parâmetro à consulta
                command.Parameters.AddWithValue("@id", id);

                // Executa a consulta de exclusão
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Paciente removido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Nenhum paciente foi removido. Verifique se o ID do paciente está correto.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }


    }
}

