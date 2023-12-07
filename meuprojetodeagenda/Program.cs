Tarefas tarefa1 = new Tarefas();
tarefa1.tarefa = "Ir no banco com a mãe";
tarefa1.data = "10/12/2023";
tarefa1.endereco = "rua bahia, centro, camboriu, sc";
tarefa1.horario = "10h";

void ExibirLogo()
{
    Console.WriteLine(@"
███╗░░░███╗██╗███╗░░██╗██╗░░██╗░█████╗░  ░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░
████╗░████║██║████╗░██║██║░░██║██╔══██╗  ██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗
██╔████╔██║██║██╔██╗██║███████║███████║  ███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║
██║╚██╔╝██║██║██║╚████║██╔══██║██╔══██║  ██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║
██║░╚═╝░██║██║██║░╚███║██║░░██║██║░░██║  ██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║
╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");
    Console.WriteLine("Boas vindas a MY AGENDA");
};

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para ver listas de tarefas");
    Console.WriteLine("Digite 2 para cadas");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;     
    int opcaoNumericaEscolhia = int.Parse(opcaoEscolhida);

    switch(opcaoNumericaEscolhia) 
    {
        case 1:
            VerListaDeTarefas();
            break;
        case 2:
            RegistrarTarefa();
            break;
        case 3:
            Console.WriteLine("Tchau Tchau :)");
            break;
        default:
            Console.WriteLine("[ERRO] Opção inválida. Digite sua opção.");
            ExibirOpcoesDoMenu();
            break;
    }
};

ExibirOpcoesDoMenu();

void VerListaDeTarefas()
{
    
    Console.Clear();
    
    tarefa1.ExibirTarefa();
};

void RegistrarTarefa()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Registro de Tarefas");
    Console.WriteLine("**********************\n");

};