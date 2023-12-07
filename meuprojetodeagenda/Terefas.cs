class Tarefas
{
    public string tarefa;
    public string data;
    public string endereco;
    public string horario;


    public void ExibirTarefa()
    {
        Console.WriteLine($"Tarefa: {tarefa}");
        Console.WriteLine($"Data: {data}");
        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Horario: {horario}");
    }
}