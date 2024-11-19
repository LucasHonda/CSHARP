using System;

class Program
{
    static void Main(string[] args)
    {
        // Tipos b�sicos e como criar vari�veis
        // ------------------------------------

        // 1. String: Para texto
        string nome = "Carlos"; // Use nomes significativos para vari�veis
        Console.WriteLine("Nome (String): " + nome);

        // 2. Int: Para n�meros inteiros
        int idade = 30; // Preferir camelCase para nomes de vari�veis
        Console.WriteLine("Idade (Int): " + idade);

        // 3. Boolean: Para valores true/false
        bool eMaiorDeIdade = idade >= 18; // Sempre inicialize as vari�veis
        Console.WriteLine("� maior de idade? (Boolean): " + eMaiorDeIdade);

        // Outros tipos de dados comuns
        // ----------------------------

        // 4. Double: Para n�meros de ponto flutuante de alta precis�o
        double salario = 4580.75;
        Console.WriteLine("Sal�rio (Double): " + salario);

        // 5. Float: Para n�meros de ponto flutuante com menos precis�o
        float altura = 1.75f; // Note o sufixo 'f' para float
        Console.WriteLine("Altura (Float): " + altura);

        // 6. Char: Para um �nico caractere
        char inicialDoNome = 'C';
        Console.WriteLine("Inicial do nome (Char): " + inicialDoNome);

        // 7. Decimal: Para c�lculos financeiros de alta precis�o
        decimal valorFinanceiro = 19999.99m; // Note o sufixo 'm' para decimal
        Console.WriteLine("Valor financeiro (Decimal): " + valorFinanceiro);

        // 8. Long: Para n�meros inteiros maiores
        long populacaoMundial = 8000000000L; // Note o sufixo 'L' para long
        Console.WriteLine("Popula��o mundial (Long): " + populacaoMundial);

        // 9. DateTime: Para datas e hor�rios
        DateTime dataAtual = DateTime.Now; // Sempre prefira `DateTime.Now` para a data/hora atual
        Console.WriteLine("Data atual (DateTime): " + dataAtual);

        // Tipos Primitivos vs Tipos por Refer�ncia
        // ----------------------------------------

        // Primitivos: S�o armazenados diretamente na stack
        int numero = 42;
        Console.WriteLine("N�mero (Tipo primitivo): " + numero);

        // Por Refer�ncia: Armazenados no heap, usados para classes e objetos
        Pessoa pessoa = new Pessoa
        {
            Nome = "Ana",
            Idade = 25
        };
        Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
        Console.WriteLine("Idade da pessoa: " + pessoa.Idade);

        // Criando Objetos e Boas Pr�ticas
        // -------------------------------
        Pessoa outraPessoa = new Pessoa
        {
            Nome = "Lucas", // Use inicializa��o de objetos para facilitar a leitura
            Idade = 40
        };

        Console.WriteLine("Outra pessoa: " + outraPessoa.Nome + ", Idade: " + outraPessoa.Idade);

        // Evite "hardcoding". Use vari�veis para valores reutiliz�veis.
        int idadeLimite = 18;
        Console.WriteLine("Lucas � maior de idade? " + (outraPessoa.Idade >= idadeLimite));
    }
}

// Classe Pessoa: Seguindo boas pr�ticas
class Pessoa
{
    // Propriedades com `get` e `set` autom�ticos
    public string Nome { get; set; }
    public int Idade { get; set; }

    // M�todo opcional para boas pr�ticas: Para facilitar a exibi��o
    public override string ToString()
    {
        return $"{Nome}, {Idade} anos";
    }
}
