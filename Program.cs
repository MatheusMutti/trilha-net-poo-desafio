using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nokia");
        Nokia nokia = new Nokia("1111111111", "modelo padrao", "223232323", 64);
        nokia.InstalarAplicativo("WhatsApp");
        nokia.Ligar();
        nokia.ReceberLigacao();

        Console.WriteLine("\n");


        Console.WriteLine("Iphone");
        Iphone iphone = new Iphone("222222222222", "modelo padrao", "454545454", 128);
        iphone.InstalarAplicativo("Telegram");
        iphone.Ligar();
        iphone.ReceberLigacao();
    }
}