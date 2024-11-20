using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main(string[] args)
    {
        // String de conexão
        string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;";

        // Testando a conexão
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com MySQL bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }
        }

        static void ExecuteNonQuery(string query, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Operação bem-sucedida! Linhas afetadas: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao executar a consulta: " + ex.Message);
                }
            }
        }

        string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;";
        string insertQuery = "INSERT INTO usuarios (nome, email) VALUES ('Carlos', 'carlos@email.com');";
        ExecuteNonQuery(insertQuery, connectionString);

        static void ExecuteSelect(string query, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Supondo que a tabela "usuarios" tenha colunas "nome" e "email"
                            string nome = reader["nome"].ToString();
                            string email = reader["email"].ToString();
                            Console.WriteLine($"Nome: {nome}, Email: {email}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao executar a consulta: " + ex.Message);
                }
            }
        }

        string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;";
        string selectQuery = "SELECT nome, email FROM usuarios;";
        ExecuteSelect(selectQuery, connectionString);



        static void InsertUser(string nome, string email, string connectionString)
        {
            string query = $"INSERT INTO usuarios (nome, email) VALUES ('{nome}', '{email}');";
            ExecuteNonQuery(query, connectionString);
        }

        static void UpdateUserEmail(int userId, string newEmail, string connectionString)
        {
            string query = $"UPDATE usuarios SET email = '{newEmail}' WHERE id = {userId};";
            ExecuteNonQuery(query, connectionString);
        }

        static void DeleteUser(int userId, string connectionString)
        {
            string query = $"DELETE FROM usuarios WHERE id = {userId};";
            ExecuteNonQuery(query, connectionString);
        }


        string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;";

        // Inserindo um novo usuário
        InsertUser("Ana", "ana@email.com", connectionString);

        // Atualizando o email de um usuário
        UpdateUserEmail(1, "ana.nova@email.com", connectionString);

        // Deletando um usuário
        DeleteUser(1, connectionString);

    }
}
