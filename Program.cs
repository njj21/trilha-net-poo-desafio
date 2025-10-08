using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Nokia
        Nokia meuNokia = new Nokia("1234-5678", "Nokia 3310", "111222333444555", 00);
        Console.WriteLine("Teste Nokia");
        Console.WriteLine($"Número: {meuNokia.Numero}");
        Console.WriteLine($"Modelo: {meuNokia.Modelo}");
        Console.WriteLine($"IMEI: {meuNokia.IMEI}");
        Console.WriteLine($"Memória: {meuNokia.Memoria} GB");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // iPhone
        Iphone meuIphone = new Iphone("991413637-", "iPhone 14", "555444333222111", 000);
        Console.WriteLine("Teste iPhone");
        Console.WriteLine($"Número: {meuIphone.Numero}");
        Console.WriteLine($"Modelo: {meuIphone.Modelo}");
        Console.WriteLine($"IMEI: {meuIphone.IMEI}");
        Console.WriteLine($"Memória: {meuIphone.Memoria} GB");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("TikTok");

        Console.WriteLine();

        // Polimorfismo
        Smartphone[] celulares = { meuNokia, meuIphone };
        Console.WriteLine("Teste Polimorfismo");
        foreach (var celular in celulares)
        {
            celular.Ligar();
            celular.InstalarAplicativo("Spotify");
        }
    }
}