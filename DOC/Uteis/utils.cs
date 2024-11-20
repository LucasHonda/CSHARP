using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class UtilityToolkit
{
    /// <summary>
    /// Gera uma senha aleatória com letras, números e caracteres especiais.
    /// </summary>
    /// <param name="length">Tamanho da senha (padrão: 12).</param>
    /// <returns>Senha aleatória gerada.</returns>
    public static string GenerateRandomPassword(int length = 12)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        var random = new Random();
        var password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }

    /// <summary>
    /// Obtém a data e hora atual formatada como "yyyy-MM-dd HH:mm:ss".
    /// </summary>
    /// <returns>Data e hora atual formatada.</returns>
    public static string GetFormattedDateTime()
    {
        return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    /// <summary>
    /// Abre o FilePicker para selecionar um arquivo e retorna seu conteúdo.
    /// </summary>
    /// <returns>Conteúdo do arquivo ou mensagem caso nenhum arquivo seja selecionado.</returns>
    public static string PickFileAndReadContents()
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Todos os Arquivos|*.*";
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lê o conteúdo do arquivo
                string filePath = openFileDialog.FileName;
                return File.ReadAllText(filePath);
            }
        }

        return "Nenhum arquivo selecionado.";
    }

    /// <summary>
    /// Valida se um email está no formato correto.
    /// </summary>
    /// <param name="email">Email a ser validado.</param>
    /// <returns>True se o email for válido, False caso contrário.</returns>
    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Toolkit de Utilidades ===");

        // Teste: Gerar senha aleatória
        Console.WriteLine("\n[1] Gerando senha aleatória:");
        Console.WriteLine($"Senha: {UtilityToolkit.GenerateRandomPassword()}");

        // Teste: Obter data e hora formatada
        Console.WriteLine("\n[2] Data e hora atual:");
        Console.WriteLine($"Data e Hora: {UtilityToolkit.GetFormattedDateTime()}");

        // Teste: Abrir FilePicker e ler conteúdo
        Console.WriteLine("\n[3] Abrindo o FilePicker:");
        Console.WriteLine("Conteúdo do arquivo:");
        Console.WriteLine(UtilityToolkit.PickFileAndReadContents());

        // Teste: Validar email
        Console.WriteLine("\n[4] Validando email:");
        string email = "exemplo@email.com";
        Console.WriteLine($"{email} é válido? {UtilityToolkit.IsValidEmail(email)}");
    }
}
