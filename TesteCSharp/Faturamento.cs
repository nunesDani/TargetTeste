public static class Faturamento {
    
    public static void Inicia(){
        float SP_fat = 67836.43f;
        float RJ_fat = 36678.66f;
        float MG_fat = 29229.88f;
        float ES_fat = 27165.48f;
        float outros = 19849.53f;

        float TotalFat = SP_fat+RJ_fat+MG_fat+ES_fat+outros;

        Console.WriteLine("Segue abaixo o valor faturado por região:\n");
        
        Console.WriteLine("São Paulo: " + SP_fat.ToString("C") + 
        " representando " + Porcentagem(SP_fat, TotalFat) + "% de lucro.");

        Console.WriteLine("Rio de Janeiro: " + SP_fat.ToString("C") + 
        " representando " + Porcentagem(RJ_fat, TotalFat) + "% de lucro.");

        Console.WriteLine("Minas Gerais: " + SP_fat.ToString("C") + 
        " representando " + Porcentagem(MG_fat, TotalFat) + "% de lucro.");
        
        Console.WriteLine("Espírito Santo: " + SP_fat.ToString("C") + 
        " representando " + Porcentagem(ES_fat, TotalFat) + "% de lucro.");

        Console.WriteLine("Outros: " + SP_fat.ToString("C") + " representando " + Porcentagem(outros, TotalFat) + "% de lucro.");

        Menu.ChamarMenu();

    }

    public static string Porcentagem(float fat, float total){
        float result;

        result = fat/total*100;
        return result.ToString("F"); 
    }


}