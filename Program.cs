using System.Reflection;
using DesafioPOO.Models;

// Implementado: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "1234567989", modelo: "Nokia Z", imei: "ABC123", memoria: 64);
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro Max", imei: "XYZ321", memoria: 1000);

bool exibirMenu = true;
string nomeApp;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer com os dispositivos?");
    Console.WriteLine("1 - Ligar");
    Console.WriteLine("2 - Receber ligação");
    Console.WriteLine("3 - Obter informações");
    Console.WriteLine("4 - Instalar aplicativos");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();        
            Console.WriteLine("Nokia:");
            nokia.Ligar();
            Console.WriteLine("iPhone:");
            iphone.Ligar();
            break;
        
        case "2":
            Console.Clear();
            Console.WriteLine("Nokia:");
            nokia.ReceberLigacao();
            Console.WriteLine("iPhone:");
            iphone.ReceberLigacao();
            break;

        case "3":
            Console.Clear();
            Console.WriteLine($"Smartphone Nokia:\nNúmero: {nokia.Numero}\n\nSmartphone iPhone:\nNúmero: {iphone.Numero}");
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("Digite aplicativo a ser instalado no smartphone Nokia:");
            nomeApp = Console.ReadLine();
            nokia.InstalarAplicativo(nomeApp);
            Console.WriteLine("Digite aplicativo a ser instalado no smartphone iPhone:");
            nomeApp = Console.ReadLine();
            iphone.InstalarAplicativo(nomeApp);
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();
    Console.Clear();
}
