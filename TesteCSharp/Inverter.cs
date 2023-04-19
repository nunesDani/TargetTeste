public static class Inverter
{
    public static void Inicia()
    {
        string texto;
        int count = 1;

        Console.WriteLine("Digite a palavra ou frase a ser invertida.");
        texto = Console.ReadLine();

        texto.ToArray();
        char [] invertido = new char[texto.Length];

        for(int i = 0; i < texto.Length; i++){
            invertido[i] = texto[texto.Length - count];
            count++;
        }

        foreach (char c in invertido)
        {
            Console.Write(c);
        }

        Menu.ChamarMenu();
    }
}