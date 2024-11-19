using System;

class Program
{
    static void Main(string[] args)
    {
        // Tipos básicos e como criar variáveis
        // ------------------------------------

        // 1. String: Para texto
        string nome = "Carlos"; // Use nomes significativos para variáveis
        Console.WriteLine("Nome (String): " + nome);

        // 2. Int: Para números inteiros
        int idade = 30; // Preferir camelCase para nomes de variáveis
        Console.WriteLine("Idade (Int): " + idade);

        // 3. Boolean: Para valores true/false
        bool eMaiorDeIdade = idade >= 18; // Sempre inicialize as variáveis
        Console.WriteLine("É maior de idade? (Boolean): " + eMaiorDeIdade);

        // Outros tipos de dados comuns
        // ----------------------------

        // 4. Double: Para números de ponto flutuante de alta precisão
        double salario = 4580.75;
        Console.WriteLine("Salário (Double): " + salario);

        // 5. Float: Para números de ponto flutuante com menos precisão
        float altura = 1.75f; // Note o sufixo 'f' para float
        Console.WriteLine("Altura (Float): " + altura);

        // 6. Char: Para um único caractere
        char inicialDoNome = 'C';
        Console.WriteLine("Inicial do nome (Char): " + inicialDoNome);

        // 7. Decimal: Para cálculos financeiros de alta precisão
        decimal valorFinanceiro = 19999.99m; // Note o sufixo 'm' para decimal
        Console.WriteLine("Valor financeiro (Decimal): " + valorFinanceiro);

        // 8. Long: Para números inteiros maiores
        long populacaoMundial = 8000000000L; // Note o sufixo 'L' para long
        Console.WriteLine("População mundial (Long): " + populacaoMundial);

        // 9. DateTime: Para datas e horários
        DateTime dataAtual = DateTime.Now; // Sempre prefira `DateTime.Now` para a data/hora atual
        Console.WriteLine("Data atual (DateTime): " + dataAtual);

        // Tipos Primitivos vs Tipos por Referência
        // ----------------------------------------

        // Primitivos: São armazenados diretamente na stack
        int numero = 42;
        Console.WriteLine("Número (Tipo primitivo): " + numero);

        // Por Referência: Armazenados no heap, usados para classes e objetos
        Pessoa pessoa = new Pessoa
        {
            Nome = "Ana",
            Idade = 25
        };
        Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
        Console.WriteLine("Idade da pessoa: " + pessoa.Idade);

        // Criando Objetos e Boas Práticas
        // -------------------------------
        Pessoa outraPessoa = new Pessoa
        {
            Nome = "Lucas", // Use inicialização de objetos para facilitar a leitura
            Idade = 40
        };

        Console.WriteLine("Outra pessoa: " + outraPessoa.Nome + ", Idade: " + outraPessoa.Idade);

        // Evite "hardcoding". Use variáveis para valores reutilizáveis.
        int idadeLimite = 18;
        Console.WriteLine("Lucas é maior de idade? " + (outraPessoa.Idade >= idadeLimite));
    }
}

// Classe Pessoa: Seguindo boas práticas
class Pessoa
{
    // Propriedades com `get` e `set` automáticos
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Método opcional para boas práticas: Para facilitar a exibição
    public override string ToString()
    {
        return $"{Nome}, {Idade} anos";
    }
}
