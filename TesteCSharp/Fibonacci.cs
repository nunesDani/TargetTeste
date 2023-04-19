public static class Fibonacci
{
    public static void Inicia()
    {
        int n, resp;

            Console.WriteLine("Escolha um número e veja se ele faz parte da sequência de Fibonacci.");
            n = Convert.ToInt32(Console.ReadLine());

            if (calculaFibonacci(n))
            {
                Console.WriteLine("Pertence!");
            }
            else
            {
                Console.WriteLine("Não pertence!");
            }

            Menu.ChamarMenu();

    }
    private static bool calculaFibonacci(int num)
    {
        bool pertence = false;
        int atual = 0;
        int[] valores = new int[3] { 0, 1, 1 };

        if (num == 0 || num == 1)
        {
            pertence = true;
            return pertence;
        }

        else
        {
            while (num > atual)
            {
                valores[0] = valores[1];
                valores[1] = valores[2];
                valores[2] = valores[0] + valores[1];

                atual = valores[2];

                if (num == atual)
                {
                    pertence = true;
                }
            }

            return pertence;
        }
    }
}