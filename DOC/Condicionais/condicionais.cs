using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo 1: If e Else
        int idade = 20;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }

        // Exemplo 2: If, Else If e Else
        int nota = 85;

        if (nota >= 90)
        {
            Console.WriteLine("Excelente! Você tirou A.");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Bom trabalho! Você tirou B.");
        }
        else if (nota >= 50)
        {
            Console.WriteLine("Você passou com C.");
        }
        else
        {
            Console.WriteLine("Você reprovou.");
        }

        // Exemplo 3: Switch
        int opcao = 2;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Você escolheu a opção 1.");
                break;
            case 2:
                Console.WriteLine("Você escolheu a opção 2.");
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção 3.");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        // Exemplo 4: Operador Ternário
        bool eDia = true;
        string mensagem = eDia ? "É dia!" : "É noite!";
        Console.WriteLine(mensagem);

        // Exemplo 5: Uso de Operadores Lógicos
        bool temCarteira = true;
        bool temHabilitacao = false;

        if (temCarteira && temHabilitacao)
        {
            Console.WriteLine("Você pode dirigir.");
        }
        else if (temCarteira || temHabilitacao)
        {
            Console.WriteLine("Verifique se todos os documentos estão válidos.");
        }
        else
        {
            Console.WriteLine("Você não pode dirigir.");
        }

        // Exemplo 6: Uso de Switch com Strings
        string diaSemana = "Segunda-feira";

        switch (diaSemana)
        {
            case "Segunda-feira":
            case "Terça-feira":
            case "Quarta-feira":
            case "Quinta-feira":
            case "Sexta-feira":
                Console.WriteLine("É um dia útil.");
                break;
            case "Sábado":
            case "Domingo":
                Console.WriteLine("É fim de semana!");
                break;
            default:
                Console.WriteLine("Dia inválido.");
                break;
        }
    }
}


/**
     Operadores Relacionais e Lógicos

        Relacionais:

            ==: Igual a
            !=: Diferente de
            >: Maior que
            <: Menor que
            >=: Maior ou igual a
            <=: Menor ou igual a

       Lógicos:

            &&: E lógico (True se ambas as condições forem verdadeiras)
            ||: Ou lógico (True se pelo menos uma condição for verdadeira)
            !: Não lógico (Inverte o valor lógico)
 
 */