using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo 1: If e Else
        int idade = 20;

        if (idade >= 18)
        {
            Console.WriteLine("Voc� � maior de idade.");
        }
        else
        {
            Console.WriteLine("Voc� � menor de idade.");
        }

        // Exemplo 2: If, Else If e Else
        int nota = 85;

        if (nota >= 90)
        {
            Console.WriteLine("Excelente! Voc� tirou A.");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Bom trabalho! Voc� tirou B.");
        }
        else if (nota >= 50)
        {
            Console.WriteLine("Voc� passou com C.");
        }
        else
        {
            Console.WriteLine("Voc� reprovou.");
        }

        // Exemplo 3: Switch
        int opcao = 2;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Voc� escolheu a op��o 1.");
                break;
            case 2:
                Console.WriteLine("Voc� escolheu a op��o 2.");
                break;
            case 3:
                Console.WriteLine("Voc� escolheu a op��o 3.");
                break;
            default:
                Console.WriteLine("Op��o inv�lida.");
                break;
        }

        // Exemplo 4: Operador Tern�rio
        bool eDia = true;
        string mensagem = eDia ? "� dia!" : "� noite!";
        Console.WriteLine(mensagem);

        // Exemplo 5: Uso de Operadores L�gicos
        bool temCarteira = true;
        bool temHabilitacao = false;

        if (temCarteira && temHabilitacao)
        {
            Console.WriteLine("Voc� pode dirigir.");
        }
        else if (temCarteira || temHabilitacao)
        {
            Console.WriteLine("Verifique se todos os documentos est�o v�lidos.");
        }
        else
        {
            Console.WriteLine("Voc� n�o pode dirigir.");
        }

        // Exemplo 6: Uso de Switch com Strings
        string diaSemana = "Segunda-feira";

        switch (diaSemana)
        {
            case "Segunda-feira":
            case "Ter�a-feira":
            case "Quarta-feira":
            case "Quinta-feira":
            case "Sexta-feira":
                Console.WriteLine("� um dia �til.");
                break;
            case "S�bado":
            case "Domingo":
                Console.WriteLine("� fim de semana!");
                break;
            default:
                Console.WriteLine("Dia inv�lido.");
                break;
        }
    }
}


/**
     Operadores Relacionais e L�gicos

        Relacionais:

            ==: Igual a
            !=: Diferente de
            >: Maior que
            <: Menor que
            >=: Maior ou igual a
            <=: Menor ou igual a

       L�gicos:

            &&: E l�gico (True se ambas as condi��es forem verdadeiras)
            ||: Ou l�gico (True se pelo menos uma condi��o for verdadeira)
            !: N�o l�gico (Inverte o valor l�gico)
 
 */