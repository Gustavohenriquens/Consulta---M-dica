using projeto_1.Models;




Consulta c = new Consulta();

bool exibirConsulta = true;

while (exibirConsulta)
{
    Console.Clear();
    Console.WriteLine("1 - Agendar Consulta");
    Console.WriteLine("2 - Visualizar Consulta");
    Console.WriteLine("3 - Desmarcar Consulta");
    Console.WriteLine("4 - Remarcar Consulta");
    Console.WriteLine("5 - Encerrar Sistema");

    switch(Console.ReadLine())
    {
        case "1" :  
            c.AgendarConsulta();
            break;

        case "2" :
            c.visualiarConsulta();
            break;

        case "3" :
            c.DesmarcarConsulta();
            break;

        case "4" :
            c.remarcarConsulta();
            break;

        case "5" :
            exibirConsulta = false;
            break;

        default :
            Console.WriteLine("Opção Inválida");
            break;
    }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();

}
        Console.WriteLine("O Sistema se encerrou");














