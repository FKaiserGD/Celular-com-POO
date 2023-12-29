using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        // Criação de instâncias dos smartphones
        Nokia nokia = new Nokia("123456789");
        Iphone iphone = new Iphone("987654321");

        // Teste dos métodos
        RealizarTestes("Nokia", nokia, "WhatsApp");

        // Adiciona uma linha em branco entre as mensagens dos smartphones
        Console.WriteLine();

        RealizarTestes("iPhone", iphone, "Instagram");

        // Mensagem final
        Console.WriteLine("\nTestes concluídos. Obrigado!");
    }

    static void RealizarTestes(string nomeSmartphone, Smartphone smartphone, string nomeApp)
    {
        Console.WriteLine($"\nTestes com {nomeSmartphone}:\n");

        // Ligando e recebendo uma ligação
        smartphone.Ligar();
        smartphone.ReceberLigacao();

        // Instalando um aplicativo específico
        smartphone.InstalarAplicativo(nomeApp);
        smartphone.AplicativoInstalado(nomeApp);

        // Adiciona uma linha em branco entre as mensagens
        Console.WriteLine();
    }
}