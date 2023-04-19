public static class Menu
{
    public static void ChamarMenu()
    {
        string resp;

        Console.WriteLine("\nQual solução voce quer ver agora?\n\n" +
        "[1] - Busca Fibonacci\n" +
        "[2] - Calcula percentual de faturamento\n" +
        "[3] - Inverte frase\n");
        resp = Console.ReadLine();

        switch (resp)
        {
            case "1":
                Console.Clear();
                Fibonacci.Inicia();
                break;

            case "2":
                Console.Clear();
                Faturamento.Inicia();
                break;

            case "3":
                Console.Clear();
                Inverter.Inicia();
                break;

            default:
                Console.WriteLine("Opção inválida! Encerrando aplicação.");
                break;
        }

    }
}